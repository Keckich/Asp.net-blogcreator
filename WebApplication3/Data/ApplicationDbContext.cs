using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<NotificationUser> UserNotifications { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Post>().HasOne(p => p.Category).WithMany(c => c.Posts).HasForeignKey(p => p.CategoryId).OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<Post>().HasMany(p => p.Comments).WithOne(c => c.Post).HasForeignKey(c => c.PostId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Comment>().HasMany(c => c.Likes).WithOne(l => l.Comment).HasForeignKey(l => l.CommentId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<ApplicationUser>().HasMany(u => u.Posts).WithOne(p => p.User).HasForeignKey(p => p.Author).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<ApplicationUser>().HasMany(u => u.Comments).WithOne(c => c.User).HasForeignKey(c => c.CommentAuthor).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<ApplicationUser>().HasMany(u => u.Likes).WithOne(l => l.User).HasForeignKey(l => l.Username).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<ApplicationUser>().HasMany(u => u.UserNotifications).WithOne(n => n.User).HasForeignKey(n => n.UserId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}