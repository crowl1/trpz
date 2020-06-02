using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using M;

namespace DAL.Impl
{
    public class DeliveryData : DbContext
    {
        public DeliveryData() : base(ConfigurationManager.ConnectionStrings["DataBaseConnection"].ConnectionString)
        {
        }

        public DbSet<OrderE> Orders { get; set; }
        public DbSet<StorageE> Storages{ get; set; }
        public DbSet<ManagerE> Managers{ get; set; }
        public DbSet<GoodE> Goods{ get; set; }
        public DbSet<DriverE> Drivers{ get; set; }
    }
}
