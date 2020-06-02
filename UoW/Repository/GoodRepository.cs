using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepository;
using M;

namespace DAL.Repository
{
    public class GoodRepository : GenericRepository<GoodDTO>, IGoodRepository
    {
        public GoodRepository(DeliveryData context) : base(context)
        {

        }
    }
}
