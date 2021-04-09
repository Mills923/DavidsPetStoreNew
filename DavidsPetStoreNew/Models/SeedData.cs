using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace DavidsPetStoreNew.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Giraffe",
                        Description = "Pink with yellow polka dots",
                        Category = "Exotic",
                        Price = 500
                    },
                    new Product
                    {
                        Name = "Turtle",
                        Description = "Box Turtle",
                        Category = "Reptile",
                        Price = 150
                    },
                    new Product
                    {
                        Name = "Deer",
                        Description = "Baby Deer",
                        Category = "Mammal",
                        Price = 100
                    },
                    new Product
                    {
                        Name = "Tucan",
                        Description = "Colorful feathers",
                        Category = "Bird",
                        Price = 90
                    },
                    new Product
                    {
                        Name = "Dog",
                        Description = "Corgi",
                        Category = "Dog",
                        Price = 250
                    },
                    new Product
                    {
                        Name = "Bunny",
                        Description = "Grey feathers with black spikes",
                        Category = "Mammal",
                        Price = 100
                    },
                    new Product
                    {
                        Name = "Chicken",
                        Description = "Pink feet",
                        Category = "Bird",
                        Price = 10
                    },
                    new Product
                    {
                        Name = "Horse",
                        Description = "Long hair with white eyebrows",
                        Category = "Mammal",
                        Price = 1000
                    },
                    new Product
                    {
                        Name = "Alligator",
                        Description = "Blue spikes and orange body",
                        Category = "Reptile",
                        Price = 300
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}