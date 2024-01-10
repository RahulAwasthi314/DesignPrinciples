using LiskovSubstitution._3_Solution.Interface;

namespace LiskovSubstitution._3_Solution.Abstract
{
    internal abstract class Employee : IEmployee, IEmployeeBonus
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee()
        {
            
        }
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract decimal CalculateBonus(decimal salary);

        public abstract decimal GetMinimumSalary();
    }
}
