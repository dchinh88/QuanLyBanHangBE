using Microsoft.Extensions.DependencyInjection;
using QuanLyBanHang.Domain.Repositories;
using QuanLyBanHang.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Infrastructure.Modules
{
    public static class InfrastructureModules
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IChitietdonhangRepositories, ChitietdonhangRepositories>();
            services.AddScoped<IChitietphieumuahangRepositories, ChitietphieumuahangRepositories>();
            services.AddScoped<ICongnocuakhachhangRepositories, CongnocuakhachhangRepositories>();
            services.AddScoped<ICongnovoinhacungcapRepositories, CongnovoinhacungcapRepositories>();
            services.AddScoped<IDonhangRepositories, DonhangRepositories>();
            services.AddScoped<IKhachhangRepositories, KhachhangRepositories>();
            services.AddScoped<IKhoRepositories, KhoRepositories>();
            services.AddScoped<ILoaisanphamRepositories, LoaisanphamRepositories>();
            services.AddScoped<INhacungcapRepositories, NhacungcapRepositories>();
            services.AddScoped<INhanvienRepositories, NhanvienRepositories>();
            services.AddScoped<IPhieumuahangRepositories, PhieumuahangRepositories>();
            services.AddScoped<ISanphamRepositories, SanphamRepositories>();
            services.AddScoped<ITinhtrangRepositories, TinhtrangRepositories>();
            return services;
        }
    }
}
