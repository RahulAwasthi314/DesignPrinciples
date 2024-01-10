using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion._1_design
{
    internal class DataAccessLayer
    {
        private readonly object _databaseObject;

        public void Save(object details)
        {
            // perform save
            Console.WriteLine("Saving the data");
        }
    }
}
