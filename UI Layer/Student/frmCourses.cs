using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SE2015.UI_Layer.Student
{
    public partial class frmCourses : Form
    {
        private ToolStripMenuItem toolStripMenuItem;
        private Form selectedForm;
        private Panel panelFormContainer;
        public frmCourses(ToolStripMenuItem toolStripMenuItem, Form selectedForm, Panel panelFormContainer)
        {
            InitializeComponent();
            this.toolStripMenuItem = toolStripMenuItem;
            this.selectedForm = selectedForm;
            this.panelFormContainer = panelFormContainer;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (Login.adi == null)
            {
                if (MessageBox.Show("Giris yapmalisiniz", "Uyarı", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    //Login'e gitmiyor ama arıza da çıkartmıyor..

                    selectedForm.Dispose();
                    selectedForm = new Login(toolStripMenuItem, selectedForm, panelFormContainer);
                    toolStripMenuItem.Enabled = true;
                    selectedForm.TopLevel = false;
                    panelFormContainer.Controls.Add(selectedForm);
                    selectedForm.Show();
                }
            }

            else
            {
                selectedForm.Dispose();
                selectedForm = new frmOneCourse(panelFormContainer, selectedForm, 0, toolStripMenuItem);
                toolStripMenuItem.Enabled = true;
                selectedForm.TopLevel = false;
                panelFormContainer.Controls.Add(selectedForm);
                selectedForm.Show();
            }
        }





    }
}
