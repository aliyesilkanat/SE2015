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
    public partial class Login : Form
    {
        private Panel panelFormContainer;
        private Form selectedForm;
        private ToolStripMenuItem menu;

        public Login(ToolStripMenuItem toolStripMenuItem, Form selectedForm, Panel panelFormContainer)
        {
            InitializeComponent();

            this.menu = toolStripMenuItem;
            this.selectedForm = selectedForm;
            this.panelFormContainer = panelFormContainer;



        }

        public static string adi, soyadi, kullanici_Adi, sifresi, mailAdresi, tipi;

        private void uye_girisi_Click(object sender, EventArgs e)
        {
            kullanici_Adi = kullanici_adi.Text;
            if (adi == null)
                Giris_Uyari.Text = "Veritabanında böyle bir kullanıcı bulunamadı";
            if (adi == kullanici_Adi)
            {
                selectedForm.Dispose();
                selectedForm = new frmCourses(menu, ref selectedForm, panelFormContainer);
                menu.Enabled = true;
                selectedForm.TopLevel = false;
                panelFormContainer.Controls.Add(selectedForm);
                selectedForm.Show();
            }

        }

        private void kayit_ol_Click(object sender, EventArgs e)
        {
            adi = kayit_Ad.Text;
            soyadi = kayit_Soyad.Text;
            kullanici_Adi = kayit_kullanici_Adi.Text;
            sifresi = kayit_sifre.Text;
            mailAdresi = kayit_email.Text;
            tipi = comboBox2_kuyetipi.Text;
            kayitUyari.Text = "Kaydınız gercekleştirimiştir!";

        }
    }
}