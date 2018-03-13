namespace Ball
{
    partial class dlg_Score
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
            this.L_Score = new System.Windows.Forms.Label();
            this.L_TotalScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // L_Score
            // 
            this.L_Score.AutoSize = true;
            this.L_Score.Location = new System.Drawing.Point(45, 22);
            this.L_Score.Name = "L_Score";
            this.L_Score.Size = new System.Drawing.Size(41, 13);
            this.L_Score.TabIndex = 0;
            this.L_Score.Text = "Score :";
            // 
            // L_TotalScore
            // 
            this.L_TotalScore.AutoSize = true;
            this.L_TotalScore.Location = new System.Drawing.Point(92, 22);
            this.L_TotalScore.Name = "L_TotalScore";
            this.L_TotalScore.Size = new System.Drawing.Size(62, 13);
            this.L_TotalScore.TabIndex = 1;
            this.L_TotalScore.Text = "Total Score";
            // 
            // dlg_Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 53);
            this.Controls.Add(this.L_TotalScore);
            this.Controls.Add(this.L_Score);
            this.MaximizeBox = false;
            this.Name = "dlg_Score";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Score";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dlg_Score_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_Score;
        private System.Windows.Forms.Label L_TotalScore;
    }
}