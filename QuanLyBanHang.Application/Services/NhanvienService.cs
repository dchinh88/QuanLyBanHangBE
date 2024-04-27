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
using QuanLyBanHang.Application.Common;
using QuanLyBanHang.Application.Query;

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
            dto.updatedAt = null;
            dto.deletedAt = null;
            return nhanvien.Add(mapper.Map<Nhanvien>(dto));
        }

        public bool DeleteNhanvien(int id)
        {
            return nhanvien.Delete(id);
        }

        public List<NhanvienDTO> GetAllNhanvien_NoQuery()
        {
            return mapper.Map<List<NhanvienDTO>>(nhanvien.GetAll());
        }
        public PageListResult<NhanvienDTO> GetAllNhanvien(NhanvienQuery? query)
        {
            int begin = (query.page * query.limit) - query.limit;
            var list = mapper.Map<List<NhanvienDTO>>(nhanvien.GetAll());
            /*if(query.keyWord != string.Empty)
            {
                list = list.Where(x => x.)
            }*/
            var resulteModel = new PageListResult<NhanvienDTO>();
            resulteModel.items = list.Skip(begin).Take(query.limit).ToList();
            resulteModel.totalItems = list.Count;
            return resulteModel;
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
            dto.deletedAt = null;
            return nhanvien.Update(mapper.Map<Nhanvien>(dto));
        }
    }
}
