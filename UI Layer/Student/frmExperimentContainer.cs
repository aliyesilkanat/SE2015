using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SE2015.Logical_Layer;

namespace SE2015
{
    public partial class frmExperimentContainer : Form
    {
        private KaldiracExperimentDataValidation validator;
        public frmExperimentContainer()
        {
            InitializeComponent();
            validator = new KaldiracExperimentDataValidation();

        }

        private void btnExecuteExperiment_Click(object sender, EventArgs e)
        {
            if (((txtTubeLength.Text != "" && txtForceNewton.Text != "") && (txtForcePosition.Text != "" && txtMassNewton.Text != "")) && (txtMassPosition.Text != "" && txtSupportPosition.Text != ""))
            {
                new KaldiracExperiment().drawExperiment(groupBoxExperiment, Convert.ToInt32(txtTubeLength.Text), Convert.ToInt32(txtForcePosition.Text), Convert.ToInt32(txtMassPosition.Text), Convert.ToInt32(txtForceNewton.Text), Convert.ToInt32(txtMassNewton.Text), Convert.ToInt32(txtSupportPosition.Text));
            }
            else
            {
                MessageBox.Show("Lütfen tüm değerleri giriniz!");
            }




            //int middleX = 150 + (200 / 2);
            //Pen blackPen = new Pen(Color.Black);
            //System.Drawing.Graphics formGraphics;
            //formGraphics = groupBoxExperimentContainer.CreateGraphics();
            //formGraphics.DrawPolygon(blackPen, new Point[] { new Point(middleX, 250 + 20), new Point(middleX - 10, 250 + 20 + 30), new Point(middleX + 10, 250 + 20 + 30) });
            //formGraphics.RotateTransform(10); formGraphics.TranslateTransform(1, -30);
            //Rectangle box = new Rectangle(150, 250, 200, 20);

            //formGraphics.DrawRectangle(blackPen, box);


            ////formGraphics.TranslateTransform(150, 250);
            //formGraphics.DrawLine(blackPen, new Point(150 + 20, 250), new Point(150 + 20, 250 + 20));

            //blackPen.Dispose();
            //formGraphics.Dispose();
        }

        private void txtTubeLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.validateNumber(e, lblAlertTubeLength);

        }

        private void txtMassPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.validateNumber(e, lblAlertMassPosition);

        }

        private void txtMassNewton_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.validateNumber(e, lblAlertMassNewton);

        }

        private void txtSupportPosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.validateNumber(e, lblAlertSupportPosition);


        }

        private void txtForcePosition_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.validateNumber(e, lblAlertForcePosition);

        }

        private void txtForceNewton_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.validateNumber(e, lblAlertForceNewton);

        }

        private void txtTubeLength_TextChanged(object sender, EventArgs e)
        {
            if (txtTubeLength.TextLength > 0)
            {

                if (Convert.ToInt32(txtTubeLength.Text) > 25)
                {
                    lblAlertTubeLength.Text = "*Çubuğun uzunluğu 25 birimi geçemez!";
                    lblAlertTubeLength.Visible = true;
                }
                else
                {


                    txtForcePosition.Enabled = true;
                    txtSupportPosition.Enabled = true;
                    txtMassPosition.Enabled = true;
                }

             }
            else
            {
                txtForcePosition.Enabled = false;
                txtSupportPosition.Enabled = false;
                txtMassPosition.Enabled = false;
            }





        }

        private void txtSupportPosition_TextChanged(object sender, EventArgs e)
        {
            validator.validateTubeLength(txtSupportPosition.Text, txtTubeLength.Text, lblAlertSupportPosition);
        }

        private void txtForcePosition_TextChanged(object sender, EventArgs e)
        {
            validator.validateTubeLength(txtForcePosition.Text, txtTubeLength.Text, lblAlertForcePosition);

        }

        private void txtMassPosition_TextChanged(object sender, EventArgs e)
        {
            validator.validateTubeLength(txtMassPosition.Text, txtTubeLength.Text, lblAlertMassPosition);
        }

        private void txtMassPosition_Leave(object sender, EventArgs e)
        {
            lblAlertMassPosition.Visible = false;
        }

        private void txtTubeLength_Leave(object sender, EventArgs e)
        {
            lblAlertTubeLength.Visible = false;
        }

        private void txtSupportPosition_Leave(object sender, EventArgs e)
        {
            lblAlertSupportPosition.Visible = false;
        }

        private void txtMassNewton_Leave(object sender, EventArgs e)
        {
            lblAlertMassNewton.Visible = false;
        }

        private void txtForceNewton_Leave(object sender, EventArgs e)
        {
            lblAlertForceNewton.Visible = false;

        }
        private void txtForcePosition_Leave(object sender, EventArgs e)
        {
            lblAlertForcePosition.Visible = false;
        }



    }



}
