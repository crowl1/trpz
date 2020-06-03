using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Abstract;
using Entities;
using System.Data.Entity;

namespace DAL.Impl
{
    public class OrderRepository : IOrderRepository
    {
        DeliveryData context = new DeliveryData();
        UnitOfWork UoW = new UnitOfWork();
        public void Create(OrderE obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderE> GetAll()
        {
            var a = context.Orders.Include(p => p.StorageID).Include(o => o.GoodID).ToList();
            return a;
            //return UoW.DeliveryData.Orders.Include(p => p.Storage).Include(o => o.Good).ToList();
        }

        public OrderE Read()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(OrderE obj)
        {
            throw new NotImplementedException();
        }
    }
}
