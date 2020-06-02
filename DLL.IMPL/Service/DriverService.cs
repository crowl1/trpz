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
    class DriverService
    {
        DriverMapper _driverMapper = new DriverMapper();
        IDriverRepository _driverRepository = new DriverRepository();


        public void Create(DriverDTO obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DriverDTO> GetAll()
        {
            List<DriverDTO> NewAviaries = new List<DriverDTO>();
            foreach (var item in _driverRepository.GetAll())
            NewAviaries.Add(_driverMapper.DriverE2DriverDTO(item));
            return NewAviaries;
        }

        public DriverDTO Read()
        {
            throw new NotImplementedException();
        }

        public void Update(DriverDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
