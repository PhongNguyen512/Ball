namespace Ball
{
    partial class dlg_SelectLvl
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
            this.GroupB = new System.Windows.Forms.GroupBox();
            this.RB_Hard = new System.Windows.Forms.RadioButton();
            this.RB_Medium = new System.Windows.Forms.RadioButton();
            this.RB_Easy = new System.Windows.Forms.RadioButton();
            this.B_Ok = new System.Windows.Forms.Button();
            this.B_Cancel = new System.Windows.Forms.Button();
            this.GroupB.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupB
            // 
            this.GroupB.Controls.Add(this.RB_Hard);
            this.GroupB.Controls.Add(this.RB_Medium);
            this.GroupB.Controls.Add(this.RB_Easy);
            this.GroupB.Location = new System.Drawing.Point(12, 12);
            this.GroupB.Name = "GroupB";
            this.GroupB.Size = new System.Drawing.Size(140, 98);
            this.GroupB.TabIndex = 0;
            this.GroupB.TabStop = false;
            this.GroupB.Text = "Level";
            // 
            // RB_Hard
            // 
            this.RB_Hard.AutoSize = true;
            this.RB_Hard.Location = new System.Drawing.Point(16, 65);
            this.RB_Hard.Name = "RB_Hard";
            this.RB_Hard.Size = new System.Drawing.Size(48, 17);
            this.RB_Hard.TabIndex = 3;
            this.RB_Hard.TabStop = true;
            this.RB_Hard.Text = "Hard";
            this.RB_Hard.UseVisualStyleBackColor = true;
            // 
            // RB_Medium
            // 
            this.RB_Medium.AutoSize = true;
            this.RB_Medium.Location = new System.Drawing.Point(16, 42);
            this.RB_Medium.Name = "RB_Medium";
            this.RB_Medium.Size = new System.Drawing.Size(62, 17);
            this.RB_Medium.TabIndex = 2;
            this.RB_Medium.TabStop = true;
            this.RB_Medium.Text = "Medium";
            this.RB_Medium.UseVisualStyleBackColor = true;
            // 
            // RB_Easy
            // 
            this.RB_Easy.AutoSize = true;
            this.RB_Easy.Checked = true;
            this.RB_Easy.Location = new System.Drawing.Point(16, 19);
            this.RB_Easy.Name = "RB_Easy";
            this.RB_Easy.Size = new System.Drawing.Size(48, 17);
            this.RB_Easy.TabIndex = 1;
            this.RB_Easy.TabStop = true;
            this.RB_Easy.Text = "Easy";
            this.RB_Easy.UseVisualStyleBackColor = true;
            // 
            // B_Ok
            // 
            this.B_Ok.Location = new System.Drawing.Point(12, 120);
            this.B_Ok.Name = "B_Ok";
            this.B_Ok.Size = new System.Drawing.Size(75, 23);
            this.B_Ok.TabIndex = 1;
            this.B_Ok.Text = "OK";
            this.B_Ok.UseVisualStyleBackColor = true;
            this.B_Ok.Click += new System.EventHandler(this.B_Ok_Click);
            // 
            // B_Cancel
            // 
            this.B_Cancel.Location = new System.Drawing.Point(103, 120);
            this.B_Cancel.Name = "B_Cancel";
            this.B_Cancel.Size = new System.Drawing.Size(75, 23);
            this.B_Cancel.TabIndex = 2;
            this.B_Cancel.Text = "Cancel";
            this.B_Cancel.UseVisualStyleBackColor = true;
            // 
            // dlg_SelectLvl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 150);
            this.Controls.Add(this.B_Cancel);
            this.Controls.Add(this.B_Ok);
            this.Controls.Add(this.GroupB);
            this.Name = "dlg_SelectLvl";
            this.Text = "Select Level";
            this.GroupB.ResumeLayout(false);
            this.GroupB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupB;
        private System.Windows.Forms.RadioButton RB_Hard;
        private System.Windows.Forms.RadioButton RB_Medium;
        private System.Windows.Forms.RadioButton RB_Easy;
        private System.Windows.Forms.Button B_Ok;
        private System.Windows.Forms.Button B_Cancel;
    }
}