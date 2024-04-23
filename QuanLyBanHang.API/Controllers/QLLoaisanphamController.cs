using Microsoft.AspNetCore.Mvc;
using QuanLyBanHang.Application.DTO;
using QuanLyBanHang.Application.Interface;

namespace QuanLyBanHang.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QLLoaisanphamController : ControllerBase
    {
        private readonly ILoaisanphamService loaisanphamService;
        public QLLoaisanphamController(ILoaisanphamService loaisanphamService)
        {
            this.loaisanphamService = loaisanphamService;
        }
        [HttpGet]
        public IActionResult GetAllLoaisanpham()
        {
            return Ok(loaisanphamService.GetAllLoaisanpham());
        }
        [HttpGet("{id:int}")]
        public IActionResult GetLoaisanphamById(int id)
        {
            var loaisanpham = loaisanphamService.GetLoaisanphamById(id);
            if(loaisanpham == null)
            {
                return NotFound();
            }
            return Ok(loaisanpham);
        }
        [HttpPost]
        public IActionResult ThemLoaisanpham(LoaisanphamDTO loaisanphamDTO)
        {
            if(!loaisanphamService.AddLoaisanpham(loaisanphamDTO))
            {
                return BadRequest();
            }
            return Ok(loaisanphamDTO);
        }
        [HttpDelete("{id}")]
        public IActionResult XoaLoaisanpham(int id)
        {
            var loaisanpham = loaisanphamService.DeleteLoaisanpham(id);
            if(loaisanpham)
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpPut]
        public IActionResult CapnhatLoaisanpham(LoaisanphamDTO loaisanphamDTO)
        {
            if(!loaisanphamService.UpdateLoaisanpham(loaisanphamDTO))
            {
                return Ok(loaisanphamDTO);
            }
            return BadRequest();
        }
    }
}
