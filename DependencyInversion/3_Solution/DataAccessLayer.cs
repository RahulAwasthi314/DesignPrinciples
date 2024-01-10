using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion._3_Solution
{
    internal class DataAccessLayer : IRepositoryLayer
    {
        public void Save(object obj)
        {
            Console.WriteLine("Save.. ");
        }
    }
}
