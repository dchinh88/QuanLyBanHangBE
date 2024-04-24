using Microsoft.AspNetCore.Mvc;
using QuanLyBanHang.Application.DTO;
using QuanLyBanHang.Application.Interface;
using QuanLyBanHang.Application.Query;
using QuanLyBanHang.Application.Services;

namespace QuanLyBanHang.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QLDonhangController : ControllerBase
    {
        private readonly IDonhangService donhangService;
        public QLDonhangController(IDonhangService donhangService)
        {
            this.donhangService = donhangService;
        }
        [HttpGet("GetAllDonhang")]
        public IActionResult GetAllDonhang_NoQuery() 
        {
            return Ok(donhangService.GetAllDonhang_NoQuery());
        }
        [HttpGet]
        public IActionResult GetAllDonhang([FromQuery] DonhangQuery query)
        {
            return Ok(donhangService.GetAllDonhang(query));
        }
        [HttpGet("{id:int}")]
        public IActionResult GetDonhangById(int id)
        {
            var donhang = donhangService.GetDonhangById(id);
            if(donhang == null)
            {
                return NotFound();
            }
            return Ok(donhang);
        }
        [HttpPost]
        public IActionResult ThemDonhang(DonhangDTO donhangDTO)
        {
            if(!donhangService.AddDonhang(donhangDTO))
            {
                return BadRequest();
            }
            return Ok(donhangDTO);
        }
        [HttpDelete("{id}")]
        public IActionResult XoaDonhang(int id)
        {
            var donhang = donhangService.DeleteDonhang(id);
            if(donhang)
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpPut]
        public IActionResult CapnhatDonhang(DonhangDTO donhangDTO)
        {
            if(!donhangService.UpdateDonhang(donhangDTO))
            {
                return Ok(donhangDTO);
            }
            return BadRequest();
        }
    }
}
