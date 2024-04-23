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
    public class KhoService : IKhoService
    {
        private readonly IKhoRepositories kho;
        private readonly IMapper mapper;
        public KhoService(IKhoRepositories kho, IMapper mapper)
        {
            this.kho = kho;
            this.mapper = mapper;
        }

        public bool AddKho(KhoDTO dto)
        {
            dto.createdAt = DateTime.Now;
            return kho.Add(mapper.Map<Kho>(dto));
        }

        public bool DeleteKho(int id)
        {
            return kho.Delete(id);
        }

        public List<KhoDTO> GetAllKho()
        {
            return mapper.Map<List<KhoDTO>>(kho.GetAll());
        }

        public KhoDTO GetKhoById(int id)
        {
            return mapper.Map<KhoDTO>(kho.GetEntity(id));
        }

        public bool UpdateKho(KhoDTO dto)
        {
            dto.updatedAt = DateTime.Now;
            return kho.Update(mapper.Map<Kho>(dto));
        }
    }
}
