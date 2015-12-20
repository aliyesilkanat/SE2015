using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SE2015.UI_Layer;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;

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
            String jsonFile = @"{'courses':[{'name':'Basit Makineler','rawName':'basitMakineler','tests':[{'difficuilty':'easy','questions':[{'text':'Aşağıda verilen basit makinelerin hangisinde destek yük ile kuvvetin arasında değildir?','answers':['El arabası','Tahterevalli','Makas','Pense'],'image':{}}]}],'experiments':[{}]}]}";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            JToken tkoen = JObject.Parse(jsonFile)["courses"].First["name"];

            Application.Run(new frmMain());
        }
    }
}
