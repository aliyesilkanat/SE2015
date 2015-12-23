using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SE2015.Logical_Layer
{
    class FormStateManager
    {
        private static Form instance;

        public static Form Instance
        {
            get {

                if (instance == null) {
                    instance = new Form();
                }
                return FormStateManager.instance; }
            set {
                instance = value;
            }
            
        }
        private FormStateManager()
        {

        }

    }
}
