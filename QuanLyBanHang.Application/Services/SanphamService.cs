using AutoMapper;
using Microsoft.Identity.Client;
using QuanLyBanHang.Application.Common;
using QuanLyBanHang.Application.DTO;
using QuanLyBanHang.Application.Interface;
using QuanLyBanHang.Application.LinQModel;
using QuanLyBanHang.Application.Query;
using QuanLyBanHang.Domain.Entities;
using QuanLyBanHang.Domain.Repositories;
using QuanLyBanHang.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Application.Services
{
    public class SanphamService : ISanPhamService
    {
        private readonly ISanphamRepositories sanpham;
        private readonly IMapper mapper;
  
        private readonly QlkinhdoanhContext context;
        public SanphamService(ISanphamRepositories sanpham, IMapper mapper, QlkinhdoanhContext context)
        {
            this.sanpham = sanpham;
            this.mapper = mapper;
            this.context = context;
        }

        
        public bool AddSanpham(SanphamDTO dto)
        {
            dto.createdAt = DateTime.Now;
            dto.updatedAt = null;
            dto.deletedAt = null;
            return sanpham.Add(mapper.Map<Sanpham>(dto));
        }

        public bool DeleteSanpham(int id)
        {
           return sanpham.Delete(id);
        }

        public List<SanphamDTO> GetAllSanpham_NoQuery()
        {
            return mapper.Map<List<SanphamDTO>>(sanpham.GetAll());
        }

        public PageListResult<SanphamDTO> GetAllSanpham(SanphamQuery query)
        {
            int begin = (query.page * query.limit) - query.limit;

            /*var data = from sp in sanpham.GetAll()
                       join lsp in loaisanpham.GetAll()
                       on sp.Loaisanphamid equals lsp.Id
                       join k in kho.GetAll()
                       on sp.Khoid equals k.Id
                       where sp.Deletedat == null &&
                       lsp.Deletedat == null && k.Deletedat == null
                       select new
                       {

                       };
            var list = data.ToList();*/
            var list = mapper.Map<List<SanphamDTO>>(sanpham.GetAll());

            var result = new PageListResult<SanphamDTO>();
            result.items = list.Skip(begin).Take(query.limit).ToList();
            result.totalItems = list.Count();
            return result;
        }

        public SanphamDTO GetSanphamById(int id)
        {
            return mapper.Map<SanphamDTO>(sanpham.GetEntity(id));
        }

        public bool UpdateSanpham(SanphamDTO dto)
        {
            dto.updatedAt = DateTime.Now;
            dto.deletedAt = null;
            return sanpham.Update(mapper.Map<Sanpham>(dto));
        }

        public List<SanphamDTO> GetSanphamByName(string name)
        {
            /*var sanpham = context.Sanphams.FirstOrDefault(n => n.Tensanpham == name);*/
            var sanpham = context.Sanphams.Where(n => n.Tensanpham.Contains(name)).ToList();
            if (sanpham == null)
            {
                return null;
            }
            return mapper.Map<List<SanphamDTO>>(sanpham);
        }

        public List<SanphamDTO> GetSanphamByIdLoaisanpham(int id)
        {
            var sanpham = context.Sanphams.Where(n => n.Loaisanphamid == id).ToList();
            if (sanpham == null)
            {
                return null;
            }
            return mapper.Map<List<SanphamDTO>>(sanpham);
        }

        public List<SanphamDTO> GetSanphamByIdKho(int id)
        {
            var sanpham = context.Sanphams.Where(n => n.Khoid == id).ToList();
            if(sanpham == null)
            {
                return null;
            }
            return mapper.Map<List<SanphamDTO>>(sanpham);
        }
    }
}
