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
    public class ChitietdonhangService : IChitietdonhangService
    {
        private readonly IChitietdonhangRepositories chitietdonhang;
        private readonly IMapper mapper;
        public ChitietdonhangService(IChitietdonhangRepositories chitietdonhang, IMapper mapper)
        {
            this.chitietdonhang = chitietdonhang;
            this.mapper = mapper;
        }

        public bool AddChitietdonhang(ChitietdonhangDTO dto)
        {
            dto.createdAt = DateTime.Now;
            return chitietdonhang.Add(mapper.Map<Chitietdonhang>(dto));
        }

        public bool DeleteChitietdonhang(int id)
        {
            return chitietdonhang.Delete(id);
        }

        public List<ChitietdonhangDTO> GetAllChitietdonhang()
        {
            return mapper.Map<List<ChitietdonhangDTO>>(chitietdonhang.GetAll());
        }

        public ChitietdonhangDTO GetChitietdonhangById(int id)
        {
            return mapper.Map<ChitietdonhangDTO>(chitietdonhang.GetEntity(id));
        }

        public bool UpdateChitietdonhang(ChitietdonhangDTO dto)
        {
            dto.updatedAt = DateTime.Now;
            return chitietdonhang.Update(mapper.Map<Chitietdonhang>(dto));
        }
    }
}
