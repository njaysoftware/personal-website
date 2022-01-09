using Microsoft.EntityFrameworkCore;

namespace blog.Models
{
    public class BlogContext : DbContext
    {
        private delegate int PerformanceCalc(int x, int y);
        public BlogContext(DbContextOptions<BlogContext> options)
            : base(options)
        {
        }

        
        public DbSet<Post> Posts {get; set;} = null!;
        public DbSet<Admin> Admins {get; set;} = null!;
    }
}