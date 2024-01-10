using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed._2_MaintenanceProblem
{
    internal class UpdatedEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmployeeType { get; set; }

        public UpdatedEmployee()
        {

        }
        public UpdatedEmployee(int id, string name, string employeeType)
        {
            this.Id = id;
            this.Name = name;
            EmployeeType = employeeType;
        }
        public decimal CalculateBonus(decimal salary, string employeeType)
        {
            if (EmployeeType == "Permanent")
                return salary * .1M;
            else
                return salary * .05M;

        }
        public override string ToString()
        {
            return string.Format($"ID : {this.Id} Name : {this.Name} Type : {this.EmployeeType}");
        }
    }
}
