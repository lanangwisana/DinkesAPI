using Microsoft.AspNetCore.Mvc;
using DinkesAPI.Data;
using DinkesAPI.Models;

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
            var faskesList = _context.Faskes.ToList();
            return Ok(faskesList);
        }

        [HttpPost]
        public IActionResult Create(Faskes faskes) {
            _context.Faskes.Add(faskes);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetAll), new { id = faskes.ID_faskes }, faskes);
        }
    }
}
