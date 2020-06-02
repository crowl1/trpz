using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using M;

namespace BLL.IMPL.Mapper
{
    public class DriverMapper
    {
        public DriverE DriverDTO2DriverE(DriverDTO Driver)
        {
            return new DriverE { ID = Driver.ID, Name = Driver.Name, MpS = Driver.MpS, ReleaseTime = Driver.ReleaseTime};
        }
        public DriverDTO DriverE2DriverDTO (DriverE Driver)
        {
            return new DriverDTO { ID = Driver.ID, Name = Driver.Name, MpS = Driver.MpS, ReleaseTime = Driver.ReleaseTime };
        }
    }
}
