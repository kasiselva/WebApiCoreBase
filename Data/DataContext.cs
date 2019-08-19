
using BaseWebApiCore.Models;
using Microsoft.EntityFrameworkCore;

namespace BaseWebApiCore.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    UserName = "selva",
                    Email = "kasiselvakumar@gmail.com",
                    Password = "chella90"
                }
            );
            builder.Entity<User>().HasData(
                new User
                {
                    Id = 2,
                    UserName = "kavi",
                    Email = "kavi@gmail.com",
                    Password = "kavi90"
                }
            );
        }
        public DbSet<User> User { get; set; }
    }
}