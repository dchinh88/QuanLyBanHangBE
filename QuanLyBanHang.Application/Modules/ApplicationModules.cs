using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using QuanLyBanHang.Application.Interface;
using QuanLyBanHang.Application.Interface.IAuthentication;
using QuanLyBanHang.Application.Mapping;
using QuanLyBanHang.Application.Services;
using QuanLyBanHang.Application.Services.Authentication;
using QuanLyBanHang.Infrastructure.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Application.Modules
{
    public static class ApplicationModules
    {
        public static IServiceCollection AddApplicationModules(this IServiceCollection services)
        {
            services.AddInfrastructure();
            var mapperConfig = new MapperConfiguration(mapperConfig =>
            {
                mapperConfig.AddProfile(new MappingProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddScoped<IChitietdonhangService, ChitietdonhangService>();
            services.AddScoped<IChitietphieumuahangService, ChitietphieumuahangService>();
            services.AddScoped<ICongnocuakhachhangService, CongnocuakhachhangService>();
            services.AddScoped<ICongnovoinhacungcapService, CongnovoinhacungcapService>();
            services.AddScoped<IDonhangService, DonhangService>();
            services.AddScoped<IKhachhangService, KhachhangService>();
            services.AddScoped<IKhoService, KhoService>();
            services.AddScoped<ILoaisanphamService, LoaisanphamService>();
            services.AddScoped<INhacungcapService, NhacungcapService>();
            services.AddScoped<INhanvienService, NhanvienService>();
            services.AddScoped<IPhieumuahangService, PhieumuahangService>();
            services.AddScoped<ISanPhamService, SanphamService>();
            services.AddScoped<ITinhtrangService, TinhtrangService>();

            /*services.AddScoped<IAccountService, AccountService>();*/
            services.AddScoped<IAccountService, AccountService>();
            return services;
        }
    }
}
