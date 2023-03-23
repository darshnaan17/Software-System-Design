using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class formStart : Form
    {
        public formStart()
        {
            InitializeComponent();
        }

        private void btnOneDice_Click(object sender, EventArgs e)
        {
            formOneDice oneDice = new formOneDice();
            oneDice.Show();
            this.Hide();            
        }

        private void btnTwoDice_Click(object sender, EventArgs e)
        {
            formTwoDice twoDice = new formTwoDice();
            twoDice.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
