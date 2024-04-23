using Microsoft.AspNetCore.Mvc;
using QuanLyBanHang.Application.DTO;
using QuanLyBanHang.Application.Interface;

namespace QuanLyBanHang.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QLPhieumuahangController : ControllerBase
    {
        private readonly IPhieumuahangService phieumuahangService;
        public QLPhieumuahangController(IPhieumuahangService phieumuahangService)
        {
            this.phieumuahangService = phieumuahangService;
        }
        [HttpGet]
        public IActionResult GetAllPhieumuahang()
        {
            return Ok(phieumuahangService.GetAllPhieumuahang());
        }
        [HttpGet("{id:int}")]
        public IActionResult GetPhieumuahangById(int id)
        {
            var phieumuahang = phieumuahangService.GetPhieumuahangById(id);
            if(phieumuahang == null)
            {
                return NotFound();
            }
            return Ok(phieumuahang);
        }
        [HttpPost]
        public IActionResult ThemPhieumuahang(PhieumuahangDTO phieumuahangDTO)
        {
            if (!phieumuahangService.AddPhieumuahang(phieumuahangDTO))
            {
                return BadRequest();
            }
            return Ok(phieumuahangDTO);
        }
        [HttpDelete("{id}")]
        public IActionResult XoaPhieumuahang(int id)
        {
            var phieumuahang = phieumuahangService.DeletePhieumuahang(id);
            if(phieumuahang)
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpPut]
        public IActionResult CapnhatPhieumuahang(PhieumuahangDTO phieumuahangDTO)
        {
            if(!phieumuahangService.UpdatePhieumuahang(phieumuahangDTO))
            {
                return Ok(phieumuahangDTO);
            }
            return BadRequest();
        }
    }
}
