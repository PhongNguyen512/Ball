using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ball
{
    public partial class dlg_Score : Form
    {
        public delegate void delvoidbool(bool a);

        public delvoidbool buttonOff = null;

        public dlg_Score()
        {
            InitializeComponent();
        }
     
        public void getValue(int value) {
            L_TotalScore.Text = value.ToString("0000");
        }

        private void dlg_Score_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;             
                Hide();
                buttonOff(true);
            }
           
        }

    }
}
