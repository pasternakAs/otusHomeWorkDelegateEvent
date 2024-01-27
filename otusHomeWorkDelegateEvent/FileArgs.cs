using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace otusHomeWorkDelegateEvent
{
    public class FileArgs : EventArgs
    {
        private string Message { get; set; }

        public FileArgs(string message)
        {
            Message = message;
        }

        public string GetInfo()
        {
            return Message;
        }
    }
}
