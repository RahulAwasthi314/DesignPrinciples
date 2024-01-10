using OpenClosed._3_Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution._2_MaintenanceProblem
{
    internal class ContractEmployee : Employee
    {
        // this class now voilate the Liskov Principle.
        public override decimal CalculateBonus(decimal salary)
        {
            throw new NotImplementedException();
        }
    }
}
