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
    public class NhacungcapService : INhacungcapService
    {
        private readonly INhacungcapRepositories nhacungcap;
        private readonly IMapper mapper;
        public NhacungcapService(INhacungcapRepositories nhacungcap, IMapper mapper)
        {
            this.nhacungcap = nhacungcap;
            this.mapper = mapper;
        }

        public bool AddNhacungcap(NhacungcapDTO dto)
        {
            dto.createdAt = DateTime.Now;
            return nhacungcap.Add(mapper.Map<Nhacungcap>(dto));
        }

        public bool DeleteNhacungcap(int id)
        {
            return nhacungcap.Delete(id);
        }

        public List<NhacungcapDTO> GetAllNhacungcap_NoQuery()
        {
            return mapper.Map<List<NhacungcapDTO>>(nhacungcap.GetAll());
        }

        public PageListResult<NhacungcapDTO> GetAllNhacungcap(NhacungcapQuery query)
        {
            int begin = (query.page * query.limit) - query.limit;
            var list = mapper.Map<List<NhacungcapDTO>>(nhacungcap.GetAll());

            var result = new PageListResult<NhacungcapDTO>();
            result.items = list.Skip(begin).Take(query.limit).ToList();
            result.totalItems = list.Count();
            return result;
        }

        public NhacungcapDTO GetNhacungcapById(int id)
        {
            return mapper.Map<NhacungcapDTO>(nhacungcap.GetEntity(id));
        }

        public bool UpdateNhacungcap(NhacungcapDTO dto)
        {
            dto.updatedAt = DateTime.Now;
            return nhacungcap.Update(mapper.Map<Nhacungcap>(dto));
        }
    }
}
