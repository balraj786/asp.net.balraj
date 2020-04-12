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
    public partial class frmLogin : Form
    {
        public static MDIMain objMDIMain;
        public frmLogin()
        {
            InitializeComponent();
            objMDIMain = new MDIMain();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(this.txtUser.Text != "" && this.txtPass.Text != "")
            {
               
                LoggedIn();    
            }
            else
                MessageBox.Show("Enter User and Password");
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        private void txtPass_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            short KeyAscii = (short)e.KeyChar;
            if (KeyAscii == 13)
                LoggedIn();
        }
        private void LoggedIn()
        {
            Parent obj = new Parent();
            string cnfm = "SELECT * FROM Login";
            string tabname = "Login";
            obj.Select(cnfm, tabname);
            string result = obj.cnfrm_username_password( this.txtUser.Text.ToLower(), this.txtPass.Text.ToLower());
            if (result == "match")
            {

                MessageBox.Show("Successfully Logged In" + "\n" + "Press OK to continue", "Login");
                this.Hide();
                objMDIMain.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password" + "\n" + "Again enter username and password");
                txtPass.Text = "";
                txtUser.Text = "";
                txtUser.Focus();
            }
        }
    }
}
