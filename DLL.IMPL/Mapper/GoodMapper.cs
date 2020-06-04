﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using M;

namespace BLL.IMPL.Mapper
{
    public class GoodMapper
    {
        public GoodE GoodDTO2E(GoodDTO good)
        {
            return new GoodE { ID = good.ID, Name = good.Name, ExecutionTime = good.ExecutionTime };
        }
        public GoodDTO GoodE2DTO (GoodE good)
        {
            return new GoodDTO { ID = good.ID, Name = good.Name, ExecutionTime = good.ExecutionTime };
        }
    }
}
