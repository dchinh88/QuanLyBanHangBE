using Microsoft.AspNetCore.Mvc;
using QuanLyBanHang.Application.DTO;
using QuanLyBanHang.Application.Interface;

namespace QuanLyBanHang.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QLTinhtrangController : ControllerBase
    {
        private readonly ITinhtrangService tinhtrangService;
        public QLTinhtrangController(ITinhtrangService tinhtrangService)
        {
            this.tinhtrangService = tinhtrangService;
        }
        [HttpGet]
        public IActionResult GetAllTinhtrang()
        {
            return Ok(tinhtrangService.GetAllTinhtrang());
        }
        [HttpGet("{id:int}")]
        public IActionResult GetTinhtrangById(int id)
        {
            var tinhtrang = tinhtrangService.GetTinhtrangById(id);
            if(tinhtrang == null)
            {
                return NotFound();
            }
            return Ok(tinhtrang);
        }
        [HttpPost]
        public IActionResult ThemTinhtrang(TinhtrangDTO tinhtrangDTO)
        {
            if(!tinhtrangService.AddTinhtrang(tinhtrangDTO))
            {
                return BadRequest();
            }
            return Ok(tinhtrangDTO);
        }
        [HttpDelete("{id}")]
        public IActionResult XoaTinhTrang(int id)
        {
            var tinhtrang = tinhtrangService.DeleteTinhtrang(id);
            if(tinhtrang)
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpPut]
        public IActionResult CapnhatTinhtrang(TinhtrangDTO tinhtrangDTO)
        {
            if(!tinhtrangService.UpdateTinhtrang(tinhtrangDTO))
            {
                return Ok(tinhtrangDTO);
            }
            return BadRequest();
        }
    }
}
