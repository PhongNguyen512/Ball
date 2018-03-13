namespace Ball
{
    partial class dlg_Speed
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
            this.Trackbar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Trackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // Trackbar
            // 
            this.Trackbar.Location = new System.Drawing.Point(12, 12);
            this.Trackbar.Maximum = 200;
            this.Trackbar.Minimum = 10;
            this.Trackbar.Name = "Trackbar";
            this.Trackbar.Size = new System.Drawing.Size(329, 45);
            this.Trackbar.TabIndex = 0;
            this.Trackbar.TickFrequency = 10;
            this.Trackbar.Value = 10;
            this.Trackbar.Scroll += new System.EventHandler(this.Trackbar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "10ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "200ms";
            // 
            // dlg_Speed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 60);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Trackbar);
            this.Name = "dlg_Speed";
            this.Text = "Animation Speed";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.dlg_Speed_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Trackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar Trackbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}