using AutoMapper;
using QuanLyBanHang.Application.Common;
using QuanLyBanHang.Application.DTO;
using QuanLyBanHang.Application.Interface;
using QuanLyBanHang.Application.Query;
using QuanLyBanHang.Domain.Entities;
using QuanLyBanHang.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Application.Services
{
    public class CongnocuakhachhangService : ICongnocuakhachhangService
    {
        private readonly ICongnocuakhachhangRepositories congnocuakhachhang;
        private readonly IMapper mapper;
        public CongnocuakhachhangService(ICongnocuakhachhangRepositories congnocuakhachhang, IMapper mapper)
        {
            this.congnocuakhachhang = congnocuakhachhang;
            this.mapper = mapper;
        }

        public bool AddCongnocuakhachhang(CongnocuakhachhangDTO dto)
        {
            dto.createdAt = DateTime.Now;
            return congnocuakhachhang.Add(mapper.Map<Congnocuakhachhang>(dto));
        }

        public bool DeleteCongnocuakhachhang(int id)
        {
            return congnocuakhachhang.Delete(id);
        }

        public List<CongnocuakhachhangDTO> GetAllCongnocuakhachhang_NoQuery()
        {
            return mapper.Map<List<CongnocuakhachhangDTO>>(congnocuakhachhang.GetAll());
        }

        public PageListResult<CongnocuakhachhangDTO> GetAllCongnocuakhachhang(CongnocuakhachhangQuery query)
        {
            int begin = (query.page * query.limit) - query.limit;
            var list = mapper.Map<List<CongnocuakhachhangDTO>>(congnocuakhachhang.GetAll());

            var result = new PageListResult<CongnocuakhachhangDTO>();
            result.items = list.Skip(begin).Take(query.limit).ToList();
            result.totalItems = list.Count();
            return result;
        }

        public CongnocuakhachhangDTO GetCongnocuakhachhangById(int id)
        {
            return mapper.Map<CongnocuakhachhangDTO>(congnocuakhachhang.GetEntity(id));
        }

        public bool UpdateCongnocuakhachhang(CongnocuakhachhangDTO dto)
        {
            dto.updatedAt = DateTime.Now;
            return congnocuakhachhang.Update(mapper.Map<Congnocuakhachhang>(dto));
        }
    }
}
