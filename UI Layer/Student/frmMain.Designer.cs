﻿namespace SE2015.UI_Layer
{
    partial class frmMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFormContainer = new System.Windows.Forms.Panel();
            this.istatistiklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem,
            this.konularToolStripMenuItem,
            this.profilToolStripMenuItem,
            this.istatistiklerToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1215, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // anasayfaToolStripMenuItem
            // 
            this.anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            this.anasayfaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.anasayfaToolStripMenuItem.Text = "Anasayfa";
            this.anasayfaToolStripMenuItem.Click += new System.EventHandler(this.anasayfaToolStripMenuItem_Click);
            // 
            // konularToolStripMenuItem
            // 
            this.konularToolStripMenuItem.Name = "konularToolStripMenuItem";
            this.konularToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.konularToolStripMenuItem.Text = "Konular";
            this.konularToolStripMenuItem.Click += new System.EventHandler(this.konularToolStripMenuItem_Click);
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.profilToolStripMenuItem.Text = "Profil";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // panelFormContainer
            // 
            this.panelFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormContainer.Location = new System.Drawing.Point(0, 24);
            this.panelFormContainer.Name = "panelFormContainer";
            this.panelFormContainer.Size = new System.Drawing.Size(1215, 743);
            this.panelFormContainer.TabIndex = 1;
            // 
            // istatistiklerToolStripMenuItem
            // 
            this.istatistiklerToolStripMenuItem.Name = "istatistiklerToolStripMenuItem";
            this.istatistiklerToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.istatistiklerToolStripMenuItem.Text = "İstatistikler";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 767);
            this.Controls.Add(this.panelFormContainer);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.Text = "ScienceLab";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Panel panelFormContainer;
        private System.Windows.Forms.ToolStripMenuItem istatistiklerToolStripMenuItem;
    }
}