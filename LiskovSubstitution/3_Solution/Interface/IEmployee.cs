using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution._3_Solution.Interface
{
    internal interface IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal GetMinimumSalary();
    }
}
