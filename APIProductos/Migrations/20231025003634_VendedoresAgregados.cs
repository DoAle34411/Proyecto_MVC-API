using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APIProductos.Migrations
{
    /// <inheritdoc />
    public partial class VendedoresAgregados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vendedor",
                columns: table => new
                {
                    Cedula = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CantidadVentas = table.Column<int>(type: "int", nullable: false),
                    EsActivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedor", x => x.Cedula);
                });

            migrationBuilder.InsertData(
                table: "Vendedor",
                columns: new[] { "Cedula", "Apellidos", "CantidadVentas", "EsActivo", "Nombres" },
                values: new object[,]
                {
                    { 1600014789, "Coronel Tapia", 0, true, "Silvia Rosa" },
                    { 1726884552, "Tapia Ortega", 100, false, "Alejandra Ivonne" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vendedor");
        }
    }
}
