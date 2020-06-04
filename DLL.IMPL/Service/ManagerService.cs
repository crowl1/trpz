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
    public class ManagerService: IManagerService
    {
        ManagerMapper _managerMapper = new ManagerMapper();
        IManagerRepository _managerRepository = new ManagerRepository();


        public void Create(ManagerDTO obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ManagerDTO> GetAll()
        {
            List<ManagerDTO> NewOBJ = new List<ManagerDTO>();
            foreach (var item in _managerRepository.GetAll())
            NewOBJ.Add(_managerMapper.ManagerE2DTO(item));
            return NewOBJ;
        }

        public ManagerDTO Read()
        {
            throw new NotImplementedException();
        }

        public void Update(ManagerDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
