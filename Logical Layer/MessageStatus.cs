using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SE2015.Logical_Layer
{
    class MessageStatus
    {
        private MessageStatus()
        {

        }
        private static MessageStatus instance;


        internal static MessageStatus Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MessageStatus();

                }

                return MessageStatus.instance;
            }

        }
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        private bool isOpen = false;

        public bool IsOpen
        {
            get { return isOpen; }
            set { isOpen = value; }
        }
    }
}
