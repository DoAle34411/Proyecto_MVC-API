using APIProductos.Models;
using Microsoft.EntityFrameworkCore;

namespace APIProductos.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(
            DbContextOptions<ApplicationDBContext> options ) : base( options ) { }
        
        public DbSet<Producto> Producto { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Creando un producto
            modelBuilder.Entity<Producto>().HasData(
                new Producto
                {
                    IdProducto=1,
                    Nombre = "ACOTAR",
                    Descripcion="FANTASIA",
                    Cantidad=12
                },

                new Producto
                {
                    IdProducto = 2,
                    Nombre = "ACOMAF",
                    Descripcion = "FANTASIA",
                    Cantidad = 2
                },
                new Producto
                {
                    IdProducto = 3,
                    Nombre = "ACOWAR",
                    Descripcion = "FANTASIA",
                    Cantidad = 2
                }


                );
        }
    }
}
