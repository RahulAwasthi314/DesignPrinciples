using LiskovSubstitution._3_Solution.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution._3_Solution.Implementation
{
    internal class TemporaryEmployee : Employee
    {
        public override decimal CalculateBonus(decimal salary)
        {
            return (salary * 0.05M);
        }

        public override decimal GetMinimumSalary()
        {
            return 400;
        }
    }
}
