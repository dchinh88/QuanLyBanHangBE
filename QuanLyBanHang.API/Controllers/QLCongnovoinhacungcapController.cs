using Microsoft.AspNetCore.Mvc;
using QuanLyBanHang.Application.DTO;
using QuanLyBanHang.Application.Interface;
using QuanLyBanHang.Application.Query;

namespace QuanLyBanHang.API.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class QLCongnovoinhacungcapController : ControllerBase
    {
        private readonly ICongnovoinhacungcapService congnovoinhacungcapService;
        public QLCongnovoinhacungcapController(ICongnovoinhacungcapService congnovoinhacungcapService)
        {
            this.congnovoinhacungcapService = congnovoinhacungcapService;
        }
        [HttpGet("GetAllCongnovoinhacungcap")]
        public IActionResult GetAllCongnovoinhacungcap_NoQuery()
        {
            return Ok(congnovoinhacungcapService.GetAllCongnovoinhacungcap_NoQuery());
        }
        [HttpGet]
        public IActionResult GetAllCongnovoinhacungcap([FromQuery] CongnovoinhacungcapQuery query)
        {
            return Ok(congnovoinhacungcapService.GetAllCongnovoinhacungcap(query));
        }
        [HttpGet("{id:int}")]
        public IActionResult GetCongnovoinhacungcapById(int id)
        {
            var congnovoinhacungcap = congnovoinhacungcapService.GetCongnovoinhacungcapById(id);
            if(congnovoinhacungcap == null)
            {
                return NotFound();
            }
            return Ok(congnovoinhacungcap);
        }
        [HttpPost]
        public IActionResult ThemCongnovoinhacungcap(CongnovoinhacungcapDTO congnovoinhacungcapDTO)
        {
            if(!congnovoinhacungcapService.AddCongnovoinhacungcap(congnovoinhacungcapDTO))
            {
                return BadRequest();
            }
            return Ok(congnovoinhacungcapDTO);
        }
        [HttpDelete("{id}")]
        public IActionResult XoaCongnovoinhacungcap(int id)
        {
            var congnovoinhacungcap = congnovoinhacungcapService.DeleteCongnovoinhacungcap(id);
            if(congnovoinhacungcap)
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpPut]
        public IActionResult CapnhatCongnovoinhacungcap(CongnovoinhacungcapDTO congnovoinhacungcapDTO)
        {
            if(!congnovoinhacungcapService.UpdateCongnovoinhacungcap(congnovoinhacungcapDTO))
            {
                return Ok(congnovoinhacungcapDTO);
            }
            return BadRequest();
        } 
    }
}
