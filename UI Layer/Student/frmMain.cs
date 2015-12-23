using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SE2015.UI_Layer.Student;
using SE2015.Logical_Layer;

namespace SE2015.UI_Layer
{
    public partial class frmMain : Form
    {
        public Form selectedForm;
        private ToolStripMenuItem selectedMenuItem;
   
    

        public frmMain()
        {
            InitializeComponent();
            
            
          
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchForm(sender, new frmAnasayfa());
        }

        private void switchForm(object sender, Form form)
        {
            if (selectedForm != null)
            {
                selectedForm.Dispose();
                selectedMenuItem.Enabled = true;
            }
            selectedForm = form;
            FormStateManager.Instance = form;
            selectedForm.TopLevel = false;
            panelFormContainer.Controls.Add(selectedForm);
            selectedForm.Show();
            selectedMenuItem = sender as ToolStripMenuItem;
            selectedMenuItem.Enabled = false;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void konularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchForm(sender, new frmCourses(sender as ToolStripMenuItem, ref selectedForm, panelFormContainer));
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            menuStrip.Items[0].PerformClick();
        }
        //private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    switchForm(sender, new frmProfil(sender as ToolStripMenuItem, selectedForm, panelFormContainer));
        //}

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            switchForm(sender, new Login(sender as ToolStripMenuItem, selectedForm, panelFormContainer));
        }
    }
}
