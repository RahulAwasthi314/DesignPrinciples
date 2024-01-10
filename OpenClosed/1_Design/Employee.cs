using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed._1_design
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee()
        {

        }
        public Employee(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
        public override string ToString()
        {
            return string.Format($"ID : {this.Id} Name : {this.Name}");
        }
    }
}
