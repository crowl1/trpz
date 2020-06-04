﻿using BLL.IMPL.Mapper;
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
    public class DriverService: IDriverService
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
            List<DriverDTO> NewOBJ = new List<DriverDTO>();
            foreach (var item in _driverRepository.GetAll())
            NewOBJ.Add(_driverMapper.DriverE2DTO(item));
            return NewOBJ;
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
