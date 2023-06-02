using Microsoft.EntityFrameworkCore;
using appWeb1._2.Models;

namespace appWeb1._2.Models
{
    public class pruebadbContext : DbContext
    {
        internal IEnumerable<object> nivelexperiencia;

        public pruebadbContext(DbContextOptions<pruebadbContext> options) : base(options)
        {

        }
        public DbSet<appWeb1._2.Models.Trabajo>? Trabajo { get; set; }
        public DbSet<usuarios> usuarios { get; set; }
        public DbSet<descripcionTrabajo> descripcionTrabajo { get; set; }
        public DbSet<seccioncoment> seccioncoment { get; set; }
        public DbSet<administracionEmpresa> administracionEmpresa { get; set; }
    }
}
