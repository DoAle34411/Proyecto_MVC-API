using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIProductos.Migrations
{
    /// <inheritdoc />
    public partial class NuevosCamposNuevaTabla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Autor",
                table: "Producto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Costo",
                table: "Producto",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Producto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 1,
                columns: new[] { "Autor", "Cantidad", "Costo", "Descripcion", "Genero", "Nombre" },
                values: new object[] { "Sarah J. Maas", 20, 18.5, "Cuando la cazadora de diecinueve años de edad, Feyre, mata a un lobo el el bosque, una criatura parecida a una bestia llega para exigir venganza. Arrastrada a una traicionera tierra mágica que solo conoce de leyendas, Feyre descubre que su captor no es un animal, sino Tamlin, una de las letales e inmortales hadas que una vez gobernaron su mundo.\nA medida que ella vive en su estado, sus sentimientos por Tamlin se transforman de una hostilidad helada a una pasión que quema a pesar de todas las mentiras y las advertencias que se le han hecho sobre el hermoso y peligroso mundo de las hadas. Pero una antigua y malvada sombre crece sobre las tierras feéricas, y Feyre debe encontrar la manera de detenerla... o condenará a Tamlin, y su mundo, para siempre.", "Fantasia", "A Court of Thorns and Roses" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 2,
                columns: new[] { "Autor", "Cantidad", "Costo", "Descripcion", "Genero", "Nombre" },
                values: new object[] { "Sarah J. Maas", 20, 19.5, "Tras haber superado más pruebas de lo que un corazón humano puede soportar, Feyre regresa a la Corte Primavera con los poderes de una alta fae. Sin embargo, no consigue olvidar los crímenes que debió cometer para salvar a Tamlin y a su pueblo, ni el perverso pacto que cerró con Rhysand, el alto lord de la temible Corte Noche. \\nMientras Feyre es arrastrada hacia el interior de la oscura red política y pasional de Rhysand, una guerra inminente acecha y un mal mucho más peligroso que cualquier reina amenaza con destruir todo lo que Feyre alguna vez intentó proteger. Ella podría ser la clave para detenerlo, pero solo si consigue dominar sus nuevos dones, sanar su alma partida en dos y decidir su futuro y el de todo un mundo en crisis. \\nLa autora número uno en ventas en The New York Times y USA Today, Sarah J. Maas, lleva esta saga más que adictiva a un nivel impensado.\",", "Fantasia", "A Court of Mist and Fury" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 3,
                columns: new[] { "Autor", "Cantidad", "Costo", "Descripcion", "Genero", "Nombre" },
                values: new object[] { "Sarah J. Maas", 20, 18.75, "Feyre regresa a la Corte Primavera, decidida a reunir información sobre los planes de Tamlin y del rey invasor que amenaza con destruir Prythian. Para esto deberá someterse a un letal y peligroso juego de engaño, en el que un simple error podría condenar no solo a Feyre, sino también a todo el mundo a su alrededor.\\nA medida que la guerra avanza sin tregua, Feyre deberá posicionarse como una alta fae y luchar por dominar sus dones mágicos; tendrá que determinar en cuáles de los deslumbrantes altos lores puede confiar y salir a buscar aliados en los lugares más inesperados.\\nEn este apasionante tercer volumen de la serie de Una corte de rosas y espinas de la exitosísima autora Sarah J. Maas, la tierra se teñirá de rojo mientras majestuosos ejércitos luchan por apoderarse del único objeto que podría destruirlos a todos. \",", "Fantasia", "A Court of Wings And Ruin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Autor",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "Costo",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Producto");

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 1,
                columns: new[] { "Cantidad", "Descripcion", "Nombre" },
                values: new object[] { 12, "FANTASIA", "ACOTAR" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 2,
                columns: new[] { "Cantidad", "Descripcion", "Nombre" },
                values: new object[] { 2, "FANTASIA", "ACOMAF" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 3,
                columns: new[] { "Cantidad", "Descripcion", "Nombre" },
                values: new object[] { 2, "FANTASIA", "ACOWAR" });
        }
    }
}
