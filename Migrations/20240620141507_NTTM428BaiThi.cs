using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NTTMBT.Migrations
{
    /// <inheritdoc />
    public partial class NTTM428BaiThi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NTTM428Employee",
                columns: table => new
                {
                    EmployeeID = table.Column<string>(type: "TEXT", nullable: false),
                    TenSinhVien = table.Column<string>(type: "TEXT", nullable: false),
                    LopHoc = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NTTM428Employee", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "NTTM428Person",
                columns: table => new
                {
                    MaSinhVien = table.Column<string>(type: "TEXT", nullable: false),
                    TenSinhVien = table.Column<string>(type: "TEXT", nullable: false),
                    LopHoc = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NTTM428Person", x => x.MaSinhVien);
                });

            migrationBuilder.CreateTable(
                name: "NTTM428Student",
                columns: table => new
                {
                    CCCN = table.Column<string>(type: "TEXT", nullable: false),
                    TenSinhVien = table.Column<string>(type: "TEXT", nullable: false),
                    LopHoc = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NTTM428Student", x => x.CCCN);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NTTM428Employee");

            migrationBuilder.DropTable(
                name: "NTTM428Person");

            migrationBuilder.DropTable(
                name: "NTTM428Student");
        }
    }
}
