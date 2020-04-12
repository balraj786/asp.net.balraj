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
    public partial class frmDonor : Form
    {
        public Boolean Add;
        public frmDonor()
        {
            InitializeComponent();
        }

        Parent obj = new Parent();

        private void Donor_Load(object sender, EventArgs e)
        {
            this.groupBox5.Enabled = false;
        }

       private void btnedit_Click(object sender, EventArgs e)
        {
            Add = false;
            EnableAll();
            btnSave.Enabled = true;
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            if(this.txtName.Text != "" && this.txtAge.Text != "" && this.txtGender.Text != "" && this.txtBGroup.Text != "" && this.txtCon.Text != "" && this.txtAdd.Text != "")
            {
            if (Add == true)
            {
                string name = this.txtName.Text;
                int age = Convert.ToInt32(this.txtAge.Text);
                string gender = this.txtGender.Text;
                string bgroup = this.txtBGroup.Text;
                int no = Convert.ToInt32(this.txtCon.Text);
                string add = this.txtAdd.Text;

                //Query for inserting the new values in table
                string ins = "INSERT INTO Donors(D_Name, D_age, D_Gender, D_BloodGroup, D_Contact, D_Address) Values (  '" + name + "' , " + age + " , '" + gender + "' , '" + bgroup + "' , " + no + " , '" + add + "')";
                obj.Insert(ins);

                //Confirmation Message
                MessageBox.Show("Record has been added");

                Add = false;
            }
            else
            {
                //Get values from text boxes in appropriate variables
                int ID = Convert.ToInt32(this.txtID.Text);
                string name = this.txtName.Text;
                int age = Convert.ToInt32(this.txtAge.Text);
                string gender = this.txtGender.Text;
                string bgroup = this.txtBGroup.Text;
                int no = Convert.ToInt32(this.txtCon.Text);
                string add = this.txtAdd.Text;
                
                //Query for updating the new values in table
                string upd = "UPDATE Donors SET D_Name = '" + name + "' , D_Age = " + age + " , D_Gender = '" + gender + "', D_BloodGroup = '" + bgroup + "' , D_Contact = " + no + " , D_Address = '" + add + "' Where D_ID = " + ID;
                obj.Update(upd);
                

                //Confirmation Message
                MessageBox.Show("Record has been updated");
            }

            obj.dset.Clear();
            this.dataGridView.DataSource = null;
            this.cbID.DataSource = null;
            Parent obj1 = new Parent();
            string sel = "select D_ID as ID, D_Name as Name, D_age as Age, D_Gender as Gender, D_BloodGroup as Blood,D_Contact as Contact,D_Address as Address from Donors order by D_ID";
            string tabname = "Donors";
            obj1.Select(sel, tabname);
            this.dataGridView.DataSource = obj1.dset;
            this.dataGridView.DataMember = "Donors";
            this.cbID.DataSource = obj1.dset;
            this.cbID.DisplayMember = "Donors.ID";

            btnSave.Enabled = false ;
            
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
            this.txtGender.Text = "";
            this.txtBGroup.Text = "";
            this.txtCon.Text = "";
            this.txtAdd.Text = "";
        }
        public void EnableAll()
        {
            this.txtName.Enabled = true;
            this.cbID.Enabled = true;
            this.txtAge.Enabled = true;
            this.txtGender.Enabled = true;
            this.txtBGroup.Enabled = true;
            this.txtCon.Enabled = true;
            this.txtAdd.Enabled = true;           
        }
        public void DisableAll()
        {
            this.txtName.Enabled = false;
            this.txtAge.Enabled = false ;
            this.cbID.Enabled = false;
            this.txtGender.Enabled = false ;
            this.txtBGroup.Enabled = false ;
            this.txtCon.Enabled = false ;
            this.txtAdd.Enabled = false ;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add = true;
            btnSave.Enabled = true;
            ClearAll();
            EnableAll();
            string sqlString = "select Max(D_ID) as Id from Donors";
            
            Parent objParent = new Parent();
            objParent.Select(sqlString, "Donors");
            this.txtID.Text = (Convert.ToInt32(objParent.dset.Tables["Donors"].Rows[0][0]) + 1).ToString();
            this.cbID.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //Query for the selection of required table
            string sel = "select D_ID as ID, D_Name as Name, D_age as Age, D_Gender as Gender, D_BloodGroup as Blood,D_Contact as Contact,D_Address as Address from Donors order by D_ID";
            string tabname = "Donors";
            obj.Select(sel, tabname);


            //Display the table in Data Grid View from DataSet
            this.dataGridView.Visible = true;
            this.dataGridView.DataSource = obj.dset;
            this.dataGridView.DataMember = "Donors";

            this.cbID.DataSource = obj.dset;
            this.cbID.DisplayMember = "Donors.ID";

            //Data Bindings with appropriate text boxes
            this.txtID.DataBindings.Add(new Binding("Text", obj.dset, "Donors.ID"));
            this.txtName.DataBindings.Add(new Binding("Text", obj.dset, "Donors.Name"));
            this.txtAge.DataBindings.Add(new Binding("Text", obj.dset, "Donors.Age"));
            this.txtGender.DataBindings.Add(new Binding("Text", obj.dset, "Donors.Gender"));
            this.txtBGroup.DataBindings.Add(new Binding("Text", obj.dset, "Donors.Blood"));
            this.txtCon.DataBindings.Add(new Binding("Text", obj.dset, "Donors.Contact"));
            this.txtAdd.DataBindings.Add(new Binding("Text", obj.dset, "Donors.Address"));

            this.pictureBox2.Visible = true;
            this.btnConnect.Enabled = false;
            this.groupBox5.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if(this.cbID.Text !="")
            {
            //Get values from text boxes in appropriate variables
            int ID = Convert.ToInt32(this.cbID.Text);
            
            //Query for deleting the existing values in table
            string del = "DELETE * FROM DONORS Where D_ID = " + ID + "";
            obj.Delete(del);

            //Confirmation Message
            MessageBox.Show("Record is Deleted !");

            ClearAll();

            dataGridView.DataSource = null;
            this.cbID.DataSource = null;
            Parent obj1 = new Parent();
            string sel = "select D_ID as ID, D_Name as Name, D_age as Age, D_Gender as Gender, D_BloodGroup as Blood,D_Contact as Contact,D_Address as Address from Donors order by D_ID";
            string tabname = "Donors";
            obj1.Select(sel, tabname);
            this.dataGridView.DataSource = obj1.dset;
            this.dataGridView.DataMember = "Donors";
            this.cbID.DataSource = obj1.dset;
            this.cbID.DisplayMember = "Donors.ID";

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
