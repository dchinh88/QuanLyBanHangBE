using Microsoft.AspNetCore.Mvc;
using QuanLyBanHang.Application.DTO;
using QuanLyBanHang.Application.Interface;
using QuanLyBanHang.Application.Query;

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
        [HttpGet("GetAllCongnocuakhachhang")]
        public IActionResult GetAllCongnocuakhachhang_NoQuery()
        {
            return Ok(congnocuakhachhangService.GetAllCongnocuakhachhang_NoQuery());
        }
        [HttpGet]
        public IActionResult GetAllCongnocukhachhang([FromQuery] CongnocuakhachhangQuery query)
        {
            return Ok(congnocuakhachhangService.GetAllCongnocuakhachhang(query));
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
        [HttpPut("{id}")]
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
