using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Models
{
    public class PostContext : DbContext
    {
       
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        
        public PostContext(DbContextOptions<PostContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasMany(p => p.Tags).WithOne(t => t.Post).HasForeignKey(t => t.Id);
            modelBuilder.Entity<Post>().HasOne(p => p.Category).WithMany(c => c.Posts).HasForeignKey(p => p.CategoryId);
            //modelBuilder.Entity<Tag>().HasMany(t => t.Posts).WithOne(p => p.Tag).HasForeignKey(p => p.Id);
        }
    }
}