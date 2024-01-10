using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion._1_design
{
    internal class BusinessLayer
    {
        private readonly DataAccessLayer _dal;
        public BusinessLayer() 
        {
            _dal = new DataAccessLayer();
        }

        public void Save(object obj)
        {
            _dal.Save(obj);
        }
    }
}
