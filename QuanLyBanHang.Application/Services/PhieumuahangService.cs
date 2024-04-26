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
    public class PhieumuahangService : IPhieumuahangService
    {
        private readonly IPhieumuahangRepositories phieumuahang;
        private readonly IMapper mapper;
        public PhieumuahangService(IPhieumuahangRepositories phieumuahang, IMapper mapper)
        {
            this.phieumuahang = phieumuahang;
            this.mapper = mapper;
        }

        public bool AddPhieumuahang(PhieumuahangDTO dto)
        {
            dto.createdAt = DateTime.Now;
            return phieumuahang.Add(mapper.Map<Phieumuahang>(dto));
        }

        public bool DeletePhieumuahang(int id)
        {
            return phieumuahang.Delete(id);
        }

        public List<PhieumuahangDTO> GetAllPhieumuahang_NoQuery()
        {
            return mapper.Map<List<PhieumuahangDTO>>(phieumuahang.GetAll());
        }

        public PageListResult<PhieumuahangDTO> GetAllPhieumuahang(PhieumuahangQuery query)
        {
            int begin = (query.page * query.limit) - query.limit;
            var list = mapper.Map<List<PhieumuahangDTO>>(phieumuahang.GetAll());

            var result = new PageListResult<PhieumuahangDTO>();
            result.items = list.Skip(begin).Take(query.limit).ToList();
            result.totalItems = list.Count();
            return result;
        }

        public PhieumuahangDTO GetPhieumuahangById(int id)
        {
            return mapper.Map<PhieumuahangDTO>(phieumuahang.GetEntity(id));
        }

        public bool UpdatePhieumuahang(PhieumuahangDTO dto)
        {
            dto.updatedAt = DateTime.Now;
            return phieumuahang.Update(mapper.Map<Phieumuahang>(dto));
        }
    }
}
