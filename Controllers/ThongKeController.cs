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

            var soLuongGiangVien = _context.TblCanBoGiangViens.Count();
            result.SoLuongGiangVien = soLuongGiangVien;

            var soLuongKhoa = _context.TblPhongKhoas.Count();
            result.SoLuongKhoa = soLuongKhoa;

            var soLuongBoMon = _context.TblBoMonTrungTams.Count();
            result.SoLuongBoMon = soLuongBoMon;

            var soLuongPK = _context.TblCanBoGiangViens.Where(x=>x.MaPk=="CNTT").Count();
            result.SoLuongPK = soLuongPK;

            return new OkObjectResult(result);
        }
    }
}
