using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepository;
using DAL.Repository;
using Entities;
using M;

namespace BLL.IMPL
{
    public class OrderMapper
    {
        GoodMapper goodMapper = new GoodMapper();
        StorageMapper storageMapper = new StorageMapper();

        public OrderDTO OrderE2OrderDTO (OrderE order)
        {
            return new OrderDTO { ID = order.ID, NameCustomer = order.NameCustomer, TimeLeft = order.TimeLeft, GoodIN = goodMapper.GoodE2GoodDTO(order.GoodID), StorageIN = storageMapper.StorageE2StorageDTO(order.StorageID) };
        }

        public OrderE OrderDTO2OrderE(OrderDTO order)
        {
            return new OrderE { ID = order.ID, NameCustomer = order.NameCustomer, TimeLeft = order.TimeLeft, GoodID = goodMapper.GoodDTO2GoodE(order.GoodIN), StorageID = storageMapper.StorageDTO2StorageE(order.StorageIN) };
        }
    }
}
