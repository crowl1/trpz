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
        public void Create(OrderE obj)
        {
            context.Orders.Add(obj);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderE> GetAll()
        {
            return context.Orders.ToList();
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
