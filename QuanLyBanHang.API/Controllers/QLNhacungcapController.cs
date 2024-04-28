using Microsoft.AspNetCore.Mvc;
using QuanLyBanHang.Application.DTO;
using QuanLyBanHang.Application.Interface;
using QuanLyBanHang.Application.Query;

namespace QuanLyBanHang.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QLNhacungcapController : ControllerBase
    {
        private readonly INhacungcapService nhacungcapService;
        public QLNhacungcapController(INhacungcapService nhacungcapService)
        {
            this.nhacungcapService = nhacungcapService;
        }
        [HttpGet("GetAllNhacungcap")]
        public IActionResult GetAllNhacungcap_NoQuery()
        {
            return Ok(nhacungcapService.GetAllNhacungcap_NoQuery());
        }
        [HttpGet]
        public IActionResult GetAllNhacungcap([FromQuery] NhacungcapQuery query)
        {
            return Ok(nhacungcapService?.GetAllNhacungcap(query));
        }
        [HttpGet("{id:int}")]
        public IActionResult GetNhacungcapById(int id)
        {
            var nhacungcap = nhacungcapService.GetNhacungcapById(id);
            if(nhacungcap == null)
            {
                return NotFound();
            }
            return Ok(nhacungcap);
        }
        [HttpPost]
        public IActionResult ThemNhacungcap(NhacungcapDTO nhacungcapDTO)
        {
            if(!nhacungcapService.AddNhacungcap(nhacungcapDTO))
            {
                return BadRequest();
            }
            return Ok(nhacungcapDTO);
        }
        [HttpDelete("{id}")]
        public IActionResult XoaNhacungcap(int id)
        {
            var nhacungcap = nhacungcapService.DeleteNhacungcap(id);
            if(nhacungcap)
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpPut("{id}")]
        public IActionResult CapnhatNhacungcap(NhacungcapDTO nhacungcapDTO)
        {
            if(!nhacungcapService.UpdateNhacungcap(nhacungcapDTO))
            {
                return Ok(nhacungcapDTO);
            }
            return BadRequest();
        }
    }
}
