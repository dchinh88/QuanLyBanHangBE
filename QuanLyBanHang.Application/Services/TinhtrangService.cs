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
    public class TinhtrangService : ITinhtrangService
    {
        private readonly ITinhtrangRepositories tinhtrang;
        private readonly IMapper mapper;
        public TinhtrangService(ITinhtrangRepositories tinhtrang, IMapper mapper)
        {
            this.tinhtrang = tinhtrang;
            this.mapper = mapper;
        }

        public bool AddTinhtrang(TinhtrangDTO dto)
        {
            return tinhtrang.Add(mapper.Map<Tinhtrang>(dto));
        }

        public bool DeleteTinhtrang(int id)
        {
            return tinhtrang.Delete(id);
        }

        public List<TinhtrangDTO> GetAllTinhtrang()
        {
            return mapper.Map<List<TinhtrangDTO>>(tinhtrang.GetAll());
        }

        public TinhtrangDTO GetTinhtrangById(int id)
        {
            return mapper.Map<TinhtrangDTO>(tinhtrang.GetEntity(id));
        }

        public bool UpdateTinhtrang(TinhtrangDTO dto)
        {
            return tinhtrang.Update(mapper.Map<Tinhtrang>(dto));
        }
    }
}
