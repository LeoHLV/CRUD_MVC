using Microsoft.EntityFrameworkCore;

namespace CRUDMVC.Models
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options)
        {

        }
        
        // definir quais os modelos que devem ser gerenciados e criados com migrations
        public DbSet<Produto> Produto { get; set; }
    }
}
