using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using M;

namespace BLL.IMPL
{
    public class ManagerMapper
    {
        public ManagerE ManagerDTO2ManagerE(ManagerDTO Manager)
        {
            return new ManagerE { ID = Manager.ID, Name = Manager.Name, ExecutionTime = Manager.ExecutionTime };
        }
        public ManagerDTO ManagerE2ManagerDTO (ManagerE Manager)
        {
            return new ManagerDTO { ID = Manager.ID, Name = Manager.Name, ExecutionTime = Manager.ExecutionTime };
        }
    }
}
