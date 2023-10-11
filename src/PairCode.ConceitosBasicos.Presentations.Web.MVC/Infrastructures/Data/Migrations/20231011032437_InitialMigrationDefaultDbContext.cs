using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PairCode.ConceitosBasicos.Presentations.Web.MVC.Infrastructures.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrationDefaultDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "default");

            migrationBuilder.CreateTable(
                name: "TB_USUARIOS",
                schema: "default",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USERNAME = table.Column<string>(type: "VARCHAR(64)", nullable: true),
                    PASSWORD = table.Column<string>(type: "VARCHAR(32)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_USUARIOS", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_USUARIOS",
                schema: "default");
        }
    }
}
