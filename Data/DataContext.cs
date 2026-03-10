using Microsoft.EntityFrameworkCore;
using prueba22.web.Models;

namespace prueba22.web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<TareaEntity> Tareas { get; set; }
    }
}
