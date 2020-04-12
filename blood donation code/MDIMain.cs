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
    public partial class MDIMain : Form
    {
        private int childFormNumber = 0;

        public MDIMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void donorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDonor objDon=new frmDonor ();
            objDon.MdiParent = this;
            objDon.Show();
        }

        private void bankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBank objBnk = new frmBank();
            objBnk.MdiParent = this;
            objBnk.Show();
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMembers objMem = new frmMembers();
            objMem.MdiParent = this;
            objMem.Show();
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatients objPat = new frmPatients();
            objPat.MdiParent = this;
            objPat.Show();
        }

        private void techniciansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTechnician objTech = new frmTechnician();
            objTech.MdiParent = this;
            objTech.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSales objSales = new frmSales();
            objSales.MdiParent = this;
            objSales.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin objLogin = new frmLogin();
            objLogin.Show();
            bank.username = "";
            bank.password = "";
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAbout objAb = new frmAbout();
            objAb.MdiParent = this;
            objAb.Show();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReport objHlp = new frmReport();
            objHlp.MdiParent = this;
            objHlp.Show();
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewUser obj = new frmNewUser();
            obj.Show();
            this.Hide();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPass obj = new frmPass();
            obj.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
