using Microsoft.AspNetCore.Mvc;
using QuanLyBanHang.Application.DTO;
using QuanLyBanHang.Application.Interface;
using QuanLyBanHang.API.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Cryptography;
using QuanLyBanHang.Domain.Entities;
using Microsoft.AspNetCore.Authorization;

namespace QuanLyBanHang.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QLNhanvienController : ControllerBase
    {
        private readonly INhanvienService nhanvienService;
        public QLNhanvienController(INhanvienService nhanvienService)
        {
            this.nhanvienService = nhanvienService;
        }
        [HttpGet]
        public IActionResult GetAllNhanvien()
        {
            return Ok(nhanvienService.GetAllNhanvien());
        }
        [HttpGet("{id:int}")]
        public IActionResult GetNhanvienById(int id) 
        {
            var nhanvien = nhanvienService.GetNhanvienById(id);
            if(nhanvien == null)
            {
                return NotFound();
            }
            return Ok(nhanvien);
        }
        [Authorize(Roles = "admin")]
        [HttpPost]
        public IActionResult ThemNhanvien(NhanvienDTO nhanvienDTO)
        {
            
            if (!nhanvienService.AddNhanvien(nhanvienDTO))
            {
                return BadRequest();
            }
            return Ok(nhanvienDTO);
        }
        [HttpDelete("{id}")]
        public IActionResult XoaNhanvien(int id)
        {
            var nhanvien = nhanvienService.DeleteNhanvien(id);
            if(nhanvien)
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpPut]
        public IActionResult CapnhatNhanvien(NhanvienDTO nhanvienDTO)
        {
            if(!nhanvienService.UpdateNhanvien(nhanvienDTO))
            {
                return Ok(nhanvienDTO);
            }
            return BadRequest();
        }

        /*[HttpPut("SoftDelete")]
        public IActionResult SoftDelete(NhanvienDTO nhanvienDTO)
        {
            if (!nhanvienService.UpdateNhanvien(nhanvienDTO))
            {
                return Ok(nhanvienDTO);
            }
            return BadRequest();
        }*/

        /*private byte[] UploadImage(byte[] formFile)
        {
            using (var memoryStream = new MemoryStream())
            {
                formFile.CopyTo(memoryStream);
                return memoryStream.ToArray();
            }
        }*/

    }
}
