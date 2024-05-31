using Microsoft.AspNetCore.Mvc;
using QuanLyBanHang.Application.DTO;
using QuanLyBanHang.Application.Interface;
using QuanLyBanHang.Application.Query;
using QuanLyBanHang.Application.Services;
using QuanLyBanHang.Infrastructure.Context;

namespace QuanLyBanHang.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QLDonhangController : ControllerBase
    {
        private readonly IDonhangService donhangService;
        private readonly QlkinhdoanhContext context;
        public QLDonhangController(IDonhangService donhangService, QlkinhdoanhContext context)
        {
            this.donhangService = donhangService;
            this.context = context;
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
        [HttpPut("{id}")]
        public IActionResult CapnhatDonhang(DonhangDTO donhangDTO)
        {
            if(!donhangService.UpdateDonhang(donhangDTO))
            {
                return Ok(donhangDTO);
            }
            return BadRequest();
        }

        [HttpGet("filterByDate")]
        public IActionResult GetDonhangByDate(DateTime startDate, DateTime endDate)
        {
            var donhangs = donhangService.GetAllDonhang_NoQuery();
            var filterDonhang = donhangService.FillterDonhangsByDate(donhangs, startDate, endDate);
            return Ok(filterDonhang);
        }
    }
}
