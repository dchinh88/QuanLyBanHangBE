using Microsoft.AspNetCore.Mvc;
using QuanLyBanHang.Application.DTO;
using QuanLyBanHang.Application.Interface;

namespace QuanLyBanHang.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QLChitietphieumuahangController : ControllerBase
    {
        private readonly IChitietphieumuahangService chitietphieumuahangService;
        public QLChitietphieumuahangController(IChitietphieumuahangService chitietphieumuahangService)
        {
            this.chitietphieumuahangService = chitietphieumuahangService;
        }
        [HttpGet]
        public IActionResult GetAllChitietphieumuahang()
        {
            return Ok(chitietphieumuahangService.GetAllChitietphieumuahang());
        }
        [HttpGet("{id:int}")]
        public IActionResult GetChitietphieumuahangById(int id)
        {
            var chitietphieumuahang = chitietphieumuahangService.GetChitietphieumuahangById(id);
            if(chitietphieumuahang == null)
            {
                return NotFound();
            }
            return Ok(chitietphieumuahang);
        }
        [HttpPost]
        public IActionResult ThemChitietphieumuahang(ChitietphieumuahangDTO chitietphieumuahangDTO)
        {
            if(!chitietphieumuahangService.AddChitietphieumuahang(chitietphieumuahangDTO))
            {
                return BadRequest();
            }
            return Ok(chitietphieumuahangDTO);
        }
        [HttpDelete("{id}")]
        public IActionResult XoaChitietphieumuahang(int id)
        {
            var chitietphieumuahang = chitietphieumuahangService.DeleteChitietphieumuahang(id);
            if(chitietphieumuahang)
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpPut]
        public IActionResult CapnhatChitietphieumuahang(ChitietphieumuahangDTO chitietphieumuahangDTO)
        {
            if (!chitietphieumuahangService.UpdateChitietphieumuahang(chitietphieumuahangDTO))
            {
                return Ok(chitietphieumuahangDTO);
            }
            return BadRequest();   
        }
    }
}
