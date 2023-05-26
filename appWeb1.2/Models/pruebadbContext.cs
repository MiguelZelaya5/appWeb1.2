using Microsoft.EntityFrameworkCore;
using appWeb1._2.Models;
namespace appWeb1._2.Models
{
    public class pruebadbContext : DbContext
    {
        public pruebadbContext(DbContextOptions<pruebadbContext> options) : base(options)
        {

        }
        public DbSet<appWeb1._2.Models.Trabajo>? Trabajo { get; set; }
    }
}
