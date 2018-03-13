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
    public partial class dlg_Speed : Form
    {
        public delegate void delvoidint(int a);
        public delvoidint valueChanged = null;
        public delegate void delvoidbool(bool b);
        public delvoidbool SpeedbuttonOff = null;

        public dlg_Speed()
        {
            InitializeComponent();
        }

        private void Trackbar_Scroll(object sender, EventArgs e)
        {
            if (valueChanged == null)
                return;

            valueChanged(Trackbar.Value);
        }

        private void dlg_Speed_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
                SpeedbuttonOff(true);
            }
        }
    }
}
