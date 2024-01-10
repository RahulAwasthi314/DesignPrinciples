using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion._3_Solution
{
    internal class BusinessLayer
    {
        private readonly IRepositoryLayer _repositoryLayer;

        public BusinessLayer(IRepositoryLayer repositoryLayer)
        {
            _repositoryLayer = repositoryLayer;
        }

        public void Save(object obj)
        {
            _repositoryLayer.Save(obj);
        }
    }
}
