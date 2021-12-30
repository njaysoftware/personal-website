using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace blog.Models
{
    public class BlogContext : DbContext
    {
        private delegate int PerformanceCalc(int x, int y);
        public BlogContext(DbContextOptions<BlogContext> options)
            : base(options)
        {
        }

        
        public DbSet<TodoItem> TodoItems { get; set; } = null!;
        public DbSet<Post> Posts {get; set;} = null!;
        
    }
}