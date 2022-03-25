using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace Ilog
{
    class Ilogger
    {
        Ilogger()
        {
            try
            {
                FileStream logFileL = new FileStream("logs/latest.log", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                FileStream logFileN = new FileStream(DateTime.Now.ToString("yyyymmdd_hhmmss"), FileMode.OpenOrCreate, FileAccess.ReadWrite);
            }
            catch (IOException e)
            {

            }
            
        }
        Ilogger(string filename)
        {
            try
            {
                FileStream logFileL = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            }
            catch (IOException e)
            {

            }
        }
    }
}
