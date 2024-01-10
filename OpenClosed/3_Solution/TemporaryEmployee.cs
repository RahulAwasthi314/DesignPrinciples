using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed._3_Solution
{
    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee()
        {

        }
        public TemporaryEmployee(int id, string name) : base(id, name)
        {

        }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }

        public override string ToString()
        {
            return string.Format($"ID : {this.Id} Name : {this.Name} Type: Temporary");
        }
    }
}
