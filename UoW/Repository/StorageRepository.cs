using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepository;
using M;

namespace DAL.Repository
{
    public class StorageRepository : GenericRepository<StorageDTO>, IStorageRepository
    {
        public StorageRepository(DeliveryData context) : base(context)
        {

        }
    }
}
