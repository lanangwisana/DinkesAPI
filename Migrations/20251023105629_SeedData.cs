using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DinkesAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Faskes",
                columns: new[] { "ID_faskes", "alamat_faskes", "jenis_faskes", "nama_faskes" },
                values: new object[,]
                {
                    { 1, "Jl. Soekarno-Hatta No.123", "Puskesmas", "Puskesmas Bandung Kidul" },
                    { 2, "Jl. Kopo No.45", "Rumah Sakit", "RSUD Kota Bandung" }
                });

            migrationBuilder.InsertData(
                table: "JumlahTenagaMedis",
                columns: new[] { "ID_Jumlahtm", "ID_faskes", "bidan", "dokter", "perawat" },
                values: new object[,]
                {
                    { 1, 1, 3, 5, 12 },
                    { 2, 2, 10, 15, 30 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JumlahTenagaMedis",
                keyColumn: "ID_Jumlahtm",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JumlahTenagaMedis",
                keyColumn: "ID_Jumlahtm",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Faskes",
                keyColumn: "ID_faskes",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Faskes",
                keyColumn: "ID_faskes",
                keyValue: 2);
        }
    }
}
