using CommonHelper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyBanHang.Application.Common;
using QuanLyBanHang.Application.DTO;
using QuanLyBanHang.Application.Interface;
using QuanLyBanHang.Application.Query;
using QuanLyBanHang.Application.Services;
using QuanLyBanHang.Infrastructure.Context;

namespace QuanLyBanHang.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    /*[Authorize]*/
    public class QLSanphamController : ControllerBase
    {
        private readonly ISanPhamService sanPhamService;
        private readonly QlkinhdoanhContext context;
        public QLSanphamController(ISanPhamService sanPhamService, QlkinhdoanhContext context)
        {
            this.sanPhamService = sanPhamService;
            this.context = context;
        }
        [HttpGet("GetAllSanpham")]
        /*[Authorize(Policy = "AdminPolicy")]*/
        public IActionResult GetALlSanpham_NoQuery()
        {
            return Ok(sanPhamService.GetAllSanpham_NoQuery());
        }

        [HttpGet]
        /*[Authorize(Policy = "AdminPolicy")]*/
        public IActionResult GetAllSanpham([FromQuery] SanphamQuery query)
        {
            return Ok(sanPhamService.GetAllSanpham(query));
        }

        [HttpGet("{id:int}")]
        public IActionResult GetSanphamById(int id)
        {
            var sanpham = sanPhamService.GetSanphamById(id);
            if (sanpham == null)
            {
                return NotFound();
            }
            return Ok(sanpham);
        }
        [HttpPost]
        public IActionResult ThemSanpham(SanphamDTO sanphamDTO)
        {
            if (sanPhamService.AddSanpham(sanphamDTO))
            {
                return Ok(sanphamDTO);
            }
            return BadRequest();
        }
        [HttpDelete("{id}")]
        [Authorize(Policy = "AdminPolicy")]
        public IActionResult XoaSanpham(int id)
        {
            var sanpham = sanPhamService.DeleteSanpham(id);
            if (sanpham)
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpPut("{id}")]
        [Authorize(Policy = "AdminPolicy")]
        public IActionResult CapnhatSanpham(SanphamDTO sanphamDTO)
        {
            if (!sanPhamService.UpdateSanpham(sanphamDTO))
            {
                return Ok(sanphamDTO);
            }
            return BadRequest();
        }


        [HttpGet("name/{name}")]
        public IActionResult GetSanphamByName(string name)
        {
            var sanpham = sanPhamService.GetSanphamByName(name);
            if (sanpham == null)
            {
                return NotFound();
            }
            return Ok(sanpham);
        }

        [HttpGet("idlsp/{id}")]
        public IActionResult GetSanphamByIdLoaisanpham(int id)
        {
            var sanpham = sanPhamService.GetSanphamByIdLoaisanpham(id);
            if (sanpham == null)
            {
                return NotFound();
            }
            return Ok(sanpham);
        }

        [HttpGet("idkho/{id}")]
        public IActionResult GetSanphamByIdKho(int id)
        {
            var sanpham = sanPhamService.GetSanphamByIdKho(id);
            if(sanpham == null)
            {
                return NotFound();
            }
            return Ok(sanpham);
        }

        [HttpGet("sortDes")]
        public IActionResult SortGiamdan()
        {
            var sortProducts = context.Sanphams.OrderByDescending(p => p.Giaban).ToList();
            return Ok(sortProducts);
        }

        [HttpGet("sortAsc")]
        public IActionResult SortTangdan()
        {
            var sortProducts = context.Sanphams.OrderBy(p => p.Giaban).ToList();
            return Ok(sortProducts);
        }
    }
}
