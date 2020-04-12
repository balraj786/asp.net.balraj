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
    public partial class frmBank : Form
    {
        
        public frmBank()
        {
            InitializeComponent();
        }

        public Boolean Add;
        Parent obj = new Parent();

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (txtCost.Text != "" && cbStat.Text != "" && cbType.Text != "")
            {
            if (Add == true)
            {
                int ID = Convert.ToInt32(this.txtID.Text);
                string type = this.cbType.Text;
                string date = this.txtDate.Text;
                string expiry = this.txtExp.Text;
                string status = this.cbStat.Text;
                int cost = Convert.ToInt32(this.txtCost.Text);

                //Query for inserting the new values in table
                string ins = "INSERT INTO Inventory(B_Type, B_DonationDate, B_ExpiryDate, B_Status, B_Cost) Values ( '" + type + "' , '" + date + "' , '" + expiry + "' , '" + status + "' , " + cost + ")";
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
                string expiry = this.txtExp.Text;
                string status = this.cbStat.Text;
                int cost = Convert.ToInt32(this.txtCost.Text);

                //Query for updating the new values in table
                string upd = "UPDATE Inventory SET B_Type = '" + type + "' , B_DonationDate = '" + date + "' , B_ExpiryDate = '" + expiry + "' , B_Status = '" + status + "' , B_Cost = " + cost + "  Where B_ID = " + ID;
                obj.Update(upd);

                //Confirmation Message
                MessageBox.Show("Database has been updated");
            }

            this.dataGridView.DataSource = null;
            this.cbID.DataSource = null;
            Parent obj1 = new Parent();
            string sel = "select B_ID as ID, B_Type as Type, B_DonationDate as Donated, B_ExpiryDate as Expires, B_Status as Status, B_Cost as Cost from Inventory order by B_id";
            string tabname = "Inventory";
            obj1.Select(sel, tabname);
            this.dataGridView.DataSource = obj1.dset;
            this.dataGridView.DataMember = "Inventory";
            this.cbID.DataSource = obj1.dset;
            this.cbID.DisplayMember = "Inventory.ID";

            clearAll();
            btnSave.Enabled = false;

            }
            else
                MessageBox.Show("You entered a blank field");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //Query for the selection of required table
            string sel = "select B_ID as ID, B_Type as Type, B_DonationDate as Donated, B_ExpiryDate as Expires, B_Status as Status, B_Cost as Cost from Inventory order by B_ID";
            string tabname = "Inventory";
            obj.Select(sel, tabname);


            //Display the table in Data Grid View from DataSet
            this.dataGridView.Visible = true;
            this.dataGridView.DataSource = obj.dset;
            this.dataGridView.DataMember = "Inventory";

            this.cbID.DataSource = obj.dset;
            this.cbID.DisplayMember = "Inventory.ID";

            //Data Bindings with appropriate text boxes
            this.txtID.DataBindings.Add(new Binding("Text", obj.dset ,"Inventory.ID"));
            this.cbType.DataBindings.Add(new Binding("Text", obj.dset, "Inventory.Type"));
            this.txtDate.DataBindings.Add(new Binding("Text", obj.dset, "Inventory.Donated"));
            this.txtExp.DataBindings.Add(new Binding("Text", obj.dset, "Inventory.Expires"));
            this.cbStat.DataBindings.Add(new Binding("Text", obj.dset, "Inventory.Status"));
            this.txtCost.DataBindings.Add(new Binding("Text", obj.dset, "Inventory.Cost"));

            this.pictureBox2.Visible = true;
            this.btnConnect.Enabled = false;
            this.groupBox5.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Add = false;
            enableAll();
            btnSave.Enabled = true;
        }

          
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add = true;
            clearAll();
            enableAll();
            string sqlString = "select Max(B_id) as Id from Inventory";
            Parent objParent =new Parent();
            objParent.Select(sqlString, "Inventory");
            this.txtID.Text = (Convert.ToInt32(objParent.dset.Tables["Inventory"].Rows[0][0]) + 1).ToString();
            
            btnSave.Enabled = true;
        }

        public void clearAll()
        {
            this.txtCost.Text = "";
            this.txtExp.Value = System.DateTime.Today.AddDays(21);
            this.cbStat.Text = "";
            this.cbType.Text = "";
            this.txtDate.Value = System.DateTime.Now;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.cbID.Text != "")
            {
                //Get values from text boxes in appropriate variables
                int ID = Convert.ToInt32(this.cbID.Text);

                //Query for deleting the existing values in table
                string del = "DELETE * FROM Inventory Where B_ID = " + ID + "";
                obj.Delete(del);

                //Confirmation Message
                MessageBox.Show("Record is Deleted!");

                this.dataGridView.DataSource = null;
                this.cbID.DataSource = null;
                Parent obj1 = new Parent();
                string sel = "select B_ID as ID, B_Type as Type, B_DonationDate as Donated, B_ExpiryDate as Expires, B_Status as Status, B_Cost as Cost from Inventory order by B_id";
                string tabname = "Inventory";
                obj1.Select(sel, tabname);
                this.dataGridView.DataSource = obj1.dset;
                this.dataGridView.DataMember = "Inventory";
                this.cbID.DataSource = obj1.dset;
                this.cbID.DisplayMember = "Inventory.ID";
            }
            else
                MessageBox.Show("Selct an ID first");

        }
        public void enableAll()
        {
            this.txtCost.Enabled = true;
            this.cbID.Enabled = true;
            this.cbStat.Enabled = true;
            this.cbType.Enabled = true;
        }
        public void disableAll()
        {
            this.cbID.Enabled = false;
            this.txtCost.Enabled = false;
            this.txtDate.Enabled = false;
            this.txtExp.Enabled = false;
            this.cbStat.Enabled = false;
            this.cbType.Enabled = false;
        }

        private void txtCost_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            
            short KeyAscii = (short)e.KeyChar;
            if (!((KeyAscii >= 48 && KeyAscii <= 57) ||( KeyAscii ==8)))
                e.KeyChar = (Char)0;       
        }

        private void frmBank_Load(object sender, EventArgs e)
        {
            this.groupBox5.Enabled = false;
        }

   }
}
