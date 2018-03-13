//*********************************************************************
//Description: Create a form for playing Drop Ball game, with 2 check boxes  
//              for showing Score and Speed Selection in main form, also a
//              dialog for selection difficult. After choosing  difficult,
//              program will create a GDI window and fill up with random 
//              color ball. When user click a ball, program will looking for
//              the same color around the click point and KILL them. After kill
//              balls, program will drop the ball. The program finish when no more ball
//*********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;
using System.IO;

namespace Ball
{
    public partial class Ballzzz : Form
    {
        //initial enum for ball state
        public enum BallState { alive, dead }
        //initial ball structure for ball color and state
        public struct Ball
        {
            public Color BallColor;
            public BallState BallState;
            public Ball(Color _BallColor, BallState _BallState)
            {
                BallColor = _BallColor;

                BallState = _BallState;
            }
        }

        //all related dlgs are create here
        private dlg_SelectLvl dlg_select = new dlg_SelectLvl();
        private dlg_Score dlg_score = new dlg_Score();
        private dlg_Speed dlg_speed = new dlg_Speed();
        private dlg_HighScore dlg_highscore = new dlg_HighScore();

        //initial for CDrawer
        private CDrawer canvas;

        //initial constant variable using through program
        const int BallSize = 200;
        const int Width = 800;
        const int Height = 600;
        const int rowCount = Height / BallSize;
        const int columnCount = Width / BallSize;

        //array for ball location, related to structure Ball
        private Ball[,] ballLocation = new Ball[rowCount, columnCount];

        //total ball dead using in CheckBalls()
        private int totalBallDead;

        //total score after done game      
        private int totalScore;

        //speed of animation
        private int delayTime = 10;

        //highest score of all play time
        private int highestScore = 0;

        //difficulty of the game
        private string modeLVL;

        private bool _1stRun = false;

        public Ballzzz()
        {
            InitializeComponent();
            dlg_score.buttonOff = new dlg_Score.delvoidbool(changeState);
            dlg_speed.SpeedbuttonOff = new dlg_Speed.delvoidbool(SpeedchangeState);
            dlg_score.getValue(totalScore);
        }

        private void B_Play_Click(object sender, EventArgs e)
        {
            //reset difficult, final score, and total ball dead
            int Level = 0;
            totalScore = 0;
            totalBallDead = 0;

            //open the SelectLvl dialog
            if (dlg_select.ShowDialog() == DialogResult.OK)
            {
                //get the difficult
                modeLVL = dlg_select.lvlSelection();

                //check the chosen difficult and set the color for ball
                if (modeLVL == "Easy")
                    Level = 3;
                else if (modeLVL == "Medium")
                    Level = 4;
                else
                    Level = 5;

                //check if canvas is null or not
                if (canvas == null)
                    canvas = new CDrawer();
                else
                    canvas.Clear();

                //create a random color ball and store it in array of ball location
                Randomize(Level);

                //draw balls
                Display();

                B_Play.Enabled = false;

                Timer.Enabled = true;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            highestScore = totalScore;

            //checking all ball dead or not
            if (BallsAlive() == 0)
            {
                Timer.Enabled = false;

                B_Play.Enabled = true;

                canvas.Clear();

                canvas.AddText("Game Over", 75);

                if (File.Exists("output.txt") && !_1stRun)
                {
                    File.Delete("output.txt");
                    _1stRun = true;
                }

                if (totalScore >= highestScore)
                {
                    dlg_highscore.getDefault("Input your name:");

                    if (dlg_highscore.ShowDialog() == DialogResult.OK)
                    {
                        //chekc again the dlg high score
                        StreamWriter sw = new StreamWriter("output.txt", true);
                        sw.WriteLine(dlg_highscore.Text + " " + totalScore.ToString() + "  Mode:" + modeLVL);

                        sw.Close();
                    }
                }
            }
            else
                //get score for each time click the ball
                totalScore += Pick();

            dlg_speed.valueChanged = new dlg_Speed.delvoidint(changeSpeed);
            dlg_score.getValue(totalScore);
        }

        //Random method
        //create random color ball and assign it into ball location array
        private void Randomize(int Level)
        {
            Random rand = new Random();

            //initial basic color
            Color[] basicColor = new Color[5] { Color.Azure, Color.BlanchedAlmond, Color.Chocolate, Color.DarkCyan, Color.DarkOrange };

            //go each row and col in array location
            for (int row = 0; row < ballLocation.GetLength(0); row++)
            {
                for (int col = 0; col < ballLocation.GetLength(1); col++)
                {
                    //set the ball in that location is alive
                    ballLocation[row, col].BallState = BallState.alive;
                    //create a color base on difficult
                    ballLocation[row, col].BallColor = basicColor[rand.Next(Level)];
                }
            }
        }

        //Display method
        //draw each ball based on ball location and color of ball
        private void Display()
        {
            canvas.Clear();

            for (int row = 0; row < ballLocation.GetLength(0); row++)
            {
                for (int col = 0; col < ballLocation.GetLength(1); col++)
                {
                    if (ballLocation[row, col].BallState == BallState.alive)
                    {
                        canvas.AddEllipse(col * BallSize, row * BallSize, BallSize, BallSize, ballLocation[row, col].BallColor);
                    }
                }
            }
        }

        //Ball alive
        //check how many ball is alive, and return number for quit the program when the no more ball alive
        private int BallsAlive()
        {
            int aliveBallCount = 0;

            for (int row = 0; row < ballLocation.GetLength(0); row++)
            {
                for (int col = 0; col < ballLocation.GetLength(1); col++)
                {
                    if (ballLocation[row, col].BallState == BallState.alive)
                    {
                        aliveBallCount++;
                    }
                }
            }
            return aliveBallCount;
        }


        //CheckBall method
        //check balls which are next to the clicked ball
        private int CheckBalls(int row, int col, Color colorCheck)
        {
            //return 0 if the checking location outside of gdi draw
            if (col < 0 || col >= columnCount || row < 0 || row >= rowCount)
                return 0;

            //return 0 if the balls near the current ball are dead or color do not match
            if ((ballLocation[row, col].BallState == BallState.dead) || (ballLocation[row, col].BallColor != colorCheck))
                return 0;

            else
            {
                totalBallDead++;
                //check balls in 4 direction
                ballLocation[row, col].BallState = BallState.dead;

                CheckBalls(row - 1, col, colorCheck); //left            
                CheckBalls(row + 1, col, colorCheck); // right           
                CheckBalls(row, col - 1, colorCheck); // up
                CheckBalls(row, col + 1, colorCheck); // down 
            }
            return totalBallDead;
        }

        //Step Down method
        //check the above ball of the clicked ball. If it alive, move it down to the dead ball location
        private int StepDown()
        {
            int totalBallDrop = 0;

            //checking each ball in GDI window
            for (int row = 0; row < ballLocation.GetLength(0); row++)
            {
                for (int col = 0; col < ballLocation.GetLength(1); col++)
                {
                    ///check current ball location dead or not
                    if (ballLocation[row, col].BallState == BallState.dead)
                    {
                        //if it dead, check the ball above it and move it into the dead location
                        if (row > 0)
                            if (ballLocation[row - 1, col].BallState == BallState.alive)
                            {
                                ballLocation[row, col] = ballLocation[row - 1, col];

                                ballLocation[row - 1, col].BallState = BallState.dead;

                                totalBallDrop++;
                            }
                    }
                }
            }

            return totalBallDrop;
        }

        //Fall Down method
        //running animation
        private int FallDown()
        {
            int totalStepDown = 0;

            do
            {

                totalStepDown += StepDown();
            }
            while (StepDown() > 0);
            System.Threading.Thread.Sleep(delayTime);
            Display();
            return totalStepDown;
        }


        //Pick method
        //main method of program, method will get the location from user click.
        //then use another method for checking balls and get the score based on
        //how many balls dead
        private int Pick()
        {
            //initial score for each click
            int currentPoint = 0;

            //initial location of clicked ball
            Point point;

            int row = 0;

            int col = 0;

            //get the location from the left click
            if (canvas.GetLastMouseLeftClick(out point))
            {
                //get the row and col from the location of y and x
                row = point.Y / BallSize;
                col = point.X / BallSize;

                //checking if clicked ball is alive or not
                if (ballLocation[row, col].BallState == BallState.dead)
                {
                    Console.Beep();
                }
                else
                {
                    totalBallDead = 0;

                    //recursivly kills all adjacent balls of same color that are alive
                    int balls = CheckBalls(row, col, ballLocation[row, col].BallColor); 

                    if (balls == 1)
                        currentPoint = (balls) * 50;
                    else if (balls == 2)
                        currentPoint = balls * 2 * 50;
                    else if (balls == 3)
                        currentPoint = balls * 3 * 50;
                    else if (balls == 4)
                        currentPoint = balls * 4 * 50;
                    else
                        currentPoint = balls * 5 * 50;

                    //drop down the alive balls after kill all clicked ball and same color balls of clicked ball
                    FallDown();
                }
            }
            return currentPoint;
        }

        //update check state of check box
        private void CheckB_ShowScore_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckB_ShowScore.CheckState == CheckState.Checked)
                dlg_score.Show();
            else
                dlg_score.Hide();

            if (CheckB_Speed.CheckState == CheckState.Checked)
                dlg_speed.Show();
            else
                dlg_speed.Hide();
        }

        //method for update animation speed from delegate
        private void changeSpeed(int speed)
        {
            delayTime = speed;
        }

        //method for enable button from delegate
        public void changeState(bool check)
        {
            if (check)
                CheckB_ShowScore.Checked = false;
        }
        public void SpeedchangeState(bool check)
        {
            if (check)
                CheckB_Speed.Checked = false;
        }

    }
}
