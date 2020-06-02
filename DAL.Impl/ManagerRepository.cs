using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Abstract;
using Entities;

namespace DAL.Impl
{
    public class ManagerRepository : IManagerRepository
    {
        UnitOfWork UoW = new UnitOfWork();
        public void Create(ManagerE obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ManagerE> GetAll()
        {
            return UoW.DeliveryData.Managers.ToList();
        }

        public ManagerE Read()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(ManagerE obj)
        {
            throw new NotImplementedException();
        }
    }
}
