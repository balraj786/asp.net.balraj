namespace project
{
    partial class frmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.button1 = new System.Windows.Forms.Button();
            this.radInv = new System.Windows.Forms.RadioButton();
            this.radDon = new System.Windows.Forms.RadioButton();
            this.radMem = new System.Windows.Forms.RadioButton();
            this.radPat = new System.Windows.Forms.RadioButton();
            this.radTech = new System.Windows.Forms.RadioButton();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport11 = new project.CrystalReport1();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport21 = new project.CrystalReport2();
            this.crystalReportViewer3 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport31 = new project.CrystalReport3();
            this.crystalReportViewer4 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport41 = new project.CrystalReport4();
            this.crystalReportViewer5 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport51 = new project.CrystalReport5();
            this.crystalReportViewer6 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport61 = new project.CrystalReport6();
            this.radSales = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(264, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radInv
            // 
            this.radInv.AutoSize = true;
            this.radInv.BackColor = System.Drawing.Color.Transparent;
            this.radInv.Checked = true;
            this.radInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radInv.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.radInv.Location = new System.Drawing.Point(23, 21);
            this.radInv.Name = "radInv";
            this.radInv.Size = new System.Drawing.Size(118, 29);
            this.radInv.TabIndex = 1;
            this.radInv.TabStop = true;
            this.radInv.Text = "Inventory";
            this.radInv.UseVisualStyleBackColor = false;
            // 
            // radDon
            // 
            this.radDon.AutoSize = true;
            this.radDon.BackColor = System.Drawing.Color.Transparent;
            this.radDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDon.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.radDon.Location = new System.Drawing.Point(160, 21);
            this.radDon.Name = "radDon";
            this.radDon.Size = new System.Drawing.Size(99, 29);
            this.radDon.TabIndex = 2;
            this.radDon.TabStop = true;
            this.radDon.Text = "Donors";
            this.radDon.UseVisualStyleBackColor = false;
            // 
            // radMem
            // 
            this.radMem.AutoSize = true;
            this.radMem.BackColor = System.Drawing.Color.Transparent;
            this.radMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMem.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.radMem.Location = new System.Drawing.Point(280, 21);
            this.radMem.Name = "radMem";
            this.radMem.Size = new System.Drawing.Size(119, 29);
            this.radMem.TabIndex = 3;
            this.radMem.TabStop = true;
            this.radMem.Text = "Members";
            this.radMem.UseVisualStyleBackColor = false;
            // 
            // radPat
            // 
            this.radPat.AutoSize = true;
            this.radPat.BackColor = System.Drawing.Color.Transparent;
            this.radPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPat.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.radPat.Location = new System.Drawing.Point(427, 21);
            this.radPat.Name = "radPat";
            this.radPat.Size = new System.Drawing.Size(108, 29);
            this.radPat.TabIndex = 4;
            this.radPat.TabStop = true;
            this.radPat.Text = "Patients";
            this.radPat.UseVisualStyleBackColor = false;
            // 
            // radTech
            // 
            this.radTech.AutoSize = true;
            this.radTech.BackColor = System.Drawing.Color.Transparent;
            this.radTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTech.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.radTech.Location = new System.Drawing.Point(562, 21);
            this.radTech.Name = "radTech";
            this.radTech.Size = new System.Drawing.Size(146, 29);
            this.radTech.TabIndex = 5;
            this.radTech.TabStop = true;
            this.radTech.Text = "Technicians";
            this.radTech.UseVisualStyleBackColor = false;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 158);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.CrystalReport11;
            this.crystalReportViewer1.Size = new System.Drawing.Size(704, 435);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.Visible = false;
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = 0;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Location = new System.Drawing.Point(12, 158);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.ReportSource = this.CrystalReport21;
            this.crystalReportViewer2.Size = new System.Drawing.Size(704, 435);
            this.crystalReportViewer2.TabIndex = 7;
            this.crystalReportViewer2.Visible = false;
            // 
            // crystalReportViewer3
            // 
            this.crystalReportViewer3.ActiveViewIndex = 0;
            this.crystalReportViewer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer3.Location = new System.Drawing.Point(12, 158);
            this.crystalReportViewer3.Name = "crystalReportViewer3";
            this.crystalReportViewer3.ReportSource = this.CrystalReport31;
            this.crystalReportViewer3.Size = new System.Drawing.Size(704, 435);
            this.crystalReportViewer3.TabIndex = 8;
            this.crystalReportViewer3.Visible = false;
            // 
            // crystalReportViewer4
            // 
            this.crystalReportViewer4.ActiveViewIndex = 0;
            this.crystalReportViewer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer4.Location = new System.Drawing.Point(11, 158);
            this.crystalReportViewer4.Name = "crystalReportViewer4";
            this.crystalReportViewer4.ReportSource = this.CrystalReport41;
            this.crystalReportViewer4.Size = new System.Drawing.Size(704, 435);
            this.crystalReportViewer4.TabIndex = 9;
            this.crystalReportViewer4.Visible = false;
            // 
            // crystalReportViewer5
            // 
            this.crystalReportViewer5.ActiveViewIndex = 0;
            this.crystalReportViewer5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer5.Location = new System.Drawing.Point(12, 158);
            this.crystalReportViewer5.Name = "crystalReportViewer5";
            this.crystalReportViewer5.ReportSource = this.CrystalReport51;
            this.crystalReportViewer5.Size = new System.Drawing.Size(704, 435);
            this.crystalReportViewer5.TabIndex = 10;
            this.crystalReportViewer5.Visible = false;
            // 
            // crystalReportViewer6
            // 
            this.crystalReportViewer6.ActiveViewIndex = 0;
            this.crystalReportViewer6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer6.Location = new System.Drawing.Point(12, 158);
            this.crystalReportViewer6.Name = "crystalReportViewer6";
            this.crystalReportViewer6.ReportSource = this.CrystalReport61;
            this.crystalReportViewer6.Size = new System.Drawing.Size(703, 435);
            this.crystalReportViewer6.TabIndex = 11;
            this.crystalReportViewer6.Visible = false;
            // 
            // radSales
            // 
            this.radSales.AutoSize = true;
            this.radSales.BackColor = System.Drawing.Color.Transparent;
            this.radSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSales.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.radSales.Location = new System.Drawing.Point(297, 58);
            this.radSales.Name = "radSales";
            this.radSales.Size = new System.Drawing.Size(84, 29);
            this.radSales.TabIndex = 12;
            this.radSales.TabStop = true;
            this.radSales.Text = "Sales";
            this.radSales.UseVisualStyleBackColor = false;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 608);
            this.Controls.Add(this.radSales);
            this.Controls.Add(this.crystalReportViewer6);
            this.Controls.Add(this.crystalReportViewer5);
            this.Controls.Add(this.crystalReportViewer4);
            this.Controls.Add(this.crystalReportViewer3);
            this.Controls.Add(this.crystalReportViewer2);
            this.Controls.Add(this.radTech);
            this.Controls.Add(this.radPat);
            this.Controls.Add(this.radMem);
            this.Controls.Add(this.radDon);
            this.Controls.Add(this.radInv);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(744, 646);
            this.MinimumSize = new System.Drawing.Size(744, 646);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.RadioButton radInv;
        private System.Windows.Forms.RadioButton radDon;
        private System.Windows.Forms.RadioButton radMem;
        private System.Windows.Forms.RadioButton radPat;
        private System.Windows.Forms.RadioButton radTech;
        private CrystalReport1 CrystalReport11;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private CrystalReport2 CrystalReport21;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer3;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer4;
        private CrystalReport3 CrystalReport31;
        private CrystalReport4 CrystalReport41;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer5;
        private CrystalReport5 CrystalReport51;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer6;
        private CrystalReport6 CrystalReport61;
        private System.Windows.Forms.RadioButton radSales;
    }
}