using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        void Create(T obj);
        void Update(T obj);
        void Delete(int id);
        T Read();
        IEnumerable<T> GetAll();
    }
}
