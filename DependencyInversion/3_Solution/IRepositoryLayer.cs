using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion._3_Solution
{
    internal interface IRepositoryLayer
    {
        void Save(object obj);
    }
}
