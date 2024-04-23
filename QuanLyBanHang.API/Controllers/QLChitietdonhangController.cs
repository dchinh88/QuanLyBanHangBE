using Microsoft.AspNetCore.Mvc;
using QuanLyBanHang.Application.DTO;
using QuanLyBanHang.Application.Interface;

namespace QuanLyBanHang.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QLChitietdonhangController : ControllerBase
    {
        private readonly IChitietdonhangService chitietdonhangService;
        public QLChitietdonhangController(IChitietdonhangService chitietdonhangService)
        {
            this.chitietdonhangService = chitietdonhangService;
        }
        [HttpGet]
        public IActionResult GetAllChitietdonhang()
        {
            return Ok(chitietdonhangService.GetAllChitietdonhang());
        }
        [HttpGet("{id:int}")]
        public IActionResult GetChitietdonhangById(int id)
        {
            var chitietdonhang = chitietdonhangService.GetChitietdonhangById(id);
            if(chitietdonhang == null)
            {
                return NotFound();
            }
            return Ok(chitietdonhang);
        }
        [HttpPost]
        public IActionResult ThemChitietdonhang(ChitietdonhangDTO chitietdonhangDTO)
        {
            if(!chitietdonhangService.AddChitietdonhang(chitietdonhangDTO))
            {
                return BadRequest();
            }
            return Ok(chitietdonhangDTO);
        }
        [HttpDelete("{id}")]
        public IActionResult XoaChitietdonhang(int id)
        {
            var chitietdonhang = chitietdonhangService.DeleteChitietdonhang(id);
            if(chitietdonhang)
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpPut]
        public IActionResult CapnhatChitietdonhang(ChitietdonhangDTO chitietdonhangDTO)
        {
            if(!chitietdonhangService.UpdateChitietdonhang(chitietdonhangDTO))
            {
                return Ok(chitietdonhangDTO);
            }
            return BadRequest();
        }
    }
}
