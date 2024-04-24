using Microsoft.AspNetCore.Mvc;
using QuanLyBanHang.Application.Common;
using QuanLyBanHang.Application.DTO;
using QuanLyBanHang.Application.Interface;
using QuanLyBanHang.Application.Query;
using QuanLyBanHang.Application.Services;

namespace QuanLyBanHang.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QLSanphamController : ControllerBase
    {
        private readonly ISanPhamService sanPhamService;
        public QLSanphamController(ISanPhamService sanPhamService)
        {
            this.sanPhamService = sanPhamService;
        }
        [HttpGet("GetAllSanpham")]
        public IActionResult GetALlSanpham_NoQuery()
        {
            return Ok(sanPhamService.GetAllSanpham_NoQuery());
        }

        [HttpGet]
        public IActionResult GetAllSanpham([FromQuery] SanphamQuery query)
        {
            return Ok(sanPhamService.GetAllSanpham(query));
        }

        [HttpGet("{id:int}")]
        public IActionResult GetSanphamById(int id)
        {
            var sanpham = sanPhamService.GetSanphamById(id);
            if(sanpham == null)
            {
                return NotFound();
            }
            return Ok(sanpham);
        }
        [HttpPost]
        public IActionResult ThemSanpham(SanphamDTO sanphamDTO)
        {
            if(sanPhamService.AddSanpham(sanphamDTO))
            {
                return Ok(sanphamDTO);
            }
            return BadRequest();
        }
        [HttpDelete("{id}")]
        public IActionResult XoaSanpham(int id)
        {
            var sanpham = sanPhamService.DeleteSanpham(id);
            if(sanpham)
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpPut]
        public IActionResult CapnhatSanpham(SanphamDTO sanphamDTO)
        {
            if(!sanPhamService.UpdateSanpham(sanphamDTO))
            {
                return Ok(sanphamDTO);
            }
            return BadRequest();
        }
    }
}
