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
    public partial class dlg_HighScore : Form
    {
        public dlg_HighScore()
        {
            InitializeComponent();
            TB_Name.Text = "Enter your name";
        }

        public void getDefault(string line) {
            TB_Name.Clear();
            TB_Name.Text = line;
        }

        private void B_Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Text = TB_Name.Text;
        }

        private void B_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
