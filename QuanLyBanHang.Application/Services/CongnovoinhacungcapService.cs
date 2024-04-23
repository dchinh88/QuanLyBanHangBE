using AutoMapper;
using QuanLyBanHang.Application.DTO;
using QuanLyBanHang.Application.Interface;
using QuanLyBanHang.Domain.Entities;
using QuanLyBanHang.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Application.Services
{
    public class CongnovoinhacungcapService : ICongnovoinhacungcapService
    {
        private readonly ICongnovoinhacungcapRepositories congnovoinhacungcap;
        private readonly IMapper mapper;
        public CongnovoinhacungcapService(ICongnovoinhacungcapRepositories congnovoinhacungcap, IMapper mapper)
        {
            this.congnovoinhacungcap = congnovoinhacungcap;
            this.mapper = mapper;
        }

        public bool AddCongnovoinhacungcap(CongnovoinhacungcapDTO dto)
        {
            dto.createdAt = DateTime.Now;
            return congnovoinhacungcap.Add(mapper.Map<Congnovoinhacungcap>(dto));
        }

        public bool DeleteCongnovoinhacungcap(int id)
        {
            return congnovoinhacungcap.Delete(id);
        }

        public List<CongnovoinhacungcapDTO> GetAllCongnovoinhacungcap()
        {
            return mapper.Map<List<CongnovoinhacungcapDTO>>(congnovoinhacungcap.GetAll());
        }

        public CongnovoinhacungcapDTO GetCongnovoinhacungcapById(int id)
        {
            return mapper.Map<CongnovoinhacungcapDTO>(congnovoinhacungcap.GetEntity(id));
        }

        public bool UpdateCongnovoinhacungcap(CongnovoinhacungcapDTO dto)
        {
            dto.updatedAt = DateTime.Now;
            return congnovoinhacungcap.Update(mapper.Map<Congnovoinhacungcap>(dto));
        }
    }
}
