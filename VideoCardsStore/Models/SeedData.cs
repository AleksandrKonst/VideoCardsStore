using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace VideoCardsStore.Models {

    public static class SeedData {

        public static void EnsurePopulated(IApplicationBuilder app) {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any()) {
                context.Database.Migrate();
            }

            if (!context.Products.Any()) {
                context.Products.AddRange(
                    new Product {
                        Name = "ASUS GeForce RTX 2060 12GB", Description = "ASUS DUAL GeForce RTX 2060 EVO DUAL-RTX2060-12G-EVO 12GB",
                        Category = "RTX2060", Price = 276
                    },
                    new Product {
                        Name = "ASUS Radeon RX6600 8GB",
                        Description = "ASUS DUAL Radeon RX6600 DUAL-RX6600-8G 8GB",
                        Category = "RX6600", Price = 234
                    },
                    new Product {
                        Name = "MSI GeForce RTX 3070 8GB",
                        Description = "MSI GeForce RTX 3070 VENTUS 3X Plus 8G OC LHR 8GB",
                        Category = "RTX3070", Price = 540
                    },
                    new Product {
                        Name = "EVGA GeForce RTX 3070 8GB",
                        Description = "EVGA GeForce RTX 3070 XC3 Ultra LHR 8GB",
                        Category = "RTX3070", Price = 570
                    },
                    new Product {
                        Name = "GIGABYTE GeForce RTX 3070 8GB",
                        Description = "GIGABYTE GeForce RTX 3070 AORUS Master LHR 8GB",
                        Category = "RTX3070", Price = 584.4m
                    }                   
                );
                context.SaveChanges();
            }
        }
    }
}
