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
    public partial class frmMembers : Form
    {
        public frmMembers()
        {
            InitializeComponent();
        }

        Parent obj = new Parent();
        public Boolean Add;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(this.txtID.Text != "" && this.txtName.Text != "" && this.txtAge.Text != "" && this.txtGen.Text != "" && this.txtBGroup.Text != "" && this.txtCon.Text != "" && this.txtAdd.Text != "" && this.txtDate.Text != "")
            {
            if (Add == true)
            {
                //Get values from text boxes in appropriate variables
                int ID = Convert.ToInt32(this.txtID.Text);
                string name = this.txtName.Text;
                int age = Convert.ToInt32(this.txtAge.Text);
                string gender = this.txtGen.Text;
                string add = this.txtAdd.Text;
                int no = Convert.ToInt32(this.txtCon.Text);
                string bgroup = this.txtBGroup.Text;
                string date = this.txtDate.Text;

                //Query for inserting the new values in table
                string ins = "INSERT INTO Members(M_Name, M_Age, M_Gender, M_Address, M_Contact, M_BloodGroup, M_DonationDate) Values ('" + name + "' , " + age + " , '" + gender + "' , '" + add + "' , " + no + " , '" + bgroup + "' , '" + date + "')";
                obj.Insert(ins);

                //Confirmation Message
                MessageBox.Show("New record has been added");



                Add = false;
            }
            else
            {
                //Get values from text boxes in appropriate variables
                int ID = Convert.ToInt32(this.txtID.Text);
                string name = this.txtName.Text;
                int age = Convert.ToInt32(this.txtAge.Text);
                string gender = this.txtGen.Text;
                string add = this.txtAdd.Text;
                int no = Convert.ToInt32(this.txtCon.Text);
                string bgroup = this.txtBGroup.Text;
                string date = this.txtDate.Text;

                //Query for updating the new values in table
                string upd = "UPDATE Members SET M_Name = '" + name + "' , M_Age = " + age + " , M_Gender = '" + gender + "' , M_Address = '" + add + "' , M_Contact = " + no + " , M_BloodGroup = '" + bgroup + "' , M_DonationDate = '" + date + "' Where M_ID = " + ID;
                obj.Update(upd);

                //Confirmation Message
                MessageBox.Show("Database has been updated");
            }

            this.dataGridView.DataSource = null;
            this.cbID.DataSource = null;
            Parent obj1 = new Parent();
            string sel = "SELECT M_ID as ID, M_Name as Name, M_Age as Age, M_Gender as Gender, M_Address as Address, M_Contact as Contact, M_BloodGroup as Blood, M_DonationDate as Donated from Members order by M_ID";
            string tabname = "Members";
            obj1.Select(sel, tabname);
            this.dataGridView.DataSource = obj1.dset;
            this.dataGridView.DataMember = "Members";
            this.cbID.DataSource = obj1.dset;
            this.cbID.DisplayMember = "Members.ID";

            btnSave.Enabled = false;
            ClearAll();
            }
            else
                MessageBox.Show("You entered a blank field");
        }

        public void ClearAll()
        {
            this.txtID.Text = "";
            this.txtName.Text = "";
            this.txtAge.Text = "";
            this.txtGen.Text = "";
            this.txtBGroup.Text = "";
            this.txtCon.Text = "";
            this.txtAdd.Text = "";
            this.txtDate.Text = "";
        }

        public void EnableAll()
        {
            this.cbID.Enabled = true;
            this.txtName.Enabled = true;
            this.txtAge.Enabled = true;
            this.txtGen.Enabled = true;
            this.txtBGroup.Enabled = true;
            this.txtCon.Enabled = true;
            this.txtAdd.Enabled = true;
            this.txtDate.Enabled = true;
        }

        public void DisableAll()
        {
            this.cbID.Enabled = false;            
            this.txtName.Enabled = false;
            this.txtAge.Enabled = false;
            this.txtGen.Enabled = false;
            this.txtBGroup.Enabled = false;
            this.txtCon.Enabled = false;
            this.txtAdd.Enabled = false;
            this.txtDate.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //Query for the selection of required table
            string sel = "SELECT M_ID as ID, M_Name as Name, M_Age as Age, M_Gender as Gender, M_Address as Address, M_Contact as Contact, M_BloodGroup as Blood, M_DonationDate as Donated from Members";
            string tabname = "Members";
            obj.Select(sel, tabname);


            //Display the table in Data Grid View from DataSet
            this.dataGridView.Visible = true;
            this.dataGridView.DataSource = obj.dset;
            this.dataGridView.DataMember = "Members";

            this.cbID.DataSource = obj.dset;
            this.cbID.DisplayMember = "Members.ID";

            //Data Bindings with appropriate text boxes
            this.txtID.DataBindings.Add(new Binding("Text", obj.dset, "Members.ID"));
            this.txtName.DataBindings.Add(new Binding("Text", obj.dset, "Members.Name"));
            this.txtAge.DataBindings.Add(new Binding("Text", obj.dset, "Members.Age"));
            this.txtGen.DataBindings.Add(new Binding("Text", obj.dset, "Members.Gender"));
            this.txtBGroup.DataBindings.Add(new Binding("Text", obj.dset, "Members.Blood"));
            this.txtCon.DataBindings.Add(new Binding("Text", obj.dset, "Members.Contact"));
            this.txtAdd.DataBindings.Add(new Binding("Text", obj.dset, "Members.Address"));
            this.txtDate.DataBindings.Add(new Binding("Text", obj.dset, "Members.Donated"));

            this.btnConnect.Enabled = false;
            this.pictureBox2.Visible = true;
            this.groupBox5.Enabled = true;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            Add = false;
            EnableAll();
            btnSave.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add = true;
            btnSave.Enabled = true;
            ClearAll();
            EnableAll();
            string sqlString = "select Max(M_ID) as ID from Members";
            Parent objParent = new Parent();
            objParent.Select(sqlString, "Members");
            this.txtID.Text = (Convert.ToInt32(objParent.dset.Tables["Members"].Rows[0][0]) + 1).ToString();
        }

        private void Members_Load(object sender, EventArgs e)
        {
            this.groupBox5.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(this.txtID.Text != "" && this.txtName.Text != "" && this.txtAge.Text != "" && this.txtGen.Text != "" && this.txtBGroup.Text != "" && this.txtCon.Text != "" && this.txtAdd.Text != "" && this.txtDate.Text != "")
            {
            //Get values from text boxes in appropriate variables
            int ID = Convert.ToInt32(this.cbID.Text);

            //Query for deleting the existing values in table
            string del = "DELETE * FROM Members Where M_ID = " + ID + "";
            obj.Delete(del);

            //Confirmation Message
            MessageBox.Show("Record is Deleted!");

            ClearAll();

            this.dataGridView.DataSource = null;
            this.cbID.DataSource = null;
            Parent obj1 = new Parent();
            string sel = "SELECT M_ID as ID, M_Name as Name, M_Age as Age, M_Gender as Gender, M_Address as Address, M_Contact as Contact, M_BloodGroup as Blood, M_DonationDate as Donated from Members order by M_ID";
            string tabname = "Members";
            obj1.Select(sel, tabname);
            this.dataGridView.DataSource = obj1.dset;
            this.dataGridView.DataMember = "Members";
            this.cbID.DataSource = obj1.dset;
            this.cbID.DisplayMember = "Members.ID";
            }
            else
                MessageBox.Show("Select an ID first");
        }
        private void txtName_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            short KeyAscii = (short)e.KeyChar;
            if (KeyAscii >= 48 && KeyAscii <= 57) 
                e.KeyChar = (Char)0;
        }
        private void txtAge_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            short KeyAscii = (short)e.KeyChar;
            if (!((KeyAscii >= 48 && KeyAscii <= 57) || (KeyAscii == 8)))
                e.KeyChar = (Char)0;
        }

        private void txtCon_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            short KeyAscii = (short)e.KeyChar;
            if (!((KeyAscii >= 48 && KeyAscii <= 57) || (KeyAscii == 8)))
                e.KeyChar = (Char)0;
        }
    }
}
