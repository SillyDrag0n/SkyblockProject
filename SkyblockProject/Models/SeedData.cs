using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SkyblockProject.Data;
using System;
using System.Linq;

namespace SkyblockProject.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SkyblockProjectContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SkyblockProjectContext>>()))
            {
                //Look for any collections.
                if (!context.Collection.Any())
                {
                    context.Collection.AddRange(
                        new Collection
                        {
                            CollectionTitle = "Kaktus",
                            Fk_CollectionGroup = 1,
                            CollectionLevel = 1,
                            CollectionNeededExp = 100,
                            CollectionUnlock = "Kaktus Minion Rezept"
                        },
                        new Collection
                        {
                            CollectionTitle = "Kaktus",
                            Fk_CollectionGroup = 1,
                            CollectionLevel = 2,
                            CollectionNeededExp = 250,
                            CollectionUnlock = "Kaktus Rüstung Rezept"
                        },
                        new Collection
                        {
                            CollectionTitle = "Kaktus",
                            Fk_CollectionGroup = 1,
                            CollectionLevel = 3,
                            CollectionNeededExp = 500,
                            CollectionUnlock = "Resistenz Trank Rezept"
                        },
                        new Collection
                        {
                            CollectionTitle = "Kaktus",
                            Fk_CollectionGroup = 1,
                            CollectionLevel = 4,
                            CollectionNeededExp = 1000,
                            CollectionUnlock = "Verzaubertes Kaktusgrün Rezept"
                        },
                        new Collection
                        {
                            CollectionTitle = "Kaktus",
                            Fk_CollectionGroup = 1,
                            CollectionLevel = 5,
                            CollectionNeededExp = 2500,
                            CollectionUnlock = "Wüsten Insel Rezept"
                        },
                        new Collection
                        {
                            CollectionTitle = "Kaktus",
                            Fk_CollectionGroup = 1,
                            CollectionLevel = 6,
                            CollectionNeededExp = 5000,
                            CollectionUnlock = "Verzauberungs Buch (Durchdringen 1) Rezept"
                        },
                        new Collection
                        {
                            CollectionTitle = "Kaktus",
                            Fk_CollectionGroup = 1,
                            CollectionLevel = 7,
                            CollectionNeededExp = 10000,
                            CollectionUnlock = "Verzauberungs Buch (Dornen 2) Rezept"
                        },
                        new Collection
                        {
                            CollectionTitle = "Kaktus",
                            Fk_CollectionGroup = 1,
                            CollectionLevel = 8,
                            CollectionNeededExp = 25000,
                            CollectionUnlock = "Verzauberter Kaktus Rezept"
                        },
                        new Collection
                        {
                            CollectionTitle = "Kaktus",
                            Fk_CollectionGroup = 1,
                            CollectionLevel = 9,
                            CollectionNeededExp = 50000,
                            CollectionUnlock = "+ 5000 Farming Erfahrung"
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
