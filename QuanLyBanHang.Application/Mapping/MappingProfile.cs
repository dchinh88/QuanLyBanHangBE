using AutoMapper;
using QuanLyBanHang.Application.DTO;
using QuanLyBanHang.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Chitietdonhang, ChitietdonhangDTO>().ReverseMap();
            CreateMap<Chitietphieumuahang, ChitietphieumuahangDTO>().ReverseMap();
            CreateMap<Congnocuakhachhang, CongnocuakhachhangDTO>().ReverseMap();
            CreateMap<Congnovoinhacungcap, CongnovoinhacungcapDTO>().ReverseMap();
            CreateMap<Donhang, DonhangDTO>().ReverseMap();
            CreateMap<Khachhang, KhachhangDTO>().ReverseMap();
            CreateMap<Kho, KhoDTO>().ReverseMap();
            CreateMap<Loaisanpham, LoaisanphamDTO>().ReverseMap();
            CreateMap<Nhacungcap, NhacungcapDTO>().ReverseMap();   
            CreateMap<Nhanvien, NhanvienDTO>().ReverseMap();
            CreateMap<Phieumuahang, PhieumuahangDTO>().ReverseMap();    
            CreateMap<Sanpham, SanphamDTO>().ReverseMap();  
            CreateMap<Tinhtrang, TinhtrangDTO>().ReverseMap();

        }

    }
}
