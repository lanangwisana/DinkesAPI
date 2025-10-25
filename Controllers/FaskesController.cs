using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using DinkesAPI.Data;
using DinkesAPI.Models;
using DinkesAPI.Dtos;

namespace DinkesAPI.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class FaskesController : ControllerBase {
        private readonly DinkesContext _context;

        public FaskesController(DinkesContext context) {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll() {
            var faskesList = _context.Faskes
            .Include(f => f.JumlahTenagaMedis)
            .ToList()
            .Select(f => new FaskesDetailDto
            {
                ID_faskes = f.ID_faskes,
                nama_faskes = f.nama_faskes,
                jenis_faskes = f.jenis_faskes,
                alamat_faskes = f.alamat_faskes,
                dokter = f.JumlahTenagaMedis != null ? f.JumlahTenagaMedis.Sum(t => t.dokter) : 0,
                perawat = f.JumlahTenagaMedis != null ? f.JumlahTenagaMedis.Sum(t => t.perawat) : 0,
                bidan = f.JumlahTenagaMedis != null ? f.JumlahTenagaMedis.Sum(t => t.bidan) : 0
            })
            .ToList();
            return Ok(faskesList);
        }

        [HttpGet("statistik")]
        public IActionResult GetStatistikFaskes()
        {
            var totalFaskes = _context.Faskes.Count();
            var tenagaMedis = _context.JumlahTenagaMedis.ToList();

            var totalDokter = tenagaMedis.Sum(tm => tm.dokter);
            var totalPerawat = tenagaMedis.Sum(tm => tm.perawat);
            var totalBidan = tenagaMedis.Sum(tm => tm.bidan);

            var result = new
            {
                dokter_tersedia = totalDokter,
                perawat_tersedia = totalPerawat,
                bidan_tersedia = totalBidan,
                faskes_terdaftar = totalFaskes
            };

            return Ok(result);
        }

    }
}
