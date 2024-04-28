using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLyBanHang.Application.DTO;
using QuanLyBanHang.Application.Interface;
using QuanLyBanHang.Application.Query;
using QuanLyBanHang.Application.Services;

namespace QuanLyBanHang.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QLKhoController : ControllerBase
    {
        private readonly IKhoService khoService;
        public QLKhoController(IKhoService khoService)
        {
            this.khoService = khoService;
        }
        [HttpGet("GetAllKho")]
        public IActionResult GetAllKho_NoQuery()
        {
            return Ok(khoService.GetAllKho_NoQuery());
        }
        [HttpGet]
        public IActionResult GetAllKho([FromQuery] KhoQuery query)
        {
            return Ok(khoService.GetAllKho(query));
        }
        [HttpGet("{id:int}")]
        public IActionResult GetKhoById(int id) 
        { 
            var kho = khoService.GetKhoById(id);
            if(kho == null)
            {
                return NotFound();
            }
            return Ok(kho);
        }
        [HttpPost]
        public IActionResult ThemKho(KhoDTO khoDTO)
        {
            if(!khoService.AddKho(khoDTO))
            {
                return BadRequest();
            }
            return Ok(khoDTO);
        }
        [HttpDelete("{id}")]
        public IActionResult XoaKho(int id)
        {
            var kho = khoService.DeleteKho(id);
            if(kho)
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpPut("{id}")]
        public IActionResult CapnhatKho(KhoDTO khoDTO)
        {
            if(!khoService.UpdateKho(khoDTO))
            {
                return Ok(khoDTO);
            }
            return BadRequest();
        }
    }
}
