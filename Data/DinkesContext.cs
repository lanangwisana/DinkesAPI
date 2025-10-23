using Microsoft.EntityFrameworkCore;
using DinkesAPI.Models;

namespace DinkesAPI.Data {
    public class DinkesContext : DbContext {
        public DinkesContext(DbContextOptions<DinkesContext> options) : base(options) {}

        public DbSet<Faskes> Faskes { get; set; }
        public DbSet<JumlahTenagaMedis> JumlahTenagaMedis { get; set; }
    }
}