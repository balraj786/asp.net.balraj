using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace project
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        Parent obj = new Parent();
        private void button1_Click(object sender, EventArgs e)
        {
            if (radInv.Checked == true)
            {
                this.crystalReportViewer1.Visible = true;
                this.crystalReportViewer2.Visible = false;
                this.crystalReportViewer3.Visible = false;
                this.crystalReportViewer4.Visible = false;
                this.crystalReportViewer5.Visible = false;
                this.crystalReportViewer6.Visible = false;

            }
            else if (radDon.Checked == true)
            {
                this.crystalReportViewer1.Visible = false;
                this.crystalReportViewer2.Visible = true;
                this.crystalReportViewer3.Visible = false;
                this.crystalReportViewer4.Visible = false;
                this.crystalReportViewer5.Visible = false;
                this.crystalReportViewer6.Visible = false;
            }
            else if (radMem.Checked == true)
            {
                this.crystalReportViewer1.Visible = false;
                this.crystalReportViewer2.Visible = false;
                this.crystalReportViewer3.Visible = true;
                this.crystalReportViewer4.Visible = false;
                this.crystalReportViewer5.Visible = false;
                this.crystalReportViewer6.Visible = false;
            }
            else if (radPat.Checked == true)
            {
                this.crystalReportViewer1.Visible = false;
                this.crystalReportViewer2.Visible = false;
                this.crystalReportViewer3.Visible = false;
                this.crystalReportViewer4.Visible = true;
                this.crystalReportViewer5.Visible = false;
                this.crystalReportViewer6.Visible = false;
            }
            else if (radTech.Checked == true)
            {
                this.crystalReportViewer1.Visible = false;
                this.crystalReportViewer2.Visible = false;
                this.crystalReportViewer3.Visible = false;
                this.crystalReportViewer4.Visible = false;
                this.crystalReportViewer5.Visible = true;
                this.crystalReportViewer6.Visible = false;
            }
            else if (this.radSales.Checked == true)
            {
                this.crystalReportViewer1.Visible = false;
                this.crystalReportViewer2.Visible = false;
                this.crystalReportViewer3.Visible = false;
                this.crystalReportViewer4.Visible = false;
                this.crystalReportViewer5.Visible = false;
                this.crystalReportViewer6.Visible = true;
            }

        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer1.Visible = false;
            this.crystalReportViewer2.Visible = false;
            this.crystalReportViewer3.Visible = false;
            this.crystalReportViewer4.Visible = false;
            this.crystalReportViewer5.Visible = false;
        }
    }
}
