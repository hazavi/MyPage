using BookLibrary.Model;
using Microsoft.EntityFrameworkCore;
using MyPage.Model;
using System.Security.Cryptography.X509Certificates;

namespace MyPage.Data
{
    public class PageDbContext : DbContext
    {
        public PageDbContext(DbContextOptions<PageDbContext> options)
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Books> Books { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(e => e.CreateDate)
                .HasDefaultValueSql("GETDATE()");
        }
    }
}
