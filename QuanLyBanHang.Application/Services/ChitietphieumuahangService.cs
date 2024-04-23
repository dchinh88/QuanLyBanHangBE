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
    public class ChitietphieumuahangService : IChitietphieumuahangService
    {
        private readonly IChitietphieumuahangRepositories chitietphieumuahang;
        private readonly IMapper mapper;
        public ChitietphieumuahangService(IChitietphieumuahangRepositories chitietphieumuahang, IMapper mapper)
        {
            this.chitietphieumuahang = chitietphieumuahang;
            this.mapper = mapper;
        }

        public bool AddChitietphieumuahang(ChitietphieumuahangDTO dto)
        {
            dto.createdAt = DateTime.Now;
            return chitietphieumuahang.Add(mapper.Map<Chitietphieumuahang>(dto));
        }

        public bool DeleteChitietphieumuahang(int id)
        {
            return chitietphieumuahang.Delete(id);
        }

        public List<ChitietphieumuahangDTO> GetAllChitietphieumuahang()
        {
            return mapper.Map<List<ChitietphieumuahangDTO>>(chitietphieumuahang.GetAll());
        }

        public ChitietphieumuahangDTO GetChitietphieumuahangById(int id)
        {
            return mapper.Map<ChitietphieumuahangDTO>(chitietphieumuahang.GetEntity(id));
        }

        public bool UpdateChitietphieumuahang(ChitietphieumuahangDTO dto)
        {
            dto.updatedAt = DateTime.Now;
            return chitietphieumuahang.Update(mapper.Map<Chitietphieumuahang>(dto));
        }
    }
}
