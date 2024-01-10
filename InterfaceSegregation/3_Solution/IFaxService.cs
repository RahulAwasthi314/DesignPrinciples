using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation._3_Solution
{
    internal interface IFaxService
    {
        bool FaxContent(string content);
    }
}
