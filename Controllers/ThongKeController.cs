using DOAN52.Authentication;
using DOAN52.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOAN52.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThongKeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ThongKeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult TrangChu()
        {
            var result = new ThongKeTrangChuViewModel();

            var soLuongGiangVien= _context.TblCanBoGiangViens.Count();

            result.SoLuongGiangVien = soLuongGiangVien;

            return new OkObjectResult(result);
        }
    }
}
