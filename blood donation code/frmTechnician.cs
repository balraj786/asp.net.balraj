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
    public partial class frmTechnician : Form
    {
        public frmTechnician()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Parent obj = new Parent();
        public Boolean Add;

        public void ClearAll()
        {
            this.txtName.Text = "";
            this.txtGen.Text = "";
            this.txtAge.Text = "";
            this.txtCon.Text = "";
            this.txtAdd.Text = "";
            this.txtExp.Text = "";
        }

        public void EnableAll()
        {
            this.txtName.Enabled = true;
            this.txtGen.Enabled = true;
            this.txtAge.Enabled = true;
            this.txtCon.Enabled = true;
            this.txtAdd.Enabled = true;
            this.txtExp.Enabled = true;
        }

        public void DisableAll()
        {
            this.txtID.Enabled = false;
            this.cbID.Enabled = false;            
            this.txtName.Enabled = false;
            this.txtGen.Enabled = false;
            this.txtAge.Enabled = false;
            this.txtCon.Enabled = false;
            this.txtAdd.Enabled = false;
            this.txtExp.Enabled = false;
        }
        
        private void btnConnect_Click(object sender, EventArgs e)
        {
            //Query for the selection of required table
            string sel = "select T_ID as ID, T_Name as Name, T_Age as Age, T_Gender as Gender, T_Contact as Contact, T_Address as Address, T_Experience as Experience from Technicians order by T_ID";
            string tabname = "Technicians";
            obj.Select(sel, tabname);


            //Display the table in Data Grid View from DataSet
            this.dataGridView.Visible = true;
            this.dataGridView.DataSource = obj.dset;
            this.dataGridView.DataMember = "Technicians";

            this.cbID.DataSource = obj.dset;
            this.cbID.DisplayMember = "Technicians.ID";

            //Data Bindings with appropriate text boxes
            this.txtID.DataBindings.Add(new Binding("Text", obj.dset, "Technicians.ID"));
            this.txtName.DataBindings.Add(new Binding("Text", obj.dset, "Technicians.Name"));
            this.txtAge.DataBindings.Add(new Binding("Text", obj.dset, "Technicians.Age"));
            this.txtGen.DataBindings.Add(new Binding("Text", obj.dset, "Technicians.Gender"));
            this.txtCon.DataBindings.Add(new Binding("Text", obj.dset, "Technicians.Contact"));
            this.txtAdd.DataBindings.Add(new Binding("Text", obj.dset, "Technicians.Address"));
            this.txtExp.DataBindings.Add(new Binding("Text", obj.dset, "Technicians.Experience"));
            
            this.pictureBox2.Visible = true;
            this.btnConnect.Enabled = false;
            this.groupBox5.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add = true;
            btnSave.Enabled = true;
            ClearAll();
            EnableAll();
            string sqlString = "select Max(T_ID) as ID from Technicians";
            Parent objParent = new Parent();
            objParent.Select(sqlString, "Technicians");
            this.txtID.Text = (Convert.ToInt32(objParent.dset.Tables["Technicians"].Rows[0][0]) + 1).ToString();
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
            string del = "DELETE * FROM Technicians Where T_ID = " + ID + "";
            obj.Delete(del);

            //Confirmation Message
            MessageBox.Show("Record is Deleted!");

            ClearAll();

            this.dataGridView.DataSource = null;
            this.cbID.DataSource = null;
            Parent obj1 = new Parent();
            string sel = "select T_ID as ID, T_Name as Name, T_Age as Age, T_Gender as Gender, T_Contact as Contact, T_Address as Address, T_Experience as Experience from Technicians order by T_ID";
            string tabname = "Technicians";
            obj1.Select(sel, tabname);
            this.dataGridView.DataSource = obj1.dset;
            this.dataGridView.DataMember = "Technicians";
            this.cbID.DataSource = obj1.dset;
            this.cbID.DisplayMember = "Technicians.ID";

            }
             else
                 MessageBox.Show("Select an ID first");
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if(this.txtID.Text != "" && this.txtName.Text != "" && this.txtGen.Text != "" && this.txtAge.Text != "" && this.txtCon.Text != "" && this.txtAdd.Text != "" && this.txtExp.Text != "")
            {
                if (Add == true)
            {
                //Get values from text boxes in appropriate variables
                int ID = Convert.ToInt32(this.txtID.Text);
                string name = this.txtName.Text;
                int age = Convert.ToInt32(this.txtAge.Text);
                string gender = this.txtGen.Text;
                int no = Convert.ToInt32(this.txtCon.Text);
                string add = this.txtAdd.Text;
                int exp = Convert.ToInt32(this.txtExp.Text);

                //Query for inserting the new values in table
                string ins = "INSERT INTO Technicians(T_Name, T_Age, T_Gender, T_Contact, T_Address, T_Experience) Values ('" + name + "' , " + age + " , '" + gender + "' , " + no + " , '" + add + "' , " + exp + ")";
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
                int exp = Convert.ToInt32(this.txtExp.Text);

                //Query for updating the new values in table
                string upd = "UPDATE Technicians SET T_Name = '" + name + "' , T_Age = " + age + " , T_Gender = '" + gender + "' , T_Contact = " + no + " , T_Address = '" + add + "' , T_Experience = " + exp + " Where T_ID =  " + ID;
                obj.Update(upd);

                //Confirmation Message
                MessageBox.Show("Database has been updated");
            }

                this.dataGridView.DataSource = null;
                Parent obj1 = new Parent();
                string sel = "select T_ID as ID, T_Name as Name, T_Age as Age, T_Gender as Gender, T_Contact as Contact, T_Address as Address, T_Experience as Experience from Technicians order by T_ID";
                string tabname = "Technicians";
                obj1.Select(sel, tabname);
                this.dataGridView.DataSource = obj1.dset;
                this.dataGridView.DataMember = "Technicians";
                this.cbID.DataSource = obj1.dset;
                this.cbID.DisplayMember = "Technicians.ID";

            btnSave.Enabled = false;
            ClearAll();
            }
            else
                MessageBox.Show("You entered a blank field");
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
        private void txtExp_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            short KeyAscii = (short)e.KeyChar;
            if (!((KeyAscii >= 48 && KeyAscii <= 57) || (KeyAscii == 8)))
                e.KeyChar = (Char)0;
        }

        private void frmTechnician_Load(object sender, EventArgs e)
        {
            this.groupBox5.Enabled = false;
        }
    }
}
