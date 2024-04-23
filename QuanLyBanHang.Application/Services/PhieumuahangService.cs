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
    public class PhieumuahangService : IPhieumuahangService
    {
        private readonly IPhieumuahangRepositories phieumuahang;
        private readonly IMapper mapper;
        public PhieumuahangService(IPhieumuahangRepositories phieumuahang, IMapper mapper)
        {
            this.phieumuahang = phieumuahang;
            this.mapper = mapper;
        }

        public bool AddPhieumuahang(PhieumuahangDTO dto)
        {
            return phieumuahang.Add(mapper.Map<Phieumuahang>(dto));
        }

        public bool DeletePhieumuahang(int id)
        {
            return phieumuahang.Delete(id);
        }

        public List<PhieumuahangDTO> GetAllPhieumuahang()
        {
            return mapper.Map<List<PhieumuahangDTO>>(phieumuahang.GetAll());
        }

        public PhieumuahangDTO GetPhieumuahangById(int id)
        {
            return mapper.Map<PhieumuahangDTO>(phieumuahang.GetEntity(id));
        }

        public bool UpdatePhieumuahang(PhieumuahangDTO dto)
        {
            return phieumuahang.Update(mapper.Map<Phieumuahang>(dto));
        }
    }
}
