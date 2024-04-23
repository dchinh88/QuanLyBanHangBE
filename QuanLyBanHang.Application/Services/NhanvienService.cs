using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLyBanHang.Application.DTO;
using QuanLyBanHang.Application.Interface;
using QuanLyBanHang.Domain.Entities;
using QuanLyBanHang.Domain.Repositories;
using QuanLyBanHang.Application.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace QuanLyBanHang.Application.Services
{
    public class NhanvienService : INhanvienService
    {
        private readonly INhanvienRepositories nhanvien;
        private readonly IMapper mapper;
        public NhanvienService(INhanvienRepositories nhanvien, IMapper mapper)
        {
            this.nhanvien = nhanvien;
            this.mapper = mapper;
        }

        public bool AddNhanvien(NhanvienDTO dto)
        {
            SHA256 hash = SHA256.Create();
            if (dto.Matkhau == null) return false;
            dto.Matkhau = HashPassword.GetHash(hash, dto.Matkhau);

            dto.createdAt = DateTime.Now;
            return nhanvien.Add(mapper.Map<Nhanvien>(dto));
        }

        public bool DeleteNhanvien(int id)
        {
            return nhanvien.Delete(id);
        }

        public List<NhanvienDTO> GetAllNhanvien()
        {
            return mapper.Map<List<NhanvienDTO>>(nhanvien.GetAll());
        }

        public NhanvienDTO GetNhanvienById(int id)
        {
            return mapper.Map<NhanvienDTO>(nhanvien.GetEntity(id));
        }

        public bool UpdateNhanvien(NhanvienDTO dto)
        {
            SHA256 hash = SHA256.Create();
            if (dto.Matkhau == null) return false;
            dto.Matkhau = HashPassword.GetHash(hash, dto.Matkhau);

            dto.updatedAt = DateTime.Now;
            return nhanvien.Update(mapper.Map<Nhanvien>(dto));
        }

        public bool SoftDelete(NhanvienDTO dto)
        {
            dto.deletedAt = DateTime.Now;
            return nhanvien.Update(mapper.Map<Nhanvien>(dto));
        }
    }
}
