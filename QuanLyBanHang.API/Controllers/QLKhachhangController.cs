﻿using Microsoft.AspNetCore.Mvc;
using QuanLyBanHang.Application.DTO;
using QuanLyBanHang.Application.Interface;
using QuanLyBanHang.Application.Query;

namespace QuanLyBanHang.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QLKhachhangController : ControllerBase
    {
        private readonly IKhachhangService khachhangService;
        public QLKhachhangController(IKhachhangService khachhangService)
        {
            this.khachhangService = khachhangService;
        }
        [HttpGet("GetAllKhachhang")]
        public IActionResult GetAllKhachhang_NoQuery()
        {
            return Ok(khachhangService.GetAllKhachhang_NoQuery());
        }
        [HttpGet]
        public IActionResult GetAllKhachhang([FromQuery] KhachhangQuery query)
        {
            return Ok(khachhangService.GetAllKhachhang(query));
        }
        [HttpGet("{id:int}")]
        public IActionResult GetKhachhangById(int id)
        {
            var khachhang = khachhangService.GetKhachhangById(id);
            if(khachhang == null)
            {
                return NotFound();
            }
            return Ok(khachhang);
        }
        [HttpPost]
        public IActionResult ThemKhachhang(KhachhangDTO khachhangDTO)
        {
            if(!khachhangService.AddKhachhang(khachhangDTO))
            {
                return BadRequest();
            }
            return Ok(khachhangDTO);
        }
        [HttpDelete("{id}")]
        public IActionResult XoaKhachhang(int id)
        {
            var khachhang = khachhangService.DeleteKhachhang(id);
            if(khachhang)
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpPut]
        public IActionResult CapnhatKhachhang(KhachhangDTO khachhangDTO)
        {
            if(!khachhangService.UpdateKhachhang(khachhangDTO))
            {
                return Ok(khachhangDTO);
            }
            return BadRequest();
        }
    }
}
