using Microsoft.AspNetCore.Mvc;
using DinkesAPI.Data;
using DinkesAPI.Models;

namespace DinkesAPI.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class JumlahTenagaMedisController : ControllerBase {
        private readonly DinkesContext _context;

        public JumlahTenagaMedisController(DinkesContext context) {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll() {
            var data = _context.JumlahTenagaMedis.ToList();
            return Ok(data);
        }

        [HttpPost]
        public IActionResult Create(JumlahTenagaMedis input) {
            _context.JumlahTenagaMedis.Add(input);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetAll), new { id = input.ID_Jumlahtm }, input);
        }

        [HttpGet("faskes/{id}")]
        public IActionResult GetByFaskes(int id) {
            var data = _context.JumlahTenagaMedis
                .Where(j => j.ID_faskes == id)
                .ToList();
            return Ok(data);
        }
    }
}
