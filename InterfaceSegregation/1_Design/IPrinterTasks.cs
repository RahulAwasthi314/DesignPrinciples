using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation._1_design
{
    internal interface IPrinterTasks
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool FaxContent(string content);
        bool PhotocopyContent(string content);
    }
}
