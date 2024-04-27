using AutoMapper;
using Microsoft.Extensions.ObjectPool;
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
    public class DonhangService : IDonhangService
    {
        private readonly IDonhangRepositories donhang;
        private readonly IMapper mapper;
        public DonhangService(IDonhangRepositories donhang, IMapper mapper)
        {
            this.donhang = donhang;
            this.mapper = mapper;
        }

        
        public bool AddDonhang(DonhangDTO dto)
        {
            dto.createdAt = DateTime.Now;
            dto.updatedAt = null;
            dto.deletedAt = null;
            return donhang.Add(mapper.Map<Donhang>(dto));
        }

        public bool DeleteDonhang(int id)
        {
            return donhang.Delete(id);
        }

        public List<DonhangDTO> GetAllDonhang_NoQuery()
        {
            return mapper.Map<List<DonhangDTO>>(donhang.GetAll());
        }

        public PageListResult<DonhangDTO> GetAllDonhang(DonhangQuery query)
        {
            int begin = (query.page * query.limit) - query.limit;
            var list = mapper.Map<List<DonhangDTO>>(donhang.GetAll());

            var result = new PageListResult<DonhangDTO>();
            result.items = list.Skip(begin).Take(query.limit).ToList();
            result.totalItems = list.Count();
            return result;
        }

        public DonhangDTO GetDonhangById(int id)
        {
            return mapper.Map<DonhangDTO>(donhang.GetEntity(id));
        }

        public bool UpdateDonhang(DonhangDTO dto)
        {
            dto.updatedAt = DateTime.Now;
            dto.deletedAt = null;
            return donhang.Update(mapper.Map<Donhang>(dto));
        }
    }
}
