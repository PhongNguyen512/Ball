namespace Ball
{
    partial class Ballzzz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CheckB_ShowScore = new System.Windows.Forms.CheckBox();
            this.CheckB_Speed = new System.Windows.Forms.CheckBox();
            this.B_Play = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CheckB_ShowScore
            // 
            this.CheckB_ShowScore.AutoSize = true;
            this.CheckB_ShowScore.Location = new System.Drawing.Point(12, 21);
            this.CheckB_ShowScore.Name = "CheckB_ShowScore";
            this.CheckB_ShowScore.Size = new System.Drawing.Size(84, 17);
            this.CheckB_ShowScore.TabIndex = 0;
            this.CheckB_ShowScore.Text = "Show Score";
            this.CheckB_ShowScore.UseVisualStyleBackColor = true;
            this.CheckB_ShowScore.CheckedChanged += new System.EventHandler(this.CheckB_ShowScore_CheckedChanged);
            // 
            // CheckB_Speed
            // 
            this.CheckB_Speed.AutoSize = true;
            this.CheckB_Speed.Location = new System.Drawing.Point(12, 44);
            this.CheckB_Speed.Name = "CheckB_Speed";
            this.CheckB_Speed.Size = new System.Drawing.Size(136, 17);
            this.CheckB_Speed.TabIndex = 1;
            this.CheckB_Speed.Text = "Show Animation Speed";
            this.CheckB_Speed.UseVisualStyleBackColor = true;
            this.CheckB_Speed.CheckedChanged += new System.EventHandler(this.CheckB_ShowScore_CheckedChanged);
            // 
            // B_Play
            // 
            this.B_Play.Location = new System.Drawing.Point(109, 69);
            this.B_Play.Name = "B_Play";
            this.B_Play.Size = new System.Drawing.Size(75, 23);
            this.B_Play.TabIndex = 2;
            this.B_Play.Text = "Play";
            this.B_Play.UseVisualStyleBackColor = true;
            this.B_Play.Click += new System.EventHandler(this.B_Play_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Ballzzz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 104);
            this.Controls.Add(this.B_Play);
            this.Controls.Add(this.CheckB_Speed);
            this.Controls.Add(this.CheckB_ShowScore);
            this.Name = "Ballzzz";
            this.Text = "Ballzzz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckB_ShowScore;
        private System.Windows.Forms.CheckBox CheckB_Speed;
        private System.Windows.Forms.Button B_Play;
        private System.Windows.Forms.Timer Timer;
    }
}

