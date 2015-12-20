using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SE2015.Logical_Layer
{
    class KaldiracExperimentDataValidation
    {
        public void validateNumber() { }

        public void validateNumber(System.Windows.Forms.KeyPressEventArgs e, System.Windows.Forms.Label lblAlertTubeLength)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                if (!char.IsControl(e.KeyChar))
                {
                    lblAlertTubeLength.Text = "*Lütfen sayısal bir değer giriniz! ";
                    lblAlertTubeLength.Visible = true;
                    e.Handled = true;
                }
                else
                {
                    lblAlertTubeLength.Visible = false;
                }
            }
            else
            {
                lblAlertTubeLength.Visible = false;
            }
        }

        public void validateTubeLength(string componentLength, string tubeLength, System.Windows.Forms.Label lblAlertMassPosition)
        {
            if (tubeLength != "" && tubeLength != null)
            {
                if (componentLength != "" && componentLength != null)
                {
                    if (Convert.ToInt32(tubeLength) < Convert.ToInt32(componentLength))
                    {
                        lblAlertMassPosition.Text = "*Çubuğun uzunluğunu aşmamalı.!";
                        lblAlertMassPosition.Visible = true;
                    }
                    
                }
            }
        }

    }
}
