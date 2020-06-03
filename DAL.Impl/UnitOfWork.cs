using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Impl
{
    public class UnitOfWork
    {
        DeliveryData deliveryData = new DeliveryData();
        public DeliveryData DeliveryData
        {
            get { return deliveryData; }
        }
    }
}
