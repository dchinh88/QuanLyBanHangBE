using Microsoft.AspNetCore.Mvc;
using QuanLyBanHang.Application.DTO;
using QuanLyBanHang.Application.Interface;

namespace QuanLyBanHang.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QLCongnocuakhachhangController : ControllerBase
    {
        private readonly ICongnocuakhachhangService congnocuakhachhangService;
        public QLCongnocuakhachhangController(ICongnocuakhachhangService congnocuakhachhangService)
        {
            this.congnocuakhachhangService = congnocuakhachhangService;
        }
        [HttpGet]
        public IActionResult GetAllCongnocuakhachhang()
        {
            return Ok(congnocuakhachhangService.GetAllCongnocuakhachhang());
        }
        [HttpGet("{id:int}")]
        public IActionResult GetCongnocuakhachhangById(int id)
        {
            var congnocuakhachhang = congnocuakhachhangService.GetCongnocuakhachhangById(id);
            if(congnocuakhachhang == null)
            {
                return NotFound();
            }
            return Ok(congnocuakhachhang);
        }
        [HttpPost]
        public IActionResult ThemCongnocuakhachhang(CongnocuakhachhangDTO congnocuakhachhangDTO)
        {
            if(!congnocuakhachhangService.AddCongnocuakhachhang(congnocuakhachhangDTO))
            {
                return BadRequest();
            }
            return Ok(congnocuakhachhangDTO);
        }
        [HttpDelete("{id}")]
        public IActionResult XoaCongnocuakhachhang(int id)
        {
            var congnocuakhachhang = congnocuakhachhangService.DeleteCongnocuakhachhang(id);
            if(congnocuakhachhang)
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpPut]
        public IActionResult CapnhatCongnocuakhachhang(CongnocuakhachhangDTO congnocuakhachhangDTO)
        {
            if (!congnocuakhachhangService.UpdateCongnocuakhachhang(congnocuakhachhangDTO))
            {
                return Ok(congnocuakhachhangDTO);
            }
            return BadRequest();
        }
    }
}
