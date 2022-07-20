using Microsoft.EntityFrameworkCore;
using ridly.Models;

namespace ridly.Data
{
    public class Application_DB_Context :DbContext
    {
        public Application_DB_Context(DbContextOptions<Application_DB_Context> options) : base(options) 
        {
        }

        public DbSet<category>? Categories { get; set; }
    }

}
