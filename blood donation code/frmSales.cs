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
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }

        public Boolean Add;
        Parent obj = new Parent();

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
            
        private void btnConnect_Click(object sender, EventArgs e)
        {
            //Query for the selection of required table


            string sel = "SELECT Sales.S_ID, Sales.S_BloodType, Sales.S_Price, Sales.S_Date, Sales.S_CName FROM Sales";
            string tabname = "Sales";
            obj.Select(sel, tabname);


            //Display the table in Data Grid View from DataSet
            this.dataGridView.Visible = true;
            this.dataGridView.DataSource = obj.dset;
            this.dataGridView.DataMember = "Sales";

            this.cbID.DataSource = obj.dset;
            this.cbID.DisplayMember = "Sales.S_ID";

            //Data Bindings with appropriate text boxes
            this.txtID.DataBindings.Add(new Binding("Text", obj.dset, "Sales.S_ID"));
            this.cbType.DataBindings.Add(new Binding("Text", obj.dset, "Sales.S_BloodType"));
            this.txtDate.DataBindings.Add(new Binding("Text", obj.dset, "Sales.S_Date"));
            this.txtPrice.DataBindings.Add(new Binding("Text", obj.dset, "Sales.S_Price"));
            this.txtName.DataBindings.Add(new Binding("Text", obj.dset, "Sales.S_CName"));

            this.pictureBox2.Visible = true;
            this.btnConnect.Enabled = false;
            this.groupBox5.Enabled = true;
        }

        public void clearAll()
        {
            this.txtPrice.Text = "";
            this.cbType.Text = "";
            this.txtPrice.Text = "";
            this.txtDate.Value = System.DateTime.Now;
            this.txtName.Text = "";
        }

        public void enableAll()
        {
            this.txtPrice.Enabled = true;
            this.cbID.Enabled = true;
            this.cbType.Enabled = true;
            this.txtName.Enabled = true;
        }
        public void disableAll()
        {
            this.cbID.Enabled = false;
            this.txtPrice.Enabled = false;
            this.txtDate.Enabled = false;
            this.cbType.Enabled = false;
        }

        private void frmBank_Load(object sender, EventArgs e)
        {
            this.groupBox5.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPrice.Text != "" && txtName.Text != "" && txtDate.Text != "" && cbType.Text != "")
            {
                if (Add == true)
                {
                     string type = this.cbType.Text;
                    string date = this.txtDate.Text;
                    string price = this.txtPrice.Text;
                    string name = this.txtName.Text;
                    
                    //Query for inserting the new values in table
                    string ins = "INSERT INTO Sales(S_BloodType, S_Price, S_Date, S_CName) Values ( '" + type + "' , '" + price + "' , '" + date + "' , '" + name + "')";
                    obj.Insert(ins);

                    //Confirmation Message
                    MessageBox.Show("New record has been added");

                    Add = false;
                }
                else
                {
                    //Get values from text boxes in appropriate variables
                    int ID = Convert.ToInt32(this.txtID.Text);
                    string type = this.cbType.Text;
                    string date = this.txtDate.Text;
                    int price = Convert.ToInt32(this.txtPrice.Text);
                    string name = this.txtName.Text;

                    //Query for updating the new values in table
                    
                    string upd = "UPDATE Sales SET S_BloodType = '" + type + "' , S_Price = '" + price + "' , S_Date = '" + date + "' , S_CName = '" + name + "' Where S_ID = " + ID;
                    obj.Update(upd);

                    //Confirmation Message
                    MessageBox.Show("Database has been updated");
                }

                this.dataGridView.DataSource = null;
                this.cbID.DataSource = null;
                Parent obj1 = new Parent();
                string sel = "SELECT Sales.S_ID, Sales.S_BloodType, Sales.S_Price, Sales.S_Date, Sales.S_CName FROM Sales";
                string tabname = "Sales";
                obj1.Select(sel, tabname);
                this.dataGridView.DataSource = obj1.dset;
                this.dataGridView.DataMember = "Sales";
                this.cbID.DataSource = obj1.dset;
                this.cbID.DisplayMember = "Sales.S_ID";

                clearAll();
                btnSave.Enabled = false;

            }
            else
                MessageBox.Show("You entered a blank field");
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Add = true;
            clearAll();
            enableAll();
            string sqlString = "Select Max(S_ID) as Id from Sales";
            Parent objParent = new Parent();
            objParent.Select(sqlString, "Sales");
            this.txtID.Text = (Convert.ToInt32(objParent.dset.Tables["Sales"].Rows[0][0]) + 1).ToString();

            btnSave.Enabled = true;
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            Add = false;
            enableAll();
            btnSave.Enabled = true;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (this.cbID.Text != "")
            {
                //Get values from text boxes in appropriate variables
                int ID = Convert.ToInt32(this.cbID.Text);

                //Query for deleting the existing values in table
                string del = "DELETE * FROM Sales Where S_ID = " + ID + "";
                obj.Delete(del);

                //Confirmation Message
                MessageBox.Show("Record is Deleted!");

                this.dataGridView.DataSource = null;
                this.cbID.DataSource = null;
                Parent obj1 = new Parent();
                string sel = "Select S_ID, S_BloodType, S_Price, S_Date, S_CName from Sales";
                string tabname = "Sales";
                obj1.Select(sel, tabname);
                this.dataGridView.DataSource = obj1.dset;
                this.dataGridView.DataMember = "Sales";
                this.cbID.DataSource = obj1.dset;
                this.cbID.DisplayMember = "Sales.S_ID";
            }
            else
                MessageBox.Show("Selct an ID first");
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {

            short KeyAscii = (short)e.KeyChar;
            if (!((KeyAscii >= 48 && KeyAscii <= 57) || (KeyAscii == 8)))
                e.KeyChar = (Char)0;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            short KeyAscii = (short)e.KeyChar;
            if (KeyAscii >= 48 && KeyAscii <= 57)
                e.KeyChar = (Char)0;
        }



    }
}
