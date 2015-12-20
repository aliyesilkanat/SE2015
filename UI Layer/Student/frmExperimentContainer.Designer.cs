using System.Drawing;
namespace SE2015
{
    partial class frmExperimentContainer
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
            this.groupBoxExperimentContainer = new System.Windows.Forms.GroupBox();
            this.groupBoxExperiment = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAlertForceNewton = new System.Windows.Forms.Label();
            this.lblAlertForcePosition = new System.Windows.Forms.Label();
            this.lblAlertSupportPosition = new System.Windows.Forms.Label();
            this.lblAlertMassNewton = new System.Windows.Forms.Label();
            this.lblAlertMassPosition = new System.Windows.Forms.Label();
            this.lblAlertTubeLength = new System.Windows.Forms.Label();
            this.btnExecuteExperiment = new System.Windows.Forms.Button();
            this.txtSupportPosition = new System.Windows.Forms.TextBox();
            this.txtForcePosition = new System.Windows.Forms.TextBox();
            this.txtForceNewton = new System.Windows.Forms.TextBox();
            this.txtMassNewton = new System.Windows.Forms.TextBox();
            this.txtMassPosition = new System.Windows.Forms.TextBox();
            this.txtTubeLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxExperimentContainer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxExperimentContainer
            // 
            this.groupBoxExperimentContainer.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxExperimentContainer.Controls.Add(this.groupBoxExperiment);
            this.groupBoxExperimentContainer.Controls.Add(this.groupBox2);
            this.groupBoxExperimentContainer.Controls.Add(this.groupBox1);
            this.groupBoxExperimentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxExperimentContainer.Location = new System.Drawing.Point(0, 0);
            this.groupBoxExperimentContainer.Name = "groupBoxExperimentContainer";
            this.groupBoxExperimentContainer.Size = new System.Drawing.Size(1206, 918);
            this.groupBoxExperimentContainer.TabIndex = 0;
            this.groupBoxExperimentContainer.TabStop = false;
            // 
            // groupBoxExperiment
            // 
            this.groupBoxExperiment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxExperiment.Location = new System.Drawing.Point(3, 205);
            this.groupBoxExperiment.Name = "groupBoxExperiment";
            this.groupBoxExperiment.Size = new System.Drawing.Size(1200, 710);
            this.groupBoxExperiment.TabIndex = 4;
            this.groupBoxExperiment.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAlertForceNewton);
            this.groupBox2.Controls.Add(this.lblAlertForcePosition);
            this.groupBox2.Controls.Add(this.lblAlertSupportPosition);
            this.groupBox2.Controls.Add(this.lblAlertMassNewton);
            this.groupBox2.Controls.Add(this.lblAlertMassPosition);
            this.groupBox2.Controls.Add(this.lblAlertTubeLength);
            this.groupBox2.Controls.Add(this.btnExecuteExperiment);
            this.groupBox2.Controls.Add(this.txtSupportPosition);
            this.groupBox2.Controls.Add(this.txtForcePosition);
            this.groupBox2.Controls.Add(this.txtForceNewton);
            this.groupBox2.Controls.Add(this.txtMassNewton);
            this.groupBox2.Controls.Add(this.txtMassPosition);
            this.groupBox2.Controls.Add(this.txtTubeLength);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1200, 145);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deney Parametreleri";
            // 
            // lblAlertForceNewton
            // 
            this.lblAlertForceNewton.AutoSize = true;
            this.lblAlertForceNewton.ForeColor = System.Drawing.Color.Red;
            this.lblAlertForceNewton.Location = new System.Drawing.Point(880, 84);
            this.lblAlertForceNewton.Name = "lblAlertForceNewton";
            this.lblAlertForceNewton.Size = new System.Drawing.Size(154, 13);
            this.lblAlertForceNewton.TabIndex = 8;
            this.lblAlertForceNewton.Text = "*Lütfen sayısal bir değer giriniz! ";
            this.lblAlertForceNewton.Visible = false;
            // 
            // lblAlertForcePosition
            // 
            this.lblAlertForcePosition.AutoSize = true;
            this.lblAlertForcePosition.ForeColor = System.Drawing.Color.Red;
            this.lblAlertForcePosition.Location = new System.Drawing.Point(880, 52);
            this.lblAlertForcePosition.Name = "lblAlertForcePosition";
            this.lblAlertForcePosition.Size = new System.Drawing.Size(154, 13);
            this.lblAlertForcePosition.TabIndex = 8;
            this.lblAlertForcePosition.Text = "*Lütfen sayısal bir değer giriniz! ";
            this.lblAlertForcePosition.Visible = false;
            // 
            // lblAlertSupportPosition
            // 
            this.lblAlertSupportPosition.AutoSize = true;
            this.lblAlertSupportPosition.ForeColor = System.Drawing.Color.Red;
            this.lblAlertSupportPosition.Location = new System.Drawing.Point(880, 22);
            this.lblAlertSupportPosition.Name = "lblAlertSupportPosition";
            this.lblAlertSupportPosition.Size = new System.Drawing.Size(154, 13);
            this.lblAlertSupportPosition.TabIndex = 8;
            this.lblAlertSupportPosition.Text = "*Lütfen sayısal bir değer giriniz! ";
            this.lblAlertSupportPosition.Visible = false;
            // 
            // lblAlertMassNewton
            // 
            this.lblAlertMassNewton.AutoSize = true;
            this.lblAlertMassNewton.ForeColor = System.Drawing.Color.Red;
            this.lblAlertMassNewton.Location = new System.Drawing.Point(273, 80);
            this.lblAlertMassNewton.Name = "lblAlertMassNewton";
            this.lblAlertMassNewton.Size = new System.Drawing.Size(154, 13);
            this.lblAlertMassNewton.TabIndex = 8;
            this.lblAlertMassNewton.Text = "*Lütfen sayısal bir değer giriniz! ";
            this.lblAlertMassNewton.Visible = false;
            // 
            // lblAlertMassPosition
            // 
            this.lblAlertMassPosition.AutoSize = true;
            this.lblAlertMassPosition.ForeColor = System.Drawing.Color.Red;
            this.lblAlertMassPosition.Location = new System.Drawing.Point(273, 52);
            this.lblAlertMassPosition.Name = "lblAlertMassPosition";
            this.lblAlertMassPosition.Size = new System.Drawing.Size(154, 13);
            this.lblAlertMassPosition.TabIndex = 8;
            this.lblAlertMassPosition.Text = "*Lütfen sayısal bir değer giriniz! ";
            this.lblAlertMassPosition.Visible = false;
            // 
            // lblAlertTubeLength
            // 
            this.lblAlertTubeLength.AutoSize = true;
            this.lblAlertTubeLength.ForeColor = System.Drawing.Color.Red;
            this.lblAlertTubeLength.Location = new System.Drawing.Point(273, 22);
            this.lblAlertTubeLength.Name = "lblAlertTubeLength";
            this.lblAlertTubeLength.Size = new System.Drawing.Size(154, 13);
            this.lblAlertTubeLength.TabIndex = 8;
            this.lblAlertTubeLength.Text = "*Lütfen sayısal bir değer giriniz! ";
            this.lblAlertTubeLength.Visible = false;
            // 
            // btnExecuteExperiment
            // 
            this.btnExecuteExperiment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExecuteExperiment.Location = new System.Drawing.Point(454, 108);
            this.btnExecuteExperiment.Name = "btnExecuteExperiment";
            this.btnExecuteExperiment.Size = new System.Drawing.Size(136, 31);
            this.btnExecuteExperiment.TabIndex = 7;
            this.btnExecuteExperiment.Text = "Gerçekleştir";
            this.btnExecuteExperiment.UseVisualStyleBackColor = true;
            this.btnExecuteExperiment.Click += new System.EventHandler(this.btnExecuteExperiment_Click);
            // 
            // txtSupportPosition
            // 
            this.txtSupportPosition.Enabled = false;
            this.txtSupportPosition.Location = new System.Drawing.Point(774, 15);
            this.txtSupportPosition.Name = "txtSupportPosition";
            this.txtSupportPosition.Size = new System.Drawing.Size(100, 20);
            this.txtSupportPosition.TabIndex = 4;
            this.txtSupportPosition.TextChanged += new System.EventHandler(this.txtSupportPosition_TextChanged);
            this.txtSupportPosition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupportPosition_KeyPress);
            this.txtSupportPosition.Leave += new System.EventHandler(this.txtSupportPosition_Leave);
            // 
            // txtForcePosition
            // 
            this.txtForcePosition.Enabled = false;
            this.txtForcePosition.Location = new System.Drawing.Point(774, 45);
            this.txtForcePosition.Name = "txtForcePosition";
            this.txtForcePosition.Size = new System.Drawing.Size(100, 20);
            this.txtForcePosition.TabIndex = 5;
            this.txtForcePosition.TextChanged += new System.EventHandler(this.txtForcePosition_TextChanged);
            this.txtForcePosition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtForcePosition_KeyPress);
            this.txtForcePosition.Leave += new System.EventHandler(this.txtForcePosition_Leave);
            // 
            // txtForceNewton
            // 
            this.txtForceNewton.Location = new System.Drawing.Point(774, 77);
            this.txtForceNewton.Name = "txtForceNewton";
            this.txtForceNewton.Size = new System.Drawing.Size(100, 20);
            this.txtForceNewton.TabIndex = 6;
            this.txtForceNewton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtForceNewton_KeyPress);
            this.txtForceNewton.Leave += new System.EventHandler(this.txtForceNewton_Leave);
            // 
            // txtMassNewton
            // 
            this.txtMassNewton.Location = new System.Drawing.Point(157, 77);
            this.txtMassNewton.Name = "txtMassNewton";
            this.txtMassNewton.Size = new System.Drawing.Size(100, 20);
            this.txtMassNewton.TabIndex = 3;
            this.txtMassNewton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMassNewton_KeyPress);
            this.txtMassNewton.Leave += new System.EventHandler(this.txtMassNewton_Leave);
            // 
            // txtMassPosition
            // 
            this.txtMassPosition.Enabled = false;
            this.txtMassPosition.Location = new System.Drawing.Point(157, 49);
            this.txtMassPosition.Name = "txtMassPosition";
            this.txtMassPosition.Size = new System.Drawing.Size(100, 20);
            this.txtMassPosition.TabIndex = 2;
            this.txtMassPosition.TextChanged += new System.EventHandler(this.txtMassPosition_TextChanged);
            this.txtMassPosition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMassPosition_KeyPress);
            this.txtMassPosition.Leave += new System.EventHandler(this.txtMassPosition_Leave);
            // 
            // txtTubeLength
            // 
            this.txtTubeLength.Location = new System.Drawing.Point(157, 19);
            this.txtTubeLength.Name = "txtTubeLength";
            this.txtTubeLength.Size = new System.Drawing.Size(100, 20);
            this.txtTubeLength.TabIndex = 1;
            this.txtTubeLength.TextChanged += new System.EventHandler(this.txtTubeLength_TextChanged);
            this.txtTubeLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTubeLength_KeyPress);
            this.txtTubeLength.Leave += new System.EventHandler(this.txtTubeLength_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(635, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Desteğin Yeri (Birim)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(635, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kuvvet (N)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(635, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kuvvetin Yeri (Birim)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ağırlık (N)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ağırlığın Yeri (Birim)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Çubuk Uzunluğu (Birim)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1200, 44);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(464, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kaldıraç Deneyi";
            // 
            // frmExperimentContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 918);
            this.Controls.Add(this.groupBoxExperimentContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExperimentContainer";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxExperimentContainer.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxExperimentContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxExperiment;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAlertForceNewton;
        private System.Windows.Forms.Label lblAlertForcePosition;
        private System.Windows.Forms.Label lblAlertSupportPosition;
        private System.Windows.Forms.Label lblAlertMassNewton;
        private System.Windows.Forms.Label lblAlertMassPosition;
        private System.Windows.Forms.Label lblAlertTubeLength;
        private System.Windows.Forms.Button btnExecuteExperiment;
        private System.Windows.Forms.TextBox txtSupportPosition;
        private System.Windows.Forms.TextBox txtForcePosition;
        private System.Windows.Forms.TextBox txtForceNewton;
        private System.Windows.Forms.TextBox txtMassNewton;
        private System.Windows.Forms.TextBox txtMassPosition;
        private System.Windows.Forms.TextBox txtTubeLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;

    }
}

