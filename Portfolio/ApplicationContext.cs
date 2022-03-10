using Microsoft.EntityFrameworkCore;
using Portfolio.Models;

namespace Portfolio
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options) { }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}
