using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using M;

namespace BLL.IMPL.Mapper
{
    public class ManagerMapper
    {
        public ManagerE ManagerDTO2E(ManagerDTO Manager)
        {
            return new ManagerE { ID = Manager.ID, Name = Manager.Name, ExecutionTime = Manager.ExecutionTime };
        }
        public ManagerDTO ManagerE2DTO (ManagerE Manager)
        {
            return new ManagerDTO { ID = Manager.ID, Name = Manager.Name, ExecutionTime = Manager.ExecutionTime };
        }
    }
}
