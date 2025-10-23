using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DinkesAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Faskes",
                columns: table => new
                {
                    ID_faskes = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nama_faskes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    jenis_faskes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    alamat_faskes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faskes", x => x.ID_faskes);
                });

            migrationBuilder.CreateTable(
                name: "JumlahTenagaMedis",
                columns: table => new
                {
                    ID_Jumlahtm = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dokter = table.Column<int>(type: "int", nullable: false),
                    perawat = table.Column<int>(type: "int", nullable: false),
                    bidan = table.Column<int>(type: "int", nullable: false),
                    ID_faskes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JumlahTenagaMedis", x => x.ID_Jumlahtm);
                    table.ForeignKey(
                        name: "FK_JumlahTenagaMedis_Faskes_ID_faskes",
                        column: x => x.ID_faskes,
                        principalTable: "Faskes",
                        principalColumn: "ID_faskes",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JumlahTenagaMedis_ID_faskes",
                table: "JumlahTenagaMedis",
                column: "ID_faskes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JumlahTenagaMedis");

            migrationBuilder.DropTable(
                name: "Faskes");
        }
    }
}
