using Microsoft.EntityFrameworkCore;
using DinkesAPI.Models;

namespace DinkesAPI.Data
{
    public class DinkesContext : DbContext
    {
        public DinkesContext(DbContextOptions<DinkesContext> options) : base(options) {}

        public DbSet<Faskes> Faskes { get; set; }
        public DbSet<JumlahTenagaMedis> JumlahTenagaMedis { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    // Relasi
    modelBuilder.Entity<JumlahTenagaMedis>()
        .HasOne(jtm => jtm.Faskes)
        .WithMany(f => f.JumlahTenagaMedis)
        .HasForeignKey(jtm => jtm.ID_faskes);

    // Seeder Faskes
    modelBuilder.Entity<Faskes>().HasData(
        new Faskes {
            ID_faskes = 1,
            nama_faskes = "Puskesmas Bandung Kidul",
            jenis_faskes = "Puskesmas",
            alamat_faskes = "Jl. Soekarno-Hatta No.123"
        },
        new Faskes {
            ID_faskes = 2,
            nama_faskes = "RSUD Kota Bandung",
            jenis_faskes = "Rumah Sakit",
            alamat_faskes = "Jl. Kopo No.45"
        }
    );

    // Seeder JumlahTenagaMedis
    modelBuilder.Entity<JumlahTenagaMedis>().HasData(
        new JumlahTenagaMedis {
            ID_Jumlahtm = 1,
            dokter = 5,
            perawat = 12,
            bidan = 3,
            ID_faskes = 1
        },
        new JumlahTenagaMedis {
            ID_Jumlahtm = 2,
            dokter = 15,
            perawat = 30,
            bidan = 10,
            ID_faskes = 2
        }
    );
}

    }
}