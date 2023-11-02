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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<FAQ>().HasData(
                new FAQ
                {
                    Id = 1,
                    Question = "What is Bootstrap?",
                    Answer = "A CSS framework for creating responsive web apps for multiple screen sizes.",
                    Topic = "Bootstrap",
                    Category = "General",
                }, 
                new FAQ
                {
                    Id = 2,
                    Question = "What is C#?",
                    Answer = "A general purpose object oriented language that uses a concise, Java-like syntax.",
                    Topic = "C#",
                    Category = "General",
                },
                new FAQ
                {
                    Id = 3,
                    Question = "What is JavaScript?",
                    Answer = "A general purpose scripting language that executes in a web browser.",
                    Topic = "JavaScript",
                    Category = "General",
                },
                new FAQ
                {
                    Id = 4,
                    Question = "When was Bootstrap first released?",
                    Answer = "In 2011.",
                    Topic = "Bootstrap",
                    Category = "History",
                },
                new FAQ
                {
                    Id = 5,
                    Question = "When was C# first released?",
                    Answer = "In 2002.",
                    Topic = "C#",
                    Category = "History",
                },
                new FAQ
                {
                    Id = 6,
                    Question = "When was JavaScript first released?",
                    Answer = "In 1995.",
                    Topic = "JavaScript",
                    Category = "History",
                }); 
        }
    }
}
