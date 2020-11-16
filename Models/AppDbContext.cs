using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_Application.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Anime> Animes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryID = 1, NameCategory = "Action" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryID = 2, NameCategory = "Comedy/Slice-of-Life" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryID = 3, NameCategory = "Drama/Tragedy" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryID = 4, NameCategory = "Psychological" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryID = 5, NameCategory = "History" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryID = 6, NameCategory = "Mecha/Military" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryID = 7, NameCategory = "Supernatural/Magic" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryID = 8, NameCategory = "Romance" });

            modelBuilder.Entity<Blog>().HasData(new Blog
            {
                BlogID = 1,
                Name = "Anime for Beginners: 20 Pieces of Essential Viewing",
                Image = "",
                Description = "Ahihihi test",
                CategoryID = 1,
                Rate = 5,
                Viewed = 1000,
                CreatedDate = "01 March 2020"
            });
            modelBuilder.Entity<Blog>().HasData(new Blog
            {
                BlogID = 2,
                Name = "Anime for Beginners: 20 Pieces of Essential Viewing",
                Image = "",
                Description = "Ahihihi test",
                CategoryID = 2,
                Rate = 5,
                Viewed = 1000,
                CreatedDate = "01 March 2020"
            });
            modelBuilder.Entity<Blog>().HasData(new Blog
            {
                BlogID = 3,
                Name = "Anime for Beginners: 20 Pieces of Essential Viewing",
                Image = "",
                Description = "Ahihihi test",
                CategoryID = 3,
                Rate = 5,
                Viewed = 1000,
                CreatedDate = "01 March 2020"
            });
        }
    }
}
