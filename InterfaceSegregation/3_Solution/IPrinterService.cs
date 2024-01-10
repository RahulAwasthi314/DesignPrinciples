using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation._3_Solution
{
    internal interface IPrinterService
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool PhotocopyContent(string content);
    }
}
