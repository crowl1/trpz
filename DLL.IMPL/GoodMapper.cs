using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using M;

namespace BLL.IMPL
{
    public class GoodMapper
    {
        public GoodE GoodDTO2GoodE(GoodDTO good)
        {
            return new GoodE { ID = good.ID, Name = good.Name, ExecutionTime = good.ExecutionTime };
        }
    }
}
