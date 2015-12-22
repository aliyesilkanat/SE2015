using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SE2015.UI_Layer;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using SE2015.Application_Layer;

namespace SE2015
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            String jsonFile = @"{'courses':[{'name':'Basit Makineler','rawName':'basitMakineler','tests':[{'difficuilty':'easy','questions':[{'text':'Aşağıda verilen basit makinelerin hangisinde destek yük ile kuvvetin arasında değildir?','answers':['El arabası','Tahterevalli','Makas','Pense'],'imagePath':{},'rightAnswer':0}]}],'experiments':[{}]}]}";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

            Game.Instance().LoadJson(jsonFile);
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;


            Application.Run(new frmMain());
        }
    }
}
