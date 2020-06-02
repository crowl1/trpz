using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Abstract;
using Entities;

namespace DAL.Impl
{
    public class GoodRepository : IGoodRepository
    {
        UnitOfWork UoW = new UnitOfWork();
        public void Create(GoodE obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GoodE> GetAll()
        {
            return UoW.DeliveryData.Goods.ToList();
        }

        public GoodE Read()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(GoodE obj)
        {
            throw new NotImplementedException();
        }
    }
}
