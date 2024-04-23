using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyBanHang.Domain.Entities;
using QuanLyBanHang.Infrastructure.Context;

namespace QuanLyBanHang.API.Helper
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadAvatar : ControllerBase
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly QlkinhdoanhContext qlkinhdoanhContext;
        public UploadAvatar(IWebHostEnvironment webHostEnvironment, QlkinhdoanhContext qlkinhdoanhContext)
        {
            this.webHostEnvironment = webHostEnvironment;
            this.qlkinhdoanhContext = qlkinhdoanhContext;
        }
        [HttpPut("UploadAvatar")]
        public async Task<IActionResult> UploadAvatarNhanVien([FromForm] IFormFileCollection formFiles, [FromForm] int id)
        {
            if(formFiles == null || formFiles.Count == 0)
            {
                return BadRequest("No files uploaded");
            }
            int successCount = 0;
            int errorCount = 0;
            try
            {
                foreach(var file in formFiles)
                {
                    if(file.Length == 0)
                    {
                        continue;
                    }
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        await file.CopyToAsync(memoryStream);
                        var avatar = new Avatar()
                        {
                            Nhanvienid = id,
                            Avatar1 = memoryStream.ToArray()
                        };
                        this.qlkinhdoanhContext.Add(avatar);
                        await this.qlkinhdoanhContext.SaveChangesAsync();
                        successCount++;
                    }
                }
            } catch (Exception ex)
            {
                errorCount++;
                Console.WriteLine($"Error: {ex.Message}");
                return StatusCode(500, "Error");
            }
            if(successCount > 0)
            {
                return Ok($"{successCount} image(s) uploaded successfull");
            }
            return BadRequest("Error");
        }

        [HttpGet("GetAvatar")]
        public async Task<IActionResult> GetAvatarById(int idnhanvien)
        {
            List<string> avatar = new List<string>();
            try
            {
                var avatarNhanVien = this.qlkinhdoanhContext.Avatars.Where(item => item.Nhanvienid == idnhanvien).ToList();
                if(avatarNhanVien != null && avatarNhanVien.Count > 0)
                {
                    avatarNhanVien.ForEach(async item =>
                    {
                        avatar.Add(Convert.ToBase64String(item.Avatar1));
                    });
                }
                else
                {
                    return NotFound();
                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Ok(avatar);
        }

        [HttpGet("GetAllAvatar")]
        public async Task<IActionResult> GetAllAvatar()
        {
            try
            {
                var avatarWithNhanvienId = await this.qlkinhdoanhContext.Avatars
                                                     .Where(i => i.Avatar1 != null && i.Avatar1.Length > 0)
                                                     .ToListAsync();
                var result = avatarWithNhanvienId.Select(a => new
                {
                    Id = a.Id,
                    NhanvienId = a.Nhanvienid,
                    Avatar1 = Convert.ToBase64String(a.Avatar1),
                });
                return Ok(result);
            } catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return StatusCode(500, "Error");
            }
        }

        [HttpGet("RemoveAvatar")]
        public async Task<IActionResult> RemoveAvatar(int idnhanvien)
        {
            var avatar = this.qlkinhdoanhContext.Avatars.Where(e => e.Nhanvienid == idnhanvien);
            try
            {
                if(avatar != null)
                {
                    this.qlkinhdoanhContext.Remove(avatar);
                    await qlkinhdoanhContext.SaveChangesAsync();
                    return Ok();
                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return NotFound();
            }
            return NotFound();
        }
    }
}
