using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepository;
using M;

namespace DAL.Repository
{
    public class DriverRepository : GenericRepository<DriverDTO>, IDriverRepository
    {
        public DriverRepository(DeliveryData context) : base(context)
        {

        }
    }
}
