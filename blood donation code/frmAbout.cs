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
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            Parent obj = new Parent();
            string sel = "Select User from Login";
            string tabname = "Login";
            obj.Select(sel, tabname);
            //this.label2.DataBindings.Add(new Binding("Text", obj.dset, "Login.User"));
            //this.label3.DataBindings.Add(new Binding("Text", obj.dset, "Login.User"));
            //this.label4.DataBindings.Add(new Binding("Text", obj.dset, "Login.User"));
            //this.label5.DataBindings.Add(new Binding("Text", obj.dset, "Login.User"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
