using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation._1_design
{
    internal class HPLaserJetPrinter : IPrinterTasks
    {
        public bool FaxContent(string content)
        {
            Console.WriteLine("Fax...", content);
            return true;
        }

        public bool PhotocopyContent(string content)
        {
            Console.WriteLine("Photocopy...", content);
            return true;
        }

        public bool PrintContent(string content)
        {
            Console.WriteLine("Print...", content);
            return true;
        }

        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan..", content);
            return true;
        }
    }
}
