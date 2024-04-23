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
            return khachhang.Add(mapper.Map<Khachhang>(dto));
        }

        public bool DeleteKhachhang(int id)
        {
            return khachhang.Delete(id);
        }

        public List<KhachhangDTO> GetAllKhachhang()
        {
            return mapper.Map<List<KhachhangDTO>>(khachhang.GetAll());
        }

        public KhachhangDTO GetKhachhangById(int id)
        {
            return mapper.Map<KhachhangDTO>(khachhang.GetEntity(id));
        }

        public bool UpdateKhachhang(KhachhangDTO dto)
        {
            dto.updatedAt = DateTime.Now;
            return khachhang.Update(mapper.Map<Khachhang>(dto));
        }
    }
}
