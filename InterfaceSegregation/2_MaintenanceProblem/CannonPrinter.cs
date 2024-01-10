using InterfaceSegregation._1_design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation._2_MaintenanceProblem
{
    // This printer does not have ability to fax.
    internal class CannonPrinter : IPrinterTasks
    {
        // now if we add new method to print duplex in base class as technology innovate
        // backward compatibility is not there.

        public bool FaxContent(string content)
        {
            // THis cannot be implemented.
            // Eventhough Canon is not able to fax.
            // It need to implement this method.
            throw new NotImplementedException();
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
