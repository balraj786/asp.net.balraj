﻿namespace project
{
    partial class frmTechnician
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTechnician));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtGen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExp = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBloodGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(10, 164);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(10, 130);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox5.BackgroundImage")));
            this.groupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox5.Controls.Add(this.btnExit);
            this.groupBox5.Controls.Add(this.btnDelete);
            this.groupBox5.Controls.Add(this.btnSave);
            this.groupBox5.Controls.Add(this.btnAdd);
            this.groupBox5.Controls.Add(this.btnedit);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(712, 90);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(136, 204);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Controls";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(10, 94);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(10, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.Transparent;
            this.btnedit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnedit.BackgroundImage")));
            this.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.White;
            this.btnedit.Location = new System.Drawing.Point(10, 57);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(111, 23);
            this.btnedit.TabIndex = 11;
            this.btnedit.Text = "E&dit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // cbID
            // 
            this.cbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(279, 30);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(105, 24);
            this.cbID.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(164, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 18);
            this.label12.TabIndex = 20;
            this.label12.Text = "Technician ID";
            // 
            // txtAge
            // 
            this.txtAge.Enabled = false;
            this.txtAge.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(179, 96);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(35, 22);
            this.txtAge.TabIndex = 6;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_TextChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.IndianRed;
            this.btnConnect.BackgroundImage = global::project.Properties.Resources.smallpp;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(436, 21);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(293, 37);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect to Database";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImage = global::project.Properties.Resources.pp;
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox4.Controls.Add(this.btnConnect);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(9, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(859, 305);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Technician";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::project.Properties.Resources.A_Lab_Technician9;
            this.pictureBox1.Location = new System.Drawing.Point(11, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtGen);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtExp);
            this.groupBox3.Controls.Add(this.cbID);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtAge);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtID);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txtAdd);
            this.groupBox3.Controls.Add(this.txtCon);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(297, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 204);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personal Information";
            // 
            // txtGen
            // 
            this.txtGen.Enabled = false;
            this.txtGen.FormattingEnabled = true;
            this.txtGen.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txtGen.Location = new System.Drawing.Point(71, 96);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(68, 24);
            this.txtGen.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Years of Experience :";
            // 
            // txtExp
            // 
            this.txtExp.Enabled = false;
            this.txtExp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExp.Location = new System.Drawing.Point(246, 164);
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(69, 22);
            this.txtExp.TabIndex = 9;
            this.txtExp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExp_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(142, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "Age :";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(71, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(68, 22);
            this.txtID.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(6, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 16);
            this.label16.TabIndex = 12;
            this.label16.Text = "Address :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(217, 96);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 16);
            this.label17.TabIndex = 13;
            this.label17.Text = "Contact No :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(6, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 16);
            this.label18.TabIndex = 9;
            this.label18.Text = "Gender :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(6, 62);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 16);
            this.label19.TabIndex = 10;
            this.label19.Text = "Name :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(6, 35);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(28, 16);
            this.label20.TabIndex = 11;
            this.label20.Text = "ID :";
            // 
            // txtAdd
            // 
            this.txtAdd.Enabled = false;
            this.txtAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd.Location = new System.Drawing.Point(71, 128);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(332, 22);
            this.txtAdd.TabIndex = 8;
            // 
            // txtCon
            // 
            this.txtCon.Enabled = false;
            this.txtCon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCon.Location = new System.Drawing.Point(298, 96);
            this.txtCon.Name = "txtCon";
            this.txtCon.Size = new System.Drawing.Size(105, 22);
            this.txtCon.TabIndex = 7;
            this.txtCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCon_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(71, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(332, 22);
            this.txtName.TabIndex = 4;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_TextChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(24, 321);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(580, 240);
            this.dataGridView.TabIndex = 33;
            this.dataGridView.Visible = false;
            // 
            // dIDDataGridViewTextBoxColumn
            // 
            this.dIDDataGridViewTextBoxColumn.DataPropertyName = "D_ID";
            this.dIDDataGridViewTextBoxColumn.HeaderText = "D_ID";
            this.dIDDataGridViewTextBoxColumn.Name = "dIDDataGridViewTextBoxColumn";
            // 
            // tIDDataGridViewTextBoxColumn
            // 
            this.tIDDataGridViewTextBoxColumn.DataPropertyName = "T_ID";
            this.tIDDataGridViewTextBoxColumn.HeaderText = "T_ID";
            this.tIDDataGridViewTextBoxColumn.Name = "tIDDataGridViewTextBoxColumn";
            // 
            // dAgeDataGridViewTextBoxColumn
            // 
            this.dAgeDataGridViewTextBoxColumn.DataPropertyName = "D_Age";
            this.dAgeDataGridViewTextBoxColumn.HeaderText = "D_Age";
            this.dAgeDataGridViewTextBoxColumn.Name = "dAgeDataGridViewTextBoxColumn";
            // 
            // dNameDataGridViewTextBoxColumn
            // 
            this.dNameDataGridViewTextBoxColumn.DataPropertyName = "D_Name";
            this.dNameDataGridViewTextBoxColumn.HeaderText = "D_Name";
            this.dNameDataGridViewTextBoxColumn.Name = "dNameDataGridViewTextBoxColumn";
            // 
            // tNameDataGridViewTextBoxColumn
            // 
            this.tNameDataGridViewTextBoxColumn.DataPropertyName = "T_Name";
            this.tNameDataGridViewTextBoxColumn.HeaderText = "T_Name";
            this.tNameDataGridViewTextBoxColumn.Name = "tNameDataGridViewTextBoxColumn";
            // 
            // dBloodGroupDataGridViewTextBoxColumn
            // 
            this.dBloodGroupDataGridViewTextBoxColumn.DataPropertyName = "D_BloodGroup";
            this.dBloodGroupDataGridViewTextBoxColumn.HeaderText = "D_BloodGroup";
            this.dBloodGroupDataGridViewTextBoxColumn.Name = "dBloodGroupDataGridViewTextBoxColumn";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::project.Properties.Resources.image1s;
            this.pictureBox2.Location = new System.Drawing.Point(607, 322);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(246, 240);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // frmTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project.Properties.Resources.pp;
            this.ClientSize = new System.Drawing.Size(879, 573);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataGridView);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(895, 611);
            this.MinimumSize = new System.Drawing.Size(895, 611);
            this.Name = "frmTechnician";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Technicians";
            this.Load += new System.EventHandler(this.frmTechnician_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox5;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Button btnedit;
        internal System.Windows.Forms.ComboBox cbID;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.DataGridView dataGridView;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.Label label18;
        internal System.Windows.Forms.Label label19;
        internal System.Windows.Forms.Label label20;
        internal System.Windows.Forms.TextBox txtAdd;
        internal System.Windows.Forms.TextBox txtCon;
        internal System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dBloodGroupDataGridViewTextBoxColumn;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtExp;
        private System.Windows.Forms.ComboBox txtGen;
        private System.Windows.Forms.PictureBox pictureBox2;


    }
}