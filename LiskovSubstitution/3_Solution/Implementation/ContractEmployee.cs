using LiskovSubstitution._3_Solution.Abstract;
using LiskovSubstitution._3_Solution.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution._3_Solution.Implementation
{
    internal class ContractEmployee : IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ContractEmployee()
        {
            
        }

        public ContractEmployee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public decimal GetMinimumSalary()
        {
            return 5000;
        }
    }
}
