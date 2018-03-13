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
    public partial class dlg_SelectLvl : Form
    {
        public dlg_SelectLvl()
        {
            InitializeComponent();
        }

        public string lvlSelection() {
            string lvl = "";

            if (RB_Easy.Checked)
                lvl = "Easy";
            else if (RB_Medium.Checked)
                lvl = "Medium";
            else
                lvl = "Hard";

            return lvl;
        }

        private void B_Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
