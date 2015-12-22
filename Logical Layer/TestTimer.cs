using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using SE2015.Application_Layer;

namespace SE2015.Logical_Layer
{
    class TestTimer
    {
        private static TestTimer instance;
        private SE2015.UI_Layer.Student.frmTest timerForm;
        private int index = 10;
        private Timer counter;

        public int Index
        {
            get { return index; }

        }
        public SE2015.UI_Layer.Student.frmTest TimerForm
        {
            get { return timerForm; }
            set { timerForm = value; }
        }

        private TestTimer()
        {

        }
        public void Start(SE2015.UI_Layer.Student.frmTest form)
        {
            this.timerForm = form;
          counter = new Timer(Tick, null, 0, 1000);
        }
        private void Tick(object state)
        {
            index--;
           
           
            if (index==0)
            {
                Game.Instance().Student.SolvedTest = true;
                counter.Change(Timeout.Infinite, Timeout.Infinite);
                counter.Dispose();
                
            } timerForm.TickExternal(index);
        }

        public static TestTimer Instance()
        {
            if (instance == null)
            {
                instance = new TestTimer();
            }
            return instance;
        }
    }
}
