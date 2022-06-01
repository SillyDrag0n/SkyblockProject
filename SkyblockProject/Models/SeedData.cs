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
                        //Kaktus Collection
                            new Collection
                            {
                                CollectionTitle = "Kaktus",
                                CollectionLevel = 1,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Kaktus Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kaktus",
                                CollectionLevel = 2,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Kaktus Rüstung Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kaktus",
                                CollectionLevel = 3,
                                CollectionNeededExp = 500,
                                CollectionUnlock = "Resistenz Trank Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kaktus",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzaubertes Kaktusgrün Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kaktus",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Wüsten Insel Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kaktus",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Verzauberungs Buch (Durchdringen I) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kaktus",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Verzauberungs Buch (Dornen II) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kaktus",
                                CollectionLevel = 8,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Verzauberter Kaktus Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kaktus",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "+ 5000 Farming Erfahrung"
                            },

                        //Karotten Collection
                            new Collection
                            {
                                CollectionTitle = "Karotte",
                            CollectionLevel = 1,
                            CollectionNeededExp = 100,
                            CollectionUnlock = "Karotten Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Karotte",
                                CollectionLevel = 2,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Einfache Karotten-Bonbons Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Karotte",
                                CollectionLevel = 3,
                                CollectionNeededExp = 500,
                                CollectionUnlock = "Karotten Köder Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Karotte",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1700,
                                CollectionUnlock = "Verzauberte Karotte Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Karotte",
                                CollectionLevel = 5,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Verzauberte Karotte am Stock Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Karotte",
                                CollectionLevel = 6,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Super Karotten-Bonbon Rezept & Super Fang-Ei Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Karotte",
                                CollectionLevel = 7,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Verzauberte Goldene Karotte Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Karotte",
                                CollectionLevel = 8,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Hervorragendes Karotten-Bonbon Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Karotte",
                                CollectionLevel = 9,
                                CollectionNeededExp = 100000,
                                CollectionUnlock = "Mega Fang-Ei Rezept"
                            },

                        //Kakao Bohnen Collection
                            new Collection
                            {
                                CollectionTitle = "Kakao",
                                CollectionLevel = 1,
                                CollectionNeededExp = 75,
                                CollectionUnlock = "Kakao Bohnen Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kakao",
                                CollectionLevel = 2,
                                CollectionNeededExp = 200,
                                CollectionUnlock = "+20 Farming Erfahrung"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kakao",
                                CollectionLevel = 3,
                                CollectionNeededExp = 500,
                                CollectionUnlock = "Portal zur Pilz Wüste Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kakao",
                                CollectionLevel = 4,
                                CollectionNeededExp = 2000,
                                CollectionUnlock = "Verzauberte Kakao Bohne Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kakao",
                                CollectionLevel = 5,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Reiseschriftrolle zur Pilz Inseln Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kakao",
                                CollectionLevel = 6,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Verzauberter Keks Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kakao",
                                CollectionLevel = 7,
                                CollectionNeededExp = 20000,
                                CollectionUnlock = "Adrenalin Trank Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kakao",
                                CollectionLevel = 8,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Verzaubertes Buch (Nachfüllen I) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kakao",
                                CollectionLevel = 9,
                                CollectionNeededExp = 100000,
                                CollectionUnlock = "+ 10000 Farming Erfahrung"
                            },

                        //Feder Collection
                            new Collection
                            {
                                CollectionTitle = "Feder",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Verzaubertes Buch (Projektilschutz IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Feder",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Verzaubertes Buch (Federfall IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Feder",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Bogenschiessen Trank Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Feder",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Feder Talisman Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Feder",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Verzauberte Feder Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Feder",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Verzaubertes Buch (Drachen Tracer IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Feder",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Feder Ring Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Feder",
                                CollectionLevel = 8,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Verzaubertes Buch (Scharfschütze II) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Feder",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Feder Artefakt Rezept"
                            },

                        //Leder Collection
                            new Collection
                            {
                                CollectionTitle = "Leder",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Kuh Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Leder",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Kuh Hut Rezept & Milch Eimer Handel"
                            },
                            new Collection
                            {
                                CollectionTitle = "Leder",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Kleiner Rucksack Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Leder",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzaubertes rohes Rindfleisch Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Leder",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Mittlerer Rucksack Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Leder",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Verzaubertes Leder Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Leder",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Verzaubertes Leder Rezept"
                            }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
