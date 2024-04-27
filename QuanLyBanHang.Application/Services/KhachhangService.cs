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
    public class KhachhangService : IKhachhangService
    {
        private readonly IKhachhangRepositories khachhang;
        private readonly IMapper mapper;
        public KhachhangService(IKhachhangRepositories khachhang, IMapper mapper)
        {
            this.khachhang = khachhang;
            this.mapper = mapper;
        }

        public bool AddKhachhang(KhachhangDTO dto)
        {
            dto.createdAt = DateTime.Now;
            dto.updatedAt = null;
            dto.deletedAt = null;
            return khachhang.Add(mapper.Map<Khachhang>(dto));
        }

        public bool DeleteKhachhang(int id)
        {
            return khachhang.Delete(id);
        }

        public List<KhachhangDTO> GetAllKhachhang_NoQuery()
        {
            return mapper.Map<List<KhachhangDTO>>(khachhang.GetAll());
        }

        public PageListResult<KhachhangDTO> GetAllKhachhang(KhachhangQuery query)
        {
            int begin = (query.page * query.limit) - query.limit;
            var list = mapper.Map<List<KhachhangDTO>>(khachhang.GetAll());

            var result = new PageListResult<KhachhangDTO>();
            result.items = list.Skip(begin).Take(query.limit).ToList();
            result.totalItems = list.Count();
            return result;
        }

        public KhachhangDTO GetKhachhangById(int id)
        {
            return mapper.Map<KhachhangDTO>(khachhang.GetEntity(id));
        }

        public bool UpdateKhachhang(KhachhangDTO dto)
        {
            dto.updatedAt = DateTime.Now;
            dto.deletedAt = null;
            return khachhang.Update(mapper.Map<Khachhang>(dto));
        }
    }
}
