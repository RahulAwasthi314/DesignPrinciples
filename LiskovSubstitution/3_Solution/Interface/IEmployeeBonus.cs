using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution._3_Solution.Interface
{
    internal interface IEmployeeBonus
    {
        decimal CalculateBonus(decimal salary);
    }
}
