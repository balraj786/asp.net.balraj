using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class frmSplash : Form
    {
            int i;

            //public static frmLogin objLogin;
            frmLogin objLogin = new frmLogin();
        public frmSplash()
        {
            InitializeComponent();
            pBar.Minimum = 0;
            pBar.Maximum = 40;
            pBar.Value = 0;
            i = 1;
            timer1.Start();
    }
       
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (i <= pBar.Maximum)
            {
                pBar.Value = i;
                i++;
                if (lblLoad.Text.Length < 20)
                    lblLoad.Text = lblLoad.Text + ". ";
                else
                    lblLoad.Text = "Loading";
            }
            else
            {
                timer1.Stop();
                this.Hide();
                objLogin.Show();
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }
    }
}
