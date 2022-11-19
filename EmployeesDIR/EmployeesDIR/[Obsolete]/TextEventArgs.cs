using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesDIR
{
    class TextEventArgs : EventArgs
    {
        private string strText;
        public string StrText
        {
            get { return strText; }
        }
        public TextEventArgs(string inStrText)
        {
            this.strText = inStrText;
        }
    }
}
