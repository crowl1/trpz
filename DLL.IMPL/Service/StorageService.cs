using BLL.IMPL.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Abstract;
using DAL.Impl;
using M;
using BLL.Abstract;

namespace DLL.IMPL.Service
{
    public class StorageService: IStorageService
    {
        StorageMapper _storageMapper = new StorageMapper();
        IStorageRepository _storageRepository = new StorageRepository();


        public void Create(StorageDTO obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StorageDTO> GetAll()
        {
            List<StorageDTO> NewAviaries = new List<StorageDTO>();
            foreach (var item in _storageRepository.GetAll())
            NewAviaries.Add(_storageMapper.StorageE2StorageDTO(item));
            return NewAviaries;
        }

        public StorageDTO Read()
        {
            throw new NotImplementedException();
        }

        public void Update(StorageDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
