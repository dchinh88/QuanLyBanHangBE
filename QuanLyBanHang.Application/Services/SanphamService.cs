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
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Application.Services
{
    public class SanphamService : ISanPhamService
    {
        private readonly ISanphamRepositories sanpham;
        private readonly IMapper mapper;
        private readonly IKhoRepositories kho;
        private readonly ILoaisanphamRepositories loaisanpham;
        public SanphamService(ISanphamRepositories sanpham, IMapper mapper, IKhoRepositories kho, ILoaisanphamRepositories loaisanpham)
        {
            this.sanpham = sanpham;
            this.mapper = mapper;
            this.kho = kho;
            this.loaisanpham = loaisanpham;
        }

        
        public bool AddSanpham(SanphamDTO dto)
        {
            dto.createdAt = DateTime.Now;
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

            /* var data = from sp in sanpham.GetAll()
                        join lsp in loaisanpham.GetAll()
                        on sp.Loaisanphamid equals lsp.Id
                        join k in kho.GetAll()
                        on sp.Khoid equals k.Id
                        where sp.Deletedat == null &&
                        lsp.Deletedat == null && k.Deletedat == null
                        select new SanphamDTO
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
            return sanpham.Update(mapper.Map<Sanpham>(dto));
        }
    }
}
