using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Abstract;
using Entities;

namespace DAL.Impl
{
    public class DriverRepository : IDriverRepository
    {
        UnitOfWork UoW = new UnitOfWork();
        public void Create(DriverE obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DriverE> GetAll()
        {
            return UoW.DeliveryData.Drivers.ToList();
        }

        public DriverE Read()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(DriverE obj)
        {
            throw new NotImplementedException();
        }
    }
}
