using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMBSoftware.Events
{
    public class StringEventArgs : EventArgs
    {
        public string _value { get; }
        public StringEventArgs(string value)
        {
            _value = value;
        }
    }
}
