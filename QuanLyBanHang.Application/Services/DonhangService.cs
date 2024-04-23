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
    public class DonhangService : IDonhangService
    {
        private readonly IDonhangRepositories donhang;
        private readonly IMapper mapper;
        public DonhangService(IDonhangRepositories donhang, IMapper mapper)
        {
            this.donhang = donhang;
            this.mapper = mapper;
        }

        
        public bool AddDonhang(DonhangDTO dto)
        {
            return donhang.Add(mapper.Map<Donhang>(dto));
        }

        public bool DeleteDonhang(int id)
        {
            return donhang.Delete(id);
        }

        public List<DonhangDTO> GetAllDonhang()
        {
            return mapper.Map<List<DonhangDTO>>(donhang.GetAll());
        }

        public DonhangDTO GetDonhangById(int id)
        {
            return mapper.Map<DonhangDTO>(donhang.GetEntity(id));
        }

        public bool UpdateDonhang(DonhangDTO dto)
        {
            return donhang.Update(mapper.Map<Donhang>(dto));
        }
    }
}
