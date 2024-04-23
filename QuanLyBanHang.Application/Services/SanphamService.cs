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
    public class SanphamService : ISanPhamService
    {
        private readonly ISanphamRepositories sanpham;
        private readonly IMapper mapper;
        public SanphamService(ISanphamRepositories sanpham, IMapper mapper)
        {
            this.sanpham = sanpham;
            this.mapper = mapper;
        }

        
        public bool AddSanpham(SanphamDTO dto)
        {
            return sanpham.Add(mapper.Map<Sanpham>(dto));
        }

        public bool DeleteSanpham(int id)
        {
           return sanpham.Delete(id);
        }

        public List<SanphamDTO> GetAllSanpham()
        {
            return mapper.Map<List<SanphamDTO>>(sanpham.GetAll());
        }

        public SanphamDTO GetSanphamById(int id)
        {
            return mapper.Map<SanphamDTO>(sanpham.GetEntity(id));
        }

        public bool UpdateSanpham(SanphamDTO dto)
        {
            return sanpham.Update(mapper.Map<Sanpham>(dto));
        }
    }
}
