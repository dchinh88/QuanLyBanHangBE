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
            dto.updatedAt = null;
            dto.deletedAt = null;
            return kho.Add(mapper.Map<Kho>(dto));
        }

        public bool DeleteKho(int id)
        {
            return kho.Delete(id);
        }

        public List<KhoDTO> GetAllKho_NoQuery()
        {
            return mapper.Map<List<KhoDTO>>(kho.GetAll());
        }

        public PageListResult<KhoDTO> GetAllKho(KhoQuery query)
        {
            int begin = (query.page * query.limit) - query.limit;
            var list = mapper.Map<List<KhoDTO>>(kho.GetAll());

            var result = new PageListResult<KhoDTO>();
            result.items = list.Skip(begin).Take(query.limit).ToList();
            result.totalItems = list.Count();
            return result;
        }

        public KhoDTO GetKhoById(int id)
        {
            return mapper.Map<KhoDTO>(kho.GetEntity(id));
        }

        public bool UpdateKho(KhoDTO dto)
        {
            dto.updatedAt = DateTime.Now;
            dto.deletedAt = null;
            return kho.Update(mapper.Map<Kho>(dto));
        }
    }
}
