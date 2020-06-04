using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract
{
    public interface IGenericService<T>
    {
        void Create(T obj);
        void Update(T obj);
        void Delete(int id);
        T Read();
        IEnumerable<T> GetAll();
    }
}
