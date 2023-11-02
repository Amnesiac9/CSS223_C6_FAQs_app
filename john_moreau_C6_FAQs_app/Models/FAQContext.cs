using Microsoft.EntityFrameworkCore;

/*
* John Moreau
* CSS233
* 11/1/2023
*
*
*/

namespace john_moreau_C6_FAQs_app.Models
{
    public class FAQContext : DbContext
    {
        public FAQContext(DbContextOptions<FAQContext> options)
            : base(options)
        {}
        public DbSet<FAQ> FAQs { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Topic> Topics { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<FAQ>().HasData(
                new FAQ
                {
                    Id = 1,
                    Question = "What is Bootstrap?",
                    Answer = "A CSS framework for creating responsive web apps for multiple screen sizes.",
                    TopicId = "bs",
                    CategoryId = "gen",
                }, 
                new FAQ
                {
                    Id = 2,
                    Question = "What is C#?",
                    Answer = "A general purpose object oriented language that uses a concise, Java-like syntax.",
                    TopicId = "cs",
                    CategoryId = "gen",
                },
                new FAQ
                {
                    Id = 3,
                    Question = "What is JavaScript?",
                    Answer = "A general purpose scripting language that executes in a web browser.",
                    TopicId = "js",
                    CategoryId = "gen",
                },
                new FAQ
                {
                    Id = 4,
                    Question = "When was Bootstrap first released?",
                    Answer = "In 2011.",
                    TopicId = "bs",
                    CategoryId = "hist",
                },
                new FAQ
                {
                    Id = 5,
                    Question = "When was C# first released?",
                    Answer = "In 2002.",
                    TopicId = "cs",
                    CategoryId = "hist",
                },
                new FAQ
                {
                    Id = 6,
                    Question = "When was JavaScript first released?",
                    Answer = "In 1995.",
                    TopicId = "js",
                    CategoryId = "hist",
                });

            modelBuilder.Entity<Topic>().HasData(
                new Topic
                {
                    Id = "bs",
                    Name = "Bootstrap"
                },
                new Topic
                {
                    Id = "cs",
                    Name = "C#"
                },
                new Topic
                {
                    Id = "js",
                    Name = "JavaScript"
                });
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = "gen",
                    Name = "General"
                },
                new Category
                {
                    Id = "hist",
                    Name = "History"
                });
        }
    }
}
