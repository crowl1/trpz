using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using M;

namespace BLL.IMPL.Mapper
{
    public class OrderMapper
    {
        GoodMapper goodMapper = new GoodMapper();
        StorageMapper storageMapper = new StorageMapper();

        public OrderDTO OrderE2DTO (OrderE order)
        {
            return new OrderDTO { ID = order.ID, NameCustomer = order.NameCustomer, TimeLeft = order.TimeLeft, GoodIN = order.Good, StorageIN = order.Storage };
        }

        public OrderE OrderDTO2E(OrderDTO order)
        {
            return new OrderE { ID = order.ID, NameCustomer = order.NameCustomer, TimeLeft = order.TimeLeft, Good = order.GoodIN, Storage = order.StorageIN };
        }
    }
}
