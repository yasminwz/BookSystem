using Microsoft.EntityFrameworkCore;

namespace BookSystem.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
           : base(options)
        {

        }
        public DbSet<Book> Book { get; set; }

    }
}
