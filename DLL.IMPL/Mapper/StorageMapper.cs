using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using M;

namespace BLL.IMPL.Mapper
{
    public class StorageMapper
    {
        public StorageE StorageDTO2E(StorageDTO Storage)
        {
            return new StorageE { ID = Storage.ID, Name = Storage.Name, Distance = Storage.Distance };
        }
        public StorageDTO StorageE2DTO (StorageE Storage)
        {
            return new StorageDTO { ID = Storage.ID, Name = Storage.Name, Distance = Storage.Distance };
        }
    }
}
