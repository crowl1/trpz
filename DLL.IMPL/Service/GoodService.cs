using BLL.IMPL.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Abstract;
using DAL.Impl;
using M;

namespace DLL.IMPL.Service
{
    class GoodService
    {
        GoodMapper goodMapper = new GoodMapper();
        IGoodRepository goodRepository = new GoodRepository();


        public void Create(GoodDTO obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GoodDTO> GetAll()
        {
            List<GoodDTO> NewAviaries = new List<GoodDTO>();
            foreach (var item in goodRepository.GetAll())
            NewAviaries.Add(goodMapper.GoodE2GoodDTO(item));
            return NewAviaries;
        }

        public GoodDTO Read()
        {
            throw new NotImplementedException();
        }

        public void Update(GoodDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
