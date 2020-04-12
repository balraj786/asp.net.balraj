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
    public partial class frmPass : Form
    {
        public frmPass()
        {
            InitializeComponent();
        }

        Parent obj = new Parent();

        private void btnChange_Click(object sender, EventArgs e)
        {
           if (this.txtUser.Text != "" && this.txtPass.Text != "")
            {
            string user = this.txtUser.Text.ToLower();
            string pass = this.txtPass.Text.ToLower(); 
            string result = obj.cnfrm_username_password(user, pass);
            if (result == "match")
            {
                string upd = "UPDATE Login SET Login.[Password] = '"+ pass +"' WHERE (Login.User)='"+ user +"'";
                obj.Update(upd);
                MessageBox.Show("Password changed Successfully" + "\n" + "Press OK to continue", "New Password");
                this.Hide();
                frmLogin objLogin = new frmLogin();
                objLogin.Show();
                bank.username = "";
                bank.password = "";
            }
            else
            {
                MessageBox.Show("Username not found" + "\n" + "Again enter Username and Password");
                txtPass.Text = "";
        
                txtUser.Focus();
            }
            }
            else
                MessageBox.Show("Enter Username and Password First");
        }

        private void frmPass_Load(object sender, EventArgs e)
        {
            string sel = "Select * From Login";
            string tabname = "Login";
            obj.Select(sel, tabname);
            this.txtUser.Text = bank.username.ToString();
            this.txtUser.Enabled = false;
        }
    }
}
