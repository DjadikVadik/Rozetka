using Microsoft.EntityFrameworkCore;

namespace Rozetka
{
    public class Context : DbContext
    { 
        public DbSet<User> Users { get; set; }  

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Test;Trusted_Connection=True;");
        }
    }
}
