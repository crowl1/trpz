using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M;

namespace DAL.Repository
{
    public class DeliveryData : DbContext
    {
        public DeliveryData() : base(ConfigurationManager.ConnectionStrings["DataBaseConnection"].ConnectionString)
        {
        }

        public DbSet<OrderDTO> Orders { get; set; }
        public DbSet<StorageDTO> Storages{ get; set; }
        public DbSet<ManagerDTO> Managers{ get; set; }
        public DbSet<GoodDTO> Goods{ get; set; }
        public DbSet<DriverDTO> Drivers{ get; set; }
    }
}
