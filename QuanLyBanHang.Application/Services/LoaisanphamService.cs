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
    public class LoaisanphamService : ILoaisanphamService
    {
        private readonly ILoaisanphamRepositories loaisanpham;
        private readonly IMapper mapper;
        public LoaisanphamService(ILoaisanphamRepositories loaisanpham, IMapper mapper)
        {
            this.loaisanpham = loaisanpham;
            this.mapper = mapper;
        }

        public bool AddLoaisanpham(LoaisanphamDTO dto)
        {
            dto.createdAt = DateTime.Now;
            return loaisanpham.Add(mapper.Map<Loaisanpham>(dto));
        }

        public bool DeleteLoaisanpham(int id)
        {
            return loaisanpham.Delete(id);
        }

        public List<LoaisanphamDTO> GetAllLoaisanpham()
        {
            return mapper.Map<List<LoaisanphamDTO>>(loaisanpham.GetAll());
        }

        public LoaisanphamDTO GetLoaisanphamById(int id)
        {
            return mapper.Map<LoaisanphamDTO>(loaisanpham.GetEntity(id));
        }

        public bool UpdateLoaisanpham(LoaisanphamDTO dto)
        {
            dto.updatedAt = DateTime.Now;
            return loaisanpham.Update(mapper.Map<Loaisanpham>(dto));
        }
    }
}
