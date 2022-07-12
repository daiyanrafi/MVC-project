using Microsoft.EntityFrameworkCore;

namespace ridly.Data
{
    public class Application_DB_Context :DbContext
    {
        public Application_DB_Context(DbContextOptions<Application_DB_Context> options) : base(options) 
        {
        }

        public DbSet<Category>? Categories { get; set; }
    }

}
