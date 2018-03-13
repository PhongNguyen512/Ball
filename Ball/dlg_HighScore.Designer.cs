namespace Ball
{
    partial class dlg_HighScore
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
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.B_Ok = new System.Windows.Forms.Button();
            this.B_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(78, 27);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(138, 20);
            this.TB_Name.TabIndex = 1;
            // 
            // B_Ok
            // 
            this.B_Ok.Location = new System.Drawing.Point(27, 66);
            this.B_Ok.Name = "B_Ok";
            this.B_Ok.Size = new System.Drawing.Size(75, 23);
            this.B_Ok.TabIndex = 2;
            this.B_Ok.Text = "OK";
            this.B_Ok.UseVisualStyleBackColor = true;
            this.B_Ok.Click += new System.EventHandler(this.B_Ok_Click);
            // 
            // B_Cancel
            // 
            this.B_Cancel.Location = new System.Drawing.Point(141, 66);
            this.B_Cancel.Name = "B_Cancel";
            this.B_Cancel.Size = new System.Drawing.Size(75, 23);
            this.B_Cancel.TabIndex = 3;
            this.B_Cancel.Text = "Cancel";
            this.B_Cancel.UseVisualStyleBackColor = true;
            this.B_Cancel.Click += new System.EventHandler(this.B_Cancel_Click);
            // 
            // dlg_HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 105);
            this.Controls.Add(this.B_Cancel);
            this.Controls.Add(this.B_Ok);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.label1);
            this.Name = "dlg_HighScore";
            this.Text = "High Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Button B_Ok;
        private System.Windows.Forms.Button B_Cancel;
    }
}