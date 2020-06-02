using BLL.IMPL.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Abstract;
using DAL.Impl;
using M;
using BLL.Abstract;

namespace DLL.IMPL.Service
{
    public class OrderService: IOrderService
    {
        OrderMapper _orderMapper = new OrderMapper();
        IOrderRepository _orderRepository = new OrderRepository();


        public void Create(OrderDTO obj)
        {
            _orderRepository.Create(_orderMapper.OrderDTO2OrderE(obj));
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDTO> GetAll()
        {
            List<OrderDTO> NewAviaries = new List<OrderDTO>();
            foreach (var item in _orderRepository.GetAll())
            NewAviaries.Add(_orderMapper.OrderE2OrderDTO(item));
            return NewAviaries;
        }

        public OrderDTO Read()
        {
            throw new NotImplementedException();
        }

        public void Update(OrderDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
