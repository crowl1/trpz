using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.IMPL.Mapper
{
    internal interface IMapper<TModel, TEntity>
    {
        TModel MapTo(TEntity data);
        TEntity MapFrom(TModel data);
    }
}
