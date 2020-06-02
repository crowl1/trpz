using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Abstract;
using Entities;

namespace DAL.Impl
{
    public class StorageRepository : IStorageRepository
    {
        UnitOfWork UoW = new UnitOfWork();
        public void Create(StorageE obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StorageE> GetAll()
        {
            return UoW.DeliveryData.Storages.ToList();
        }

        public StorageE Read()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(StorageE obj)
        {
            throw new NotImplementedException();
        }
    }
}
