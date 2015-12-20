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
    public partial class frmOneCourse : Form
    {
        private Panel panelFormContainer;
        private Form selectedForm;

        public frmOneCourse(Panel panelFormContainer, Form selectedForm)
        {
            InitializeComponent();
            this.panelFormContainer = panelFormContainer;
            this.selectedForm = selectedForm;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            selectedForm.Dispose();
            selectedForm = new frmExperimentContainer();
            selectedForm.TopLevel = false;
            panelFormContainer.Controls.Add(selectedForm);
            selectedForm.Show();
                
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            selectedForm.Dispose();
            selectedForm = new frmTest();
            selectedForm.TopLevel = false;
            panelFormContainer.Controls.Add(selectedForm);
            selectedForm.Show();
        }
    }
}
