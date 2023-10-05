using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace TODO.WebApi.Models
{
    public class ReviewAppDbContext: DbContext
    {
        public ReviewAppDbContext (DbContextOptions<ReviewAppDbContext> options) : base(options) { }

        public DbSet <User> User { get; set; }
        public DbSet<Books> Books { get; set; }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        //modelBuilder.Entity<User>().ToTable("Users"); {
        // modelBuilder.Entity<User>().ToTable("Users");
        //modelBuilder.Entity<Books>().ToTable("Books");

    }

}
