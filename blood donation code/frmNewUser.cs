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
    public partial class frmNewUser : Form
    {
        public frmNewUser()
        {
            InitializeComponent();
        }

        Parent obj = new Parent();

        private void btnReg_Click(object sender, EventArgs e)
        {
            if(this.txtUser.Text != "" && this.txtPass.Text != "")
            {
            string user = this.txtUser.Text.ToLower();
            string pass = this.txtPass.Text.ToLower(); 
            
            string result = obj.cnfrm_username_password(user, pass);
            if (result == "notmatch")
            {
                string ins = "INSERT INTO Login Values ('" + user + "', '" + pass + "')";
                obj.Insert(ins);
                MessageBox.Show("Successfully Signed Up" + "\n" + "Press OK to continue", "Sign Up");
                this.Hide();
                frmLogin objLogin = new frmLogin();
                objLogin.Show();
                bank.password = "";
                bank.username = "";
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username is already taken" + "\n" + "Again enter Username and Password");
                txtPass.Text = "";
                txtUser.Text = "";
                txtUser.Focus();
            }
            }
            else
                MessageBox.Show("Enter both fields");
        }

        private void frmNewUser_Load(object sender, EventArgs e)
        {
            string sel = "SELECT * From Login";
            string tabname = "Login";
            obj.Select(sel, tabname);
        }

    }
}
