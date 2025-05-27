using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcGame.Data;
using System;
using System.Linq;

namespace MvcGame.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcGameContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcGameContext>>()))
        {
            // Look for any movies.
            if (context.Game.Any())
            {
                return;   // DB has been seeded
            }
            context.Game.AddRange(
                new Game
                {
                    Item = 1,
                    Category = "Техника",
                    User = "Михаил",
                    Cost = 14000
                },
                new Game
                {
                    Item = 2,
                    Category = "Книги",
                    User = "Виктор",
                    Cost = 500
                },
                new Game
                {
                    Item = 3,
                    Category = "Продукты",
                    User = "Дмитрий",
                    Cost = 150
                },
                new Game
                {
                    Item = 4,
                    Category = "Техника",
                    User = "Олег",
                    Cost = 50000
                }
            );
            context.SaveChanges();
        }
    }
}