using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIProductos.Migrations
{
    /// <inheritdoc />
    public partial class FUCKYOU : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 1,
                columns: new[] { "Descripcion", "Nombre" },
                values: new object[] { "FANTASIA", "ACOTAR" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 2,
                columns: new[] { "Descripcion", "Nombre" },
                values: new object[] { "FANTASIA", "ACOMAF" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 3,
                columns: new[] { "Descripcion", "Nombre" },
                values: new object[] { "FANTASIA", "ACOWAR" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 1,
                columns: new[] { "Descripcion", "Nombre" },
                values: new object[] { "Album Musical: ALternativo", "Scaled and Icy" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 2,
                columns: new[] { "Descripcion", "Nombre" },
                values: new object[] { "Album Musical: Pop", "1989" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 3,
                columns: new[] { "Descripcion", "Nombre" },
                values: new object[] { "Album Musical: Pop", "CALM" });
        }
    }
}
