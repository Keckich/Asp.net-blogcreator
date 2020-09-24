using System.Linq;
using WebApplication3.Models;

namespace WebApplication3
{
    public class CategoryInitial
    {
        public static void Initialize(PostContext context)
        {
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category
                    {
                        Title = "IT",
                        Description = "Something about technologies, programming etc."
                    },
                    new Category
                    {
                        Title = "Studying",
                        Description = "Everything about school, university or other source of knowledge"
                    },
                    new Category
                    {
                        Title = "Sport and healthy lifestyle",
                        Description = "Your ways of how to be healthy"
                    },
                    new Category
                    {
                        Title = "Nature",
                        Description = "Everything about the world around us"
                    },
                    new Category
                    {
                        Title = "Food",
                        Description = "Your eating preferences"
                    }
                    );
                context.SaveChanges();
            }
        }
        
    }
}