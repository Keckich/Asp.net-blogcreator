﻿using System;
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
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Post>().HasMany(p => p.Tags).WithOne(t => t.Post).HasForeignKey(t => t.Id);
            modelBuilder.Entity<Post>().HasOne(p => p.Category).WithMany(c => c.Posts).HasForeignKey(p => p.CategoryId);
            //modelBuilder.Entity<Tag>().HasMany(t => t.Posts).WithOne(p => p.Tag).HasForeignKey(p => p.Id);
            modelBuilder.Entity<Post>().HasMany(p => p.Comments).WithOne(c => c.Post).HasForeignKey(c => c.PostId);
            modelBuilder.Entity<Comment>().HasMany(c => c.Likes).WithOne(l => l.Comment).HasForeignKey(l => l.CommentId);
            modelBuilder.Entity<ApplicationUser>().HasMany(u => u.Posts).WithOne(p => p.User).HasForeignKey(p => p.Author);
            modelBuilder.Entity<ApplicationUser>().HasMany(u => u.Comments).WithOne(c => c.User).HasForeignKey(c => c.CommentId).HasPrincipalKey(u => u.SimpleId);
            modelBuilder.Entity<ApplicationUser>().HasMany(u => u.Likes).WithOne(l => l.User).HasForeignKey(l => l.Id).HasPrincipalKey(u => u.SimpleId); ;
        }
    }
}