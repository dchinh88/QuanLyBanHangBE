using Microsoft.AspNetCore.Mvc;
using QuanLyBanHang.Application.DTO;
using QuanLyBanHang.Application.Interface;

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
        [HttpGet]
        public IActionResult GetAllNhacungcap()
        {
            return Ok(nhacungcapService.GetAllNhacungcap());
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
        [HttpPut]
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
