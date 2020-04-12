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
    public partial class frmPatients : Form
    {
        public frmPatients()
        {
            InitializeComponent();
        }

        Parent obj = new Parent();
        public Boolean Add;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(this.txtID.Text != "" && this.txtName.Text != "" && this.txtBGroup.Text != "" && this.txtGen.Text != "" && this.txtAge.Text != "" && this.txtCon.Text != "" && this.txtAdd.Text != "")
            {
                if (Add == true)
            {
                //Get values from text boxes in appropriate variables
                string name = this.txtName.Text;
                int age = Convert.ToInt32(this.txtAge.Text);
                string gender = this.txtGen.Text;
                int no = Convert.ToInt32(this.txtCon.Text);
                string add = this.txtAdd.Text;
                string bgroup = this.txtBGroup.Text;

                //Query for inserting the new values in table
                string ins = "INSERT INTO Patients(P_Name, P_Age, P_Gender, P_Contact, P_Address, P_BloodGroup) Values ('" + name + "' , " + age + " , '" + gender + "' , " + no + " , '" + add + "' , '" + bgroup + "')";
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
                int no = Convert.ToInt32(this.txtCon.Text);
                string add = this.txtAdd.Text;
                string bgroup = this.txtBGroup.Text;

                //Query for updating the new values in table
                string upd = "UPDATE Patients SET  P_Name = '" + name + "' , P_Age = " + age + " , P_Gender = '" + gender + "' , P_Contact = " + no + " , P_Address = '" + add + "' , P_BloodGroup = '" + bgroup + "' Where P_ID = " + ID;
                obj.Update(upd);

                //Confirmation Message
                MessageBox.Show("Database has been updated");
            }
                dataGridView.DataSource = null;
                this.cbID.DataSource = null;
                Parent obj1 = new Parent();
                string sel = "select P_ID as ID, P_Name as Name, P_Age as Age, P_Gender as Gender, P_Contact as Contact, P_Address as Address, P_BloodGroup as Blood from Patients order by P_ID";
                string tabname = "Patients";
                obj1.Select(sel, tabname);
                this.dataGridView.DataSource = obj1.dset;
                this.dataGridView.DataMember = "Patients";
                this.cbID.DataSource = obj1.dset;
                this.cbID.DisplayMember = "Patients.ID";

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
            this.txtBGroup.Text = "";
            this.txtGen.Text = "";
            this.txtAge.Text = "";
            this.txtCon.Text = "";
            this.txtAdd.Text = "";
        }

        public void EnableAll()
        {
            this.cbID.Enabled = true;
            this.txtName.Enabled = true;
            this.txtBGroup.Enabled = true;
            this.txtGen.Enabled = true;
            this.txtAge.Enabled = true;
            this.txtCon.Enabled = true;
            this.txtAdd.Enabled = true;
        }

        public void DisableAll()
        {
            this.txtID.Enabled = false;
            this.cbID.Enabled = false;            
            this.txtName.Enabled = false;
            this.txtBGroup.Enabled = false;
            this.txtGen.Enabled = false;
            this.txtAge.Enabled = false;
            this.txtCon.Enabled = false;
            this.txtAdd.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //Query for the selection of required table
            string sel = "select P_ID as ID, P_Name as Name, P_Age as Age, P_Gender as Gender, P_Contact as Contact, P_Address as Address, P_BloodGroup as Blood from Patients order by P_ID";
            string tabname = "Patients";
            obj.Select(sel, tabname);


            //Display the table in Data Grid View from DataSet
            this.dataGridView.Visible = true;
            this.dataGridView.DataSource = obj.dset;
            this.dataGridView.DataMember = "Patients";

            this.cbID.DataSource = obj.dset;
            this.cbID.DisplayMember = "Patients.ID";

            //Data Bindings with appropriate text boxes
            this.txtID.DataBindings.Add(new Binding("Text", obj.dset, "Patients.ID"));
            this.txtName.DataBindings.Add(new Binding("Text", obj.dset, "Patients.Name"));
            this.txtBGroup.DataBindings.Add(new Binding("Text", obj.dset, "Patients.Blood"));
            this.txtGen.DataBindings.Add(new Binding("Text", obj.dset, "Patients.Gender"));
            this.txtAge.DataBindings.Add(new Binding("Text", obj.dset, "Patients.Age"));
            this.txtCon.DataBindings.Add(new Binding("Text", obj.dset, "Patients.Contact"));
            this.txtAdd.DataBindings.Add(new Binding("Text", obj.dset, "Patients.Address"));
           
            this.pictureBox2.Visible = true;
            this.groupBox5.Enabled = true;
            this.btnConnect.Enabled = false;
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            this.groupBox5.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add = true;
            btnSave.Enabled = true;
            ClearAll();
            EnableAll();
            string sqlString = "select Max(P_ID) as ID from Patients";
            Parent objParent = new Parent();
            objParent.Select(sqlString, "Patients");
            this.txtID.Text = (Convert.ToInt32(objParent.dset.Tables["Patients"].Rows[0][0]) + 1).ToString();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            Add = false;
            EnableAll();
            btnSave.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             if(this.cbID.Text != "")
            {
            //Get values from text boxes in appropriate variables
            int ID = Convert.ToInt32(this.cbID.Text);

            //Query for deleting the existing values in table
            string del = "DELETE * FROM Patients Where P_ID = " + ID + "";
            obj.Delete(del);

            //Confirmation Message
            MessageBox.Show("Record is Deleted!");

            ClearAll();

            this.dataGridView.DataSource = null;
            this.cbID.DataSource = null;
            Parent obj1 = new Parent();
            string sel = "select P_ID as ID, P_Name as Name, P_Age as Age, P_Gender as Gender, P_Contact as Contact, P_Address as Address, P_BloodGroup as Blood from Patients order by P_ID";
            string tabname = "Patients";
            obj1.Select(sel, tabname);
            this.dataGridView.DataSource = obj1.dset;
            this.dataGridView.DataMember = "Patients";
            this.cbID.DataSource = obj1.dset;
            this.cbID.DisplayMember = "Patients.ID";

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
