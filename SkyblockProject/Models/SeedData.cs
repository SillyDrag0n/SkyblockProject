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
                        
                    //--Farming Collection
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
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Sattel Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Leder",
                                CollectionLevel = 8,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Grosser Rucksack Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Leder",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Pferd Haustier Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Leder",
                                CollectionLevel = 10,
                                CollectionNeededExp = 100000,
                                CollectionUnlock = "Grösserer Rucksack Rezept"
                            },
                            
                        //Melonen Collection
                            new Collection
                            {
                                CollectionTitle = "Melone",
                                CollectionLevel = 1,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Melonen Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Melone",
                                CollectionLevel = 2,
                                CollectionNeededExp = 500,
                                CollectionUnlock = "+ 50 Farming Erfahrung"
                            },
                            new Collection
                            {
                                CollectionTitle = "Melone",
                                CollectionLevel = 3,
                                CollectionNeededExp = 1250,
                                CollectionUnlock = "+ 125 Farming Erfahrung"
                            },
                            new Collection
                            {
                                CollectionTitle = "Melone",
                                CollectionLevel = 4,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Verzauberte Melone Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Melone",
                                CollectionLevel = 5,
                                CollectionNeededExp = 15500,
                                CollectionUnlock = "Verzauberte glitzernde Melone Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Melone",
                                CollectionLevel = 6,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Verzauberter Melonenblock Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Melone",
                                CollectionLevel = 7,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "+ 5000 Farming Erfahrung"
                            },
                            new Collection
                            {
                                CollectionTitle = "Melone",
                                CollectionLevel = 8,
                                CollectionNeededExp = 100000,
                                CollectionUnlock = "+ 10000 Farming Erfahrung"
                            },
                            new Collection
                            {
                                CollectionTitle = "Melone",
                                CollectionLevel = 9,
                                CollectionNeededExp = 250000,
                                CollectionUnlock = "+ 25000 Farming Erfahrung"
                            },

                        //Pilz Collection
                            new Collection
                            {
                                CollectionTitle = "Pilz",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Pilz Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Pilz",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Myzel Handel"
                            },
                            new Collection
                            {
                                CollectionTitle = "Pilz",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Pilz Rüstungsset Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Pilz",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Magische Pilzsuppe Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Pilz",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Brauner/roter Pilzblock Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Pilz",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Verzauberter brauner/roter Pilz Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Pilz",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Nachtsicht Charm Rezept & Mystische Pilzsuppe Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Pilz",
                                CollectionLevel = 8,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Verzauberter brauner/roter Pilzblock Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Pilz",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Fledermaus Haustier Rezept"
                            },

                        //Hammelfleisch Collection
                            new Collection
                            {
                                CollectionTitle = "Hammelfleisch",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Schaf Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Hammelfleisch",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "+ 10 Farming Erfahrung"
                            },
                            new Collection
                            {
                                CollectionTitle = "Hammelfleisch",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "+ 25 Farming Erfahrung"
                            },
                            new Collection
                            {
                                CollectionTitle = "Hammelfleisch",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Mana Trank Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Hammelfleisch",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Verzaubertes Hammelfleisch Rezept & kleiner Zucht Sack Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Hammelfleisch",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Verzaubertes Buch (Regenbogen I) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Hammelfleisch",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Mittleres Schaf Haustier Rezept & Zucht Sack Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Hammelfleisch",
                                CollectionLevel = 8,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Verzaubertes, gekochtes Hammelfleisch Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Hammelfleisch",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Polymorphstab Rezept & Grosser Zucht Rucksack Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Hammelfleisch",
                                CollectionLevel = 10,
                                CollectionNeededExp = 100000,
                                CollectionUnlock = "Riesiger, verzauberter Zucht Rucksack Rezept"
                            },

                        //Netherwarzen Minion
                            new Collection
                            {
                                CollectionTitle = "Netherwarzen",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Netherwarzen Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Netherwarzen",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Kleines Trank Rucksack Upgrade Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Netherwarzen",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Trank Affinitäts Talisman Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Netherwarzen",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzauberte Netherwarze Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Netherwarzen",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Mittleres Trank Rucksack Upgrade Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Netherwarzen",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "+ 500 Alchemie Erfahrung"
                            },
                            new Collection
                            {
                                CollectionTitle = "Netherwarzen",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Trank Affinitäts Ring Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Netherwarzen",
                                CollectionLevel = 8,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Grosses Trank Rucksack Upgrade Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Netherwarzen",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Trank Affinitäts Artefakt Rezept"
                            },

                        //Kartoffel Collection
                            new Collection
                            {
                                CollectionTitle = "Kartoffel",
                                CollectionLevel = 1,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Kartoffel Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kartoffel",
                                CollectionLevel = 2,
                                CollectionNeededExp = 200,
                                CollectionUnlock = "Portal zur Scheune Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kartoffel",
                                CollectionLevel = 3,
                                CollectionNeededExp = 500,
                                CollectionUnlock = "Impfungstalisman Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kartoffel",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1750,
                                CollectionUnlock = "Verzauberte Kartoffel Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kartoffel",
                                CollectionLevel = 5,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Gifttrank Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kartoffel",
                                CollectionLevel = 6,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Reiseschriftrolle zur Scheune Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kartoffel",
                                CollectionLevel = 7,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Verzauberte gebackene Kartoffel Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kartoffel",
                                CollectionLevel = 8,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Heisses Kartoffelbuch Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kartoffel",
                                CollectionLevel = 9,
                                CollectionNeededExp = 100000,
                                CollectionUnlock = "+ 10000 Farming Erfahrung"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kartoffel",
                                CollectionLevel = 9,
                                CollectionNeededExp = 100000,
                                CollectionUnlock = "+ 10000 Farming Erfahrung"
                            },

                        //Kürbis Collection
                            new Collection
                            {
                                CollectionTitle = "Kürbis",
                                CollectionLevel = 1,
                                CollectionNeededExp = 40,
                                CollectionUnlock = "Kürbis Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kürbis",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Kürbis Rüstung Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kürbis",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Verzauberter Kürbis Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kürbis",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzaubertes Buch (Kubismus IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kürbis",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Trainings Dummy Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kürbis",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Farmer Orb Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kürbis",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Laternen Helm Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kürbis",
                                CollectionLevel = 8,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Farm Kristal Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kürbis",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Farmer Stiefel Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kürbis",
                                CollectionLevel = 10,
                                CollectionNeededExp = 100000,
                                CollectionUnlock = "Polierter Kürbis Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kürbis",
                                CollectionLevel = 11,
                                CollectionNeededExp = 250000,
                                CollectionUnlock = "Landwirts Stiefel Rezept"
                            },

                        //Rohes Huhn Collection
                            new Collection
                            {
                                CollectionTitle = "Huhn",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Huhn Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Huhn",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Brücken-Ei Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Huhn",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Hühner Kopf Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Huhn",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzaubertes rohes Huhn Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Huhn",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Verzaubertes Ei Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Huhn",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Huhn Haustier Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Huhn",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Verzauberter Kuchen Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Huhn",
                                CollectionLevel = 8,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Agilitäts Trank Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Huhn",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Super verzaubertes Ei Rezept"
                            },

                        //Rohes Schwein Collection
                            new Collection
                            {
                                CollectionTitle = "Schwein",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Schwein Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schwein",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "+ 10 Farming Erfahrung"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schwein",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Schwein Haustier Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schwein",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzaubertes Schweinefleisch Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schwein",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Sparschwein Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schwein",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "+ 500 Farming Erfahrung"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schwein",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Verzaubertes, gegrilltes Schweinefleisch Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schwein",
                                CollectionLevel = 8,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Schweineman Haustier Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schwein",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Schweineman Schwert Rezept"
                            },

                        //Roher Hase Collection
                            new Collection
                            {
                                CollectionTitle = "Hase",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Hasen Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Hase",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Hasen Haustier Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Hase",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Hasen Trank Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Hase",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzauberte Hasenpfote Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Hase",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Verzaubertes Buch (Glück IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Hase",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Verzaubertes Hasen Leder Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Hase",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Verzaubertes Buch (Glück des Meeres IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Hase",
                                CollectionLevel = 8,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Haustier Glücks Trank Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Hase",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "+ 5000 Farming Erfahrung"
                            },

                        //Samen Colletion
                            new Collection
                            {
                                CollectionTitle = "Samen",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Dreck Handel"
                            },
                            new Collection
                            {
                                CollectionTitle = "Samen",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Lehm Handel"
                            },
                            new Collection
                            {
                                CollectionTitle = "Samen",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Langrass Handel"
                            },
                            new Collection
                            {
                                CollectionTitle = "Samen",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Farn Handel"
                            },
                            new Collection
                            {
                                CollectionTitle = "Samen",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Toter Busch Handel"
                            },
                            new Collection
                            {
                                CollectionTitle = "Samen",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Doppellanges Grass Handel"
                            },
                            new Collection
                            {
                                CollectionTitle = "Samen",
                                CollectionLevel = 7,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Doppellanggrass Handel"
                            },

                        //Zuckerrohr Collection,
                            new Collection
                            {
                                CollectionTitle = "Zuckerrohr",
                                CollectionLevel = 1,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Zuckerrohr Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Zuckerrohr",
                                CollectionLevel = 2,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Geschwindigkeits Talisman Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Zuckerrohr",
                                CollectionLevel = 3,
                                CollectionNeededExp = 500,
                                CollectionUnlock = "+ 50 Farming Erfahrung"
                            },
                            new Collection
                            {
                                CollectionTitle = "Zuckerrohr",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzauberter Zucker Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Zuckerrohr",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2000,
                                CollectionUnlock = "Verzaubertes Papier Rezept & Geschwindigkeits Ring Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Zuckerrohr",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Verzaubertes Bücherregal Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Zuckerrohr",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Zufälliges Buch Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Zuckerrohr",
                                CollectionLevel = 8,
                                CollectionNeededExp = 20000,
                                CollectionUnlock = "Verzaubertes Zuckerrohr Rezept & Geschwindigkeits Artifakt Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Zuckerrohr",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Flitzer Rüstungsset Rezept"
                            },

                        //Weizen Collection,
                            new Collection
                            {
                                CollectionTitle = "Weizen",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Weizen Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Weizen",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Verzaubertes Buch (Ernte V) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Weizen",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Bauernanzug-Set Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Weizen",
                                CollectionLevel = 4,
                                CollectionNeededExp = 500,
                                CollectionUnlock = "Farming Talisman Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Weizen",
                                CollectionLevel = 5,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzaubertes Brot Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Weizen",
                                CollectionLevel = 6,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Farming Insel Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Weizen",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Verzauberte Heuballen Rezept & kleiner Agronomie Sack"
                            },
                            new Collection
                            {
                                CollectionTitle = "Weizen",
                                CollectionLevel = 8,
                                CollectionNeededExp = 15000,
                                CollectionUnlock = "Mittlerer Agronomie Sack"
                            },
                            new Collection
                            {
                                CollectionTitle = "Weizen",
                                CollectionLevel = 9,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Bauernrüstungs-Set Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Weizen",
                                CollectionLevel = 10,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Grosser Agronomie Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Weizen",
                                CollectionLevel = 11,
                                CollectionNeededExp = 100000,
                                CollectionUnlock = "Fest verschnürtes Heuballen Rezept"
                            },

                    //++Farming Collection
                    //--Mining Collection

                        //Kohle Collection
                            new Collection
                            {
                                CollectionTitle = "Kohle",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Kohle Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kohle",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Verzaubertes Buch (Schmelzpunkt I) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kohle",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Eile Trank Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kohle",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzauberte Kohle Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kohle",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Verzauberte Holzkohle Rezept & kleiner Bergbau Sack Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kohle",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Reiseschriftrolle zur Gold Mine Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kohle",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Verzauberter Kohleblock Rezept & mittlerer Bergbau Sack Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kohle",
                                CollectionLevel = 8,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Verzauberter Lavaeimer Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kohle",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Wither Skelet Haustier Rezept & grosser Berbau Sack Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kohle",
                                CollectionLevel = 10,
                                CollectionNeededExp = 100000,
                                CollectionUnlock = "Verzauberter grosser Berbau Sack Rezept"
                            },

                        //Bruchstein Collection,
                            new Collection
                            {
                                CollectionTitle = "Bruchstein",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Bruchstein Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Bruchstein",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Stein Plattform Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Bruchstein",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Automatische Schmelze Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Bruchstein",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzauberter Bruchstein Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Bruchstein",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Kompaktor Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Bruchstein",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Silberfisch Haustier Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Bruchstein",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Bergmannsausrüstung Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Bruchstein",
                                CollectionLevel = 8,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Hyper Ofen Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Bruchstein",
                                CollectionLevel = 9,
                                CollectionNeededExp = 40000,
                                CollectionUnlock = "Eile Ring Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Bruchstein",
                                CollectionLevel = 10,
                                CollectionNeededExp = 70000,
                                CollectionUnlock = "Super Kompaktor 3000 Rezept"
                            },

                        //Diamanten Collection
                            new Collection
                            {
                                CollectionTitle = "Diamant",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Diamanten Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Diamant",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Verzaubertes Buch (Exekutieren IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Diamant",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Portal zu den tiefen Grotten Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Diamant",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzauberter Diamant Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Diamant",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Verzaubertes Nuch (Kritisch IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Diamant",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Diamanten Verbreitung Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Diamant",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Verhärtete Diamantenrüstung Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Diamant",
                                CollectionLevel = 8,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Verzauberter Diamantenblock Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Diamant",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Perfekte Rüstung Rezept"
                            },

                        //Smaragd Collection
                            new Collection
                            {
                                CollectionTitle = "Smaragd",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Smaragd Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Smaragd",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Talisman der Münzen Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Smaragd",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Magnet Talisman Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Smaragd",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzauberter Smaragd Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Smaragd",
                                CollectionLevel = 5,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Smaragd Ring Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Smaragd",
                                CollectionLevel = 6,
                                CollectionNeededExp = 15000,
                                CollectionUnlock = "Persönliches Bank Upgrade Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Smaragd",
                                CollectionLevel = 7,
                                CollectionNeededExp = 30000,
                                CollectionUnlock = "Verzauberter Smaragdblock Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Smaragd",
                                CollectionLevel = 8,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Smaragd Klinge Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Smaragd",
                                CollectionLevel = 9,
                                CollectionNeededExp = 100000,
                                CollectionUnlock = "Smaragdrüstung Rezept"
                            },

                        //End Stein Collection
                            new Collection
                            {
                                CollectionTitle = "End Stein",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "End Stein Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "End Stein",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "End Biom Stock Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "End Stein",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Portal zum End Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "End Stein",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzauberter End Stein Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "End Stein",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Stille Block Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "End Stein",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Eile Block Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "End Stein",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Endermite Haustier-Ei Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "End Stein",
                                CollectionLevel = 8,
                                CollectionNeededExp = 15000,
                                CollectionUnlock = "Reiseschriftrolle zum End Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "End Stein",
                                CollectionLevel = 9,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Katalysator Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "End Stein",
                                CollectionLevel = 10,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "End Stein Schwert Rezept"
                            },

                        //Edelstein Collection
                            new Collection
                            {
                                CollectionTitle = "Edelstein",
                                CollectionLevel = 1,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Kleiner Edelstein Sack Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Edelstein",
                                CollectionLevel = 2,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Mangelhafter Edelstein Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Edelstein",
                                CollectionLevel = 3,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Mittlerer Edelstein Sack Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Edelstein",
                                CollectionLevel = 4,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Talisman der Kraft Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Edelstein",
                                CollectionLevel = 5,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Guter Edelstein Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Edelstein",
                                CollectionLevel = 6,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Ring der Stärke Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Edelstein",
                                CollectionLevel = 7,
                                CollectionNeededExp = 100000,
                                CollectionUnlock = "Kraft Schriftrolle Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Edelstein",
                                CollectionLevel = 8,
                                CollectionNeededExp = 250000,
                                CollectionUnlock = "Verzauberungs Buch (Unberührt I) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Edelstein",
                                CollectionLevel = 9,
                                CollectionNeededExp = 500000,
                                CollectionUnlock = "Mangelloser Edelstein Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Edelstein",
                                CollectionLevel = 10,
                                CollectionNeededExp = 1000000,
                                CollectionUnlock = "Artifakt der Stärke Rezept & perfekter Edelstein Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Edelstein",
                                CollectionLevel = 11,
                                CollectionNeededExp = 2000000,
                                CollectionUnlock = "Edelsteinhandschuh Rezept"
                            },

                        //Glowstone Collection
                            new Collection
                            {
                                CollectionTitle = "Glowstone",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Glowstone Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Glowstone",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Portal zur lodernden Festung Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Glowstone",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "+ 75 Mining Erfahrung Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Glowstone",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzauberter Glowstonestaub Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Glowstone",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Reiseschriftrolle zur lodernden Festung Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Glowstone",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Verzaubertes Glowstone Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Glowstone",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Verzauberte Redstonelampe Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Glowstone",
                                CollectionLevel = 8,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Glowstone Hut Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Glowstone",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "+ 15000 Mining Erfahrung Rezept"
                            },

                        //Gold Collection
                            new Collection
                            {
                                CollectionTitle = "Gold",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Gold Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Gold",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Feuersteinschaufel Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Gold",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Verzaubertes Buch (Plünderung II) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Gold",
                                CollectionLevel = 4,
                                CollectionNeededExp = 500,
                                CollectionUnlock = "Portal zur Goldmine Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Gold",
                                CollectionLevel = 5,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzaubertes Gold Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Gold",
                                CollectionLevel = 6,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Absorptions Trank Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Gold",
                                CollectionLevel = 7,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Verzaubertes Buch (Aasfresser II) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Gold",
                                CollectionLevel = 8,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Verzauberter Goldblock Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Gold",
                                CollectionLevel = 9,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Verzaubertes Buch (Glück II) Rezept"
                            },

                            //Kies Collection
                            new Collection
                            {
                                CollectionTitle = "Kies",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Kies Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kies",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Feuersteinschaufel Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kies",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Portal zur Spinnenhöhle Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kies",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzaubertes Buch (Schärfe IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kies",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Verzauberter Feuerstein Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kies",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Verzaubertes Buch (Erstschlag III) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kies",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Kritischer Trank Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kies",
                                CollectionLevel = 8,
                                CollectionNeededExp = 15000,
                                CollectionUnlock = "Reiseschriftrolle zur Spinnenhöhle Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kies",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "+ 5000 Mining Erfahrung"
                            },

                        //Hartstein Collection
                            new Collection
                            {
                                CollectionTitle = "Hartstein",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Hartstein Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Hartstein",
                                CollectionLevel = 2,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Hitzerüstung Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Hartstein",
                                CollectionLevel = 3,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Verzauberter Hartstein Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Hartstein",
                                CollectionLevel = 4,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Heisses Zeug Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Hartstein",
                                CollectionLevel = 5,
                                CollectionNeededExp = 150000,
                                CollectionUnlock = "Flammenbrecherrüstung Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Hartstein",
                                CollectionLevel = 6,
                                CollectionNeededExp = 300000,
                                CollectionUnlock = "Konzentrierter Stein Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Hartstein",
                                CollectionLevel = 7,
                                CollectionNeededExp = 300000,
                                CollectionUnlock = "Silex Rezept"
                            },

                        //Eis Collection
                            new Collection
                            {
                                CollectionTitle = "Ice",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Eis Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Ice",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Verzaubertes Buch (Frostläufer I) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Ice",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Packeis Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Ice",
                                CollectionLevel = 4,
                                CollectionNeededExp = 500,
                                CollectionUnlock = "Verzaubertes Eis Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Ice",
                                CollectionLevel = 5,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Magischer Wassereimer Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Ice",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Eisköder Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Ice",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Verzaubertes Packeis Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Ice",
                                CollectionLevel = 8,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Gefrorene Sense Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Ice",
                                CollectionLevel = 9,
                                CollectionNeededExp = 100000,
                                CollectionUnlock = "Gefrorene Blazerüstung Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Ice",
                                CollectionLevel = 10,
                                CollectionNeededExp = 250000,
                                CollectionUnlock = "Schneckenangel Rezept"
                            },

                        //Eisen Collection
                            new Collection
                            {
                                CollectionTitle = "Eisen",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Eisen Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Eisen",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Golem Hut Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Eisen",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Verzaubertes Buch (Schutz IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Eisen",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzaubertes Eisen Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Eisen",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Budget-Trichter Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Eisen",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Golemrüstungs Set Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Eisen",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Verzauberter Eisenblock Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Eisen",
                                CollectionLevel = 8,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Golemschwert Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Eisen",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Verzauberter Trichter Rezept & persönlicher Löscher 4000 Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Eisen",
                                CollectionLevel = 10,
                                CollectionNeededExp = 100000,
                                CollectionUnlock = "Persönlicher Löscher 5000 Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Eisen",
                                CollectionLevel = 11,
                                CollectionNeededExp = 200000,
                                CollectionUnlock = "Persönlicher Löscher 6000 Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Eisen",
                                CollectionLevel = 12,
                                CollectionNeededExp = 400000,
                                CollectionUnlock = "Persönlicher Löscher 7000 Rezept"
                            },

                        //Lapis Collection
                            new Collection
                            {
                                CollectionTitle = "Lapis",
                                CollectionLevel = 1,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Lapis Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Lapis",
                                CollectionLevel = 2,
                                CollectionNeededExp = 500,
                                CollectionUnlock = "Erfahrungsfläschchen Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Lapis",
                                CollectionLevel = 3,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzaubertes Buch (Erfahrung II) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Lapis",
                                CollectionLevel = 4,
                                CollectionNeededExp = 2000,
                                CollectionUnlock = "Verzaubertes Lapis Lazuli Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Lapis",
                                CollectionLevel = 5,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Grosses Erfahrungsfläschchen Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Lapis",
                                CollectionLevel = 6,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Erfahrungs Trank Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Lapis",
                                CollectionLevel = 7,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Verzauberter Lapisblock Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Lapis",
                                CollectionLevel = 8,
                                CollectionNeededExp = 100000,
                                CollectionUnlock = "Titanische Erfahrungsfläschchen Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Lapis",
                                CollectionLevel = 9,
                                CollectionNeededExp = 150000,
                                CollectionUnlock = "Erfahrungs Artifakt Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Lapis",
                                CollectionLevel = 10,
                                CollectionNeededExp = 250000,
                                CollectionUnlock = "Textbuch Rezept"
                            },

                        //Mithril Collection
                            new Collection
                            {
                                CollectionTitle = "Mithril",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Mithril Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Mithril",
                                CollectionLevel = 2,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Höhlenforscher Trank Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Mithril",
                                CollectionLevel = 3,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzaubertes Mithril Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Mithril",
                                CollectionLevel = 4,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Mithrilkristall Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Mithril",
                                CollectionLevel = 5,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Mithrilmantel Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Mithril",
                                CollectionLevel = 6,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Zwergen Superkompaktor Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Mithril",
                                CollectionLevel = 7,
                                CollectionNeededExp = 250000,
                                CollectionUnlock = "Mithrilgolem Haustier Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Mithril",
                                CollectionLevel = 8,
                                CollectionNeededExp = 500000,
                                CollectionUnlock = "Mithrilinfusion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Mithril",
                                CollectionLevel = 9,
                                CollectionNeededExp = 1000000,
                                CollectionUnlock = "Beacon I Rezept"
                            },

                        //Quartz Collection
                            new Collection
                            {
                                CollectionTitle = "Quartz",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Quarzt Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Quartz",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Nachtsicherer Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Quartz",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Tagsicherer Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Quartz",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzaubertes Quartz Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Quartz",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Minion Erweiterer Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Quartz",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Verzauberter Quartzblock Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Quartz",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Nachtkristall Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Quartz",
                                CollectionLevel = 8,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Tagkristall Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Quartz",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Solarmodul Rezept"
                            },

                        //Netherrack Collection
                            new Collection
                            {
                                CollectionTitle = "Netherrack",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Netherwarzen Insel Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Netherrack",
                                CollectionLevel = 2,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Wunden Trank Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Netherrack",
                                CollectionLevel = 3,
                                CollectionNeededExp = 500,
                                CollectionUnlock = "Netherziegel Handel Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Netherrack",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzaubertes Netherrack Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Netherrack",
                                CollectionLevel = 5,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Magischer Lavaeimer Rezept"
                            },

                        //Obsidian Collection
                            new Collection
                            {
                                CollectionTitle = "Obsidian",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Obsidian Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Obsidian",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Verzaubertes Buch (Tödlichkeit IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Obsidian",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Gravitations Talisman Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Obsidian",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzaubertes Obsidian Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Obsidian",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Enderkiste Level I Upgrade"
                            },
                            new Collection
                            {
                                CollectionTitle = "Obsidian",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Betäubungstrank Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Obsidian",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Enderkiste Level II Upgrade"
                            },
                            new Collection
                            {
                                CollectionTitle = "Obsidian",
                                CollectionLevel = 8,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Baumenthaupter Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Obsidian",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Enderkiste Level III Upgrade"
                            },
                            new Collection
                            {
                                CollectionTitle = "Obsidian",
                                CollectionLevel = 10,
                                CollectionNeededExp = 100000,
                                CollectionUnlock = "Schmiedeamboss Rezept"
                            },

                        //Redstone Collection
                            new Collection
                            {
                                CollectionTitle = "Redstone",
                                CollectionLevel = 1,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Redstone Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Redstone",
                                CollectionLevel = 2,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Kleines Zubehörrucksack Upgrade"
                            },
                            new Collection
                            {
                                CollectionTitle = "Redstone",
                                CollectionLevel = 3,
                                CollectionNeededExp = 750,
                                CollectionUnlock = "Verzaubertes Buch (Effizienz IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Redstone",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1500,
                                CollectionUnlock = "Verzaubertes Redstone Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Redstone",
                                CollectionLevel = 5,
                                CollectionNeededExp = 3000,
                                CollectionUnlock = "Kompass Talisman Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Redstone",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Wetterstock Rezept & mittleres Zubehörrucksack Upgrade"
                            },
                            new Collection
                            {
                                CollectionTitle = "Redstone",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Reiseschriftrolle zu den tiefen Grotten Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Redstone",
                                CollectionLevel = 8,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Verzauberter Redstoneblock Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Redstone",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Grosses Zubehörrucksack Upgrade & persönlicher Kompaktor 4000 Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Redstone",
                                CollectionLevel = 10,
                                CollectionNeededExp = 200000,
                                CollectionUnlock = "Grösseres Zubehörrucksack Upgrade"
                            },
                            new Collection
                            {
                                CollectionTitle = "Redstone",
                                CollectionLevel = 11,
                                CollectionNeededExp = 400000,
                                CollectionUnlock = "Riesiges Zubehörrucksack Upgrade & persönlicher Kompaktor 5000 Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Redstone",
                                CollectionLevel = 12,
                                CollectionNeededExp = 600000,
                                CollectionUnlock = "Massives Zubehörrucksack Upgrade Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Redstone",
                                CollectionLevel = 13,
                                CollectionNeededExp = 800000,
                                CollectionUnlock = "Gigantisches Zubehörrucksack Upgrade & persönlicher Kompaktor 6000 Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Redstone",
                                CollectionLevel = 14,
                                CollectionNeededExp = 1000000,
                                CollectionUnlock = "Kollosales Zubehörrucksack Upgrade & persönlicher Kompaktor 7000 Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Redstone",
                                CollectionLevel = 15,
                                CollectionNeededExp = 1200000,
                                CollectionUnlock = "Titanisches Zubehörrucksack Upgrade"
                            },
                            new Collection
                            {
                                CollectionTitle = "Redstone",
                                CollectionLevel = 16,
                                CollectionNeededExp = 1400000,
                                CollectionUnlock = "Absurdes Zubehörrucksack Upgrade"
                            },

                        //Sand Collecion
                            new Collection
                            {
                                CollectionTitle = "Sand",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Sand Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Sand",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Roter Sand Handel"
                            },
                            new Collection
                            {
                                CollectionTitle = "Sand",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Seelensand Handel"
                            },
                            new Collection
                            {
                                CollectionTitle = "Sand",
                                CollectionLevel = 4,
                                CollectionNeededExp = 500,
                                CollectionUnlock = "Wüstenbiomstock Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Sand",
                                CollectionLevel = 5,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzauberter Sand Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Sand",
                                CollectionLevel = 6,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Verbrennungstrank Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Sand",
                                CollectionLevel = 7,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Hartglas Rezept"
                            },

                        //Sulphur Collection
                            new Collection
                            {
                                CollectionTitle = "Schwefel",
                                CollectionLevel = 1,
                                CollectionNeededExp = 200,
                                CollectionUnlock = "Streichholz Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schwefel",
                                CollectionLevel = 2,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzaubertes Schwefel Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schwefel",
                                CollectionLevel = 3,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Kleiner Schwefelsack Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schwefel",
                                CollectionLevel = 4,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Totem der Korruption Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schwefel",
                                CollectionLevel = 5,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Mittlerer Nethersack Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schwefel",
                                CollectionLevel = 6,
                                CollectionNeededExp = 15000,
                                CollectionUnlock = "Verzauberter Schwefelblock Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schwefel",
                                CollectionLevel = 7,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Schwefelbogen Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schwefel",
                                CollectionLevel = 8,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Grosser Nethersack Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schwefel",
                                CollectionLevel = 9,
                                CollectionNeededExp = 100000,
                                CollectionUnlock = "Implosionsgürtel Rezept"
                            },

                        //Myzel Collection
                            new Collection
                            {
                                CollectionTitle = "Myzel",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Myzel Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Myzel",
                                CollectionLevel = 2,
                                CollectionNeededExp = 500,
                                CollectionUnlock = "Verdächtige Suppe Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Myzel",
                                CollectionLevel = 3,
                                CollectionNeededExp = 750,
                                CollectionUnlock = "Verzaubertes Myzel Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Myzel",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Pilzbiomstock Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Myzel",
                                CollectionLevel = 5,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Myzel Staub Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Myzel",
                                CollectionLevel = 6,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Verdorbener Boden Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Myzel",
                                CollectionLevel = 7,
                                CollectionNeededExp = 15000,
                                CollectionUnlock = "Verzauberter Myzelblock Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Myzel",
                                CollectionLevel = 8,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Mysterisches Pilzkuh Haustier Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Myzel",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Schimmerndes Lichtrüstung Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Myzel",
                                CollectionLevel = 10,
                                CollectionNeededExp = 100000,
                                CollectionUnlock = "Handschuh der Ansteckung Rezept"
                            },
                    //++Mining Collection

                    //--Combat Collection
                            //Lohenrute Collection
                            new Collection
                            {
                                CollectionTitle = "Lohenrute",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Lohen Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Lohenrute",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Lohenhut Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Lohenrute",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Verzaubertes Buch (Feueraspekt I) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Lohenrute",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzaubertes Lohenpuder Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Lohenrute",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Feuer Talisman Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Lohenrute",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Verzaubertes Buch (Flamme I) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Lohenrute",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Verzauberte Lohenrute Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Lohenrute",
                                CollectionLevel = 8,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Lohenrüstung Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Lohenrute",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Lohen Haustier Rezept"
                            },

                        //Knochen Collection
                            new Collection
                            {
                                CollectionTitle = "Knochen",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Skelet Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Knochen",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Verzaubertes Knochemehl Handel Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Knochen",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Verzaubertes Buch (Kraft IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Knochen",
                                CollectionLevel = 4,
                                CollectionNeededExp = 500,
                                CollectionUnlock = "Skelethut Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Knochen",
                                CollectionLevel = 5,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzauberter Knochen Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Knochen",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Skelet Haustier-Ei Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Knochen",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Wirbelsturm Bogen Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Knochen",
                                CollectionLevel = 8,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Helm des Skelets Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Knochen",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Runaan's Bogen Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Knochen",
                                CollectionLevel = 9,
                                CollectionNeededExp = 150000,
                                CollectionUnlock = "Verzauberter Knochenblock Rezept"
                            },

                            //Enderperlen Collection
                            new Collection
                            {
                                CollectionTitle = "Enderperle",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Enderman Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Enderperle",
                                CollectionLevel = 2,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Verzauberte Enderperle Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Enderperle",
                                CollectionLevel = 3,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzaubertes Buch (Endertöter IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Enderperle",
                                CollectionLevel = 4,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Endinsel Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Enderperle",
                                CollectionLevel = 5,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Enderbogen Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Enderperle",
                                CollectionLevel = 6,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Verzaubertes Enderauge Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Enderperle",
                                CollectionLevel = 7,
                                CollectionNeededExp = 15000,
                                CollectionUnlock = "Telport-Feld Handel & absolute Enderperle Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Enderperle",
                                CollectionLevel = 8,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Aspekt des End Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Enderperle",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Rettende Gnade Rezept"
                            },

                            //Ghasttränen Collection
                            new Collection
                            {
                                CollectionTitle = "Ghastträne",
                                CollectionLevel = 1,
                                CollectionNeededExp = 20,
                                CollectionUnlock = "Ghast Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Ghastträne",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Geisterkopf Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Ghastträne",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Verzaubertes Buch (Riesentöter IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Ghastträne",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzauberte Ghastträne Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Ghastträne",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Verzaubertes Buch (Vampirismus IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Ghastträne",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Silberfänge Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Ghastträne",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Ghastrüstung Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Ghastträne",
                                CollectionLevel = 8,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "+ 2500 Combat Erfahrung"
                            },
                            new Collection
                            {
                                CollectionTitle = "Ghastträne",
                                CollectionLevel = 8,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "+ 5000 Combat Erfahrung"
                            },

                        //Schiesspulver Collection,
                            new Collection
                            {
                                CollectionTitle = "Schiesspulver",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Creeper Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schiesspulver",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Creeperhut Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schiesspulver",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Verzaubertes Buch (Explosionsschutz IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schiesspulver",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzaubertes Schiesspulver Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schiesspulver",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Verzaubertes Buch (Donnerlord IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schiesspulver",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Verzauberte Feuerwerkrakete Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schiesspulver",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Zufälliges Feuerwerk Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schiesspulver",
                                CollectionLevel = 8,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Creeperhosen Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schiesspulver",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Explosiver Bogen Rezept"
                            },

                        //Magmacreme Collection
                            new Collection
                            {
                                CollectionTitle = "Magmacreme",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Magmawürfel Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Magmacreme",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Magmawürfelkopf Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Magmacreme",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Verzaubertes Buch (Feuerschutz IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Magmacreme",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Netherbiomstock Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Magmacreme",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Verzauberte Magmacreme Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Magmacreme",
                                CollectionLevel = 6,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Lavaeimer Handel Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Magmacreme",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Lava Talisman Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Magmacreme",
                                CollectionLevel = 8,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Magmarüstungsset Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Magmacreme",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Magmabogen Rezept"
                            },

                        //Verrottetes Fleisch Collection
                            new Collection
                            {
                                CollectionTitle = "Verrottetes Fleisch",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Zombie Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Verrottetes Fleisch",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Tombie Spitzhacke Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Verrottetes Fleisch",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Verzaubertes Buch (Schlag IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Verrottetes Fleisch",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzaubertes verrottetes Fleisch Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Verrottetes Fleisch",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Zombiehut Rezept & kleiner Combatsack Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Verrottetes Fleisch",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Zombieherz Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Verrottetes Fleisch",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Zombieschwert Rezept & mittlerer Combatsack Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Verrottetes Fleisch",
                                CollectionLevel = 8,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Zombierüstungsset Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Verrottetes Fleisch",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Zombie Haustier Rezept & grosser Combatsack Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Verrottetes Fleisch",
                                CollectionLevel = 10,
                                CollectionNeededExp = 100000,
                                CollectionUnlock = "Grosser, verzauberter Combatsack Rezept"
                            },

                        //Schleimball Collection
                            new Collection
                            {
                                CollectionTitle = "Schleimball",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Schleim Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schleimball",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Schleimhut Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schleimball",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Verzaubertes Buch (Rückschlag I) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schleimball",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Rückschlagtrank Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schleimball",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Verzauberter Schleimball Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schleimball",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Verzaubertes Buch (Schlag I) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schleimball",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Abschussrampe Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schleimball",
                                CollectionLevel = 8,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Verzauberter Schleimblock Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schleimball",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Schleimbogen Rezept"
                            },

                        //Spinnenauge Collection
                            new Collection
                            {
                                CollectionTitle = "Spinnenauge",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Höhlenspinnen Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Spinnenauge",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Spinnenschwert Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Spinnenauge",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Spinnenhut Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Spinnenauge",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzaubertes Spinnenauge Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Spinnenauge",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Verzaubertes Buch (Fluch der Gliederfüssler IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Spinnenauge",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Verzaubertes Buch (Gift IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Spinnenauge",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Verzaubertes, vermentiertes Spinnenauge Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Spinnenauge",
                                CollectionLevel = 8,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "+ 25000 Combat Erfahrung"
                            },
                            new Collection
                            {
                                CollectionTitle = "Spinnenauge",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Springschwert Rezept"
                            },

                        //Faden Collection
                            new Collection
                            {
                                CollectionTitle = "Faden",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Spinnen Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Faden",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Spinnennetz Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Faden",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Köcher Upgrade"
                            },
                            new Collection
                            {
                                CollectionTitle = "Faden",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzauberter Faden Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Faden",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Verzaubertes Buch (Behutsamkeit I) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Faden",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Verzaubertes Buch (Unendlichkeit IV) Rezept & grosser Köcher Upgrade"
                            },
                            new Collection
                            {
                                CollectionTitle = "Faden",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Enterhaken Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Faden",
                                CollectionLevel = 8,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Spinnenschuhe Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Faden",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Spinnen Haustier Rezept & riesiger Köcher Upgrade"
                            },
                    //++Combat Collection

                    //--Foraging Collection
                        //Akazien Collection,
                            new Collection
                            {
                                CollectionTitle = "Akazie",
                                CollectionLevel = 1,
                                CollectionNeededExp = 20,
                                CollectionUnlock = "Akazien Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Akazie",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Akazienblatt Handel Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Akazie",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Portal zum Savannenwald Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Akazie",
                                CollectionLevel = 4,
                                CollectionNeededExp = 500,
                                CollectionUnlock = "Superfackel Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Akazie",
                                CollectionLevel = 5,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Savannenbiomstock Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Akazie",
                                CollectionLevel = 6,
                                CollectionNeededExp = 2000,
                                CollectionUnlock = "Verzaubertes Akazienholz Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Akazie",
                                CollectionLevel = 7,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Savannenbogen Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Akazie",
                                CollectionLevel = 8,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "+ 1000 Foraging Erafhrung"
                            },
                            new Collection
                            {
                                CollectionTitle = "Akazie",
                                CollectionLevel = 9,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Abwehrendekerze Rezept"
                            },

                        //Birken Collection
                            new Collection
                            {
                                CollectionTitle = "Birke",
                                CollectionLevel = 1,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Birken Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Birke",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Birkenblatt Handel Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Birke",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Portal zum Birkenpark Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Birke",
                                CollectionLevel = 4,
                                CollectionNeededExp = 500,
                                CollectionUnlock = "Bildhaueraxt Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Birke",
                                CollectionLevel = 5,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Birkenwaldbiomstock Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Birke",
                                CollectionLevel = 6,
                                CollectionNeededExp = 2000,
                                CollectionUnlock = "Verzaubertes Birkenholz Rezept & kleiner Foragingsack Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Birke",
                                CollectionLevel = 7,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Holzfällerkristall Rezept & mittlerer Foragingsack Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Birke",
                                CollectionLevel = 8,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Reiseschriftrolle zum Park Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Birke",
                                CollectionLevel = 9,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Grosser Foragingsack Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Birke",
                                CollectionLevel = 10,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "Grosser, verzauberter Foragingsack Rezept"
                            },

                        //Dunkles Eichenholz Collection
                            new Collection
                            {
                                CollectionTitle = "Dunkles Eichenholz",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Dunkles Eichenholz Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Dunkles Eichenholz",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Dunkler Eichenholzblatt Handel"
                            },
                            new Collection
                            {
                                CollectionTitle = "Dunkles Eichenholz",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Portal zum dunklen Dickicht Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Dunkles Eichenholz",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Überdachter Waldbiom-Stick Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Dunkles Eichenholz",
                                CollectionLevel = 5,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzaubertes dunkles Eichenholz Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Dunkles Eichenholz",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Überdachte Waldinsel Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Dunkles Eichenholz",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Verzaubertes Buch (Wachstum IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Dunkles Eichenholz",
                                CollectionLevel = 8,
                                CollectionNeededExp = 15000,
                                CollectionUnlock = "+ 2500 Foraging Erfahrung"
                            },
                            new Collection
                            {
                                CollectionTitle = "Dunkles Eichenholz",
                                CollectionLevel = 9,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Wachstumsrüstungsset Rezept"
                            },

                        //Jungelholz Collection
                            new Collection
                            {
                                CollectionTitle = "Jungelholz",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Jungel Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Jungelholz",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Jungelblatt Handel Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Jungelholz",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Portal zur Jungelinsel Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Jungelholz",
                                CollectionLevel = 4,
                                CollectionNeededExp = 500,
                                CollectionUnlock = "Lianen Handel"
                            },
                            new Collection
                            {
                                CollectionTitle = "Jungelholz",
                                CollectionLevel = 5,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Jungelbiomstock Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Jungelholz",
                                CollectionLevel = 6,
                                CollectionNeededExp = 2000,
                                CollectionUnlock = "Verzaubertes Jungelholz Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Jungelholz",
                                CollectionLevel = 7,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Jungelaxt Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Jungelholz",
                                CollectionLevel = 8,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "+ 1000 Foraging Erfahrung"
                            },
                            new Collection
                            {
                                CollectionTitle = "Jungelholz",
                                CollectionLevel = 9,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Ozelot Haustier Rezept"
                            },

                        //Eichenholz Collection
                            new Collection
                            {
                                CollectionTitle = "Eichenholz",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Eichen Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Eichenholz",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Eichenblatt Handel"
                            },
                            new Collection
                            {
                                CollectionTitle = "Eichenholz",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Blattrüstungsset Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Eichenholz",
                                CollectionLevel = 4,
                                CollectionNeededExp = 500,
                                CollectionUnlock = "Kleines Lager Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Eichenholz",
                                CollectionLevel = 5,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Waldbiomstock Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Eichenholz",
                                CollectionLevel = 6,
                                CollectionNeededExp = 2000,
                                CollectionUnlock = "Verzaubertes Eichenholz Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Eichenholz",
                                CollectionLevel = 7,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Mittleres Lager Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Eichenholz",
                                CollectionLevel = 8,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Holzaffinität Talisman Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Eichenholz",
                                CollectionLevel = 9,
                                CollectionNeededExp = 30000,
                                CollectionUnlock = "Grosses Lager Rezept"
                            },

                        //Fichtenholz Collection
                            new Collection
                            {
                                CollectionTitle = "Fichtenholz",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Fichten Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Fichtenholz",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Fichtenblatt Handel"
                            },
                            new Collection
                            {
                                CollectionTitle = "Fichtenholz",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Portal zu den Fichtenwälder Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Fichtenholz",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Taigabiomstock Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Fichtenholz",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2000,
                                CollectionUnlock = "Verzaubertes Fichtenholz Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Fichtenholz",
                                CollectionLevel = 6,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Sägemühle Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Fichtenholz",
                                CollectionLevel = 7,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "+ 1000 Foraging Erfahrung"
                            },
                            new Collection
                            {
                                CollectionTitle = "Fichtenholz",
                                CollectionLevel = 8,
                                CollectionNeededExp = 25000,
                                CollectionUnlock = "Wolf Haustier Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Fichtenholz",
                                CollectionLevel = 9,
                                CollectionNeededExp = 50000,
                                CollectionUnlock = "+ 5000 Foraging Erfahrung"
                            },
                    //++Foraging Collection
                    
                    //--Fishing Collection
                        //Lehm Sammlung
                            new Collection
                            {
                                CollectionTitle = "Lehm",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Lehm Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Lehm",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Verzauberter Lehm Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Lehm",
                                CollectionLevel = 3,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Verzaubertes Buch (Atmuing II) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Lehm",
                                CollectionLevel = 4,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzaubertes Buch (Gebrechlich IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Lehm",
                                CollectionLevel = 5,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Bauernangel Rezept"
                            },
                        //Clownfisch Collection
                            new Collection
                            {
                                CollectionTitle = "Clownfisch",
                                CollectionLevel = 1,
                                CollectionNeededExp = 10,
                                CollectionUnlock = "Clownfischhut Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Clownfisch",
                                CollectionLevel = 2,
                                CollectionNeededExp = 25,
                                CollectionUnlock = "Wassereimer Handel"
                            },
                            new Collection
                            {
                                CollectionTitle = "Clownfisch",
                                CollectionLevel = 3,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Verzaubertes Buch (Magnet IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Clownfisch",
                                CollectionLevel = 4,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Kleiner Sack der Säcke Upgrade"
                            },
                            new Collection
                            {
                                CollectionTitle = "Clownfisch",
                                CollectionLevel = 5,
                                CollectionNeededExp = 200,
                                CollectionUnlock = "Mittlerer Sack der Säcke Upgrade"
                            },
                            new Collection
                            {
                                CollectionTitle = "Clownfisch",
                                CollectionLevel = 6,
                                CollectionNeededExp = 400,
                                CollectionUnlock = "Grôsser Sack der Säcke Upgrade"
                            },
                            new Collection
                            {
                                CollectionTitle = "Clownfisch",
                                CollectionLevel = 7,
                                CollectionNeededExp = 800,
                                CollectionUnlock = "Grösserer Sack der Säcke Upgrade"
                            },

                        //Tintensack Collection
                            new Collection
                            {
                                CollectionTitle = "Tintensack",
                                CollectionLevel = 1,
                                CollectionNeededExp = 20,
                                CollectionUnlock = "Tintenfischhut Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Tintensack",
                                CollectionLevel = 2,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Dunkerl Köder Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Tintensack",
                                CollectionLevel = 3,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Verzauberter Tintensack Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Tintensack",
                                CollectionLevel = 4,
                                CollectionNeededExp = 200,
                                CollectionUnlock = "Blobfischhut Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Tintensack",
                                CollectionLevel = 5,
                                CollectionNeededExp = 400,
                                CollectionUnlock = "Verzaubertes Buch (Werfer IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Tintensack",
                                CollectionLevel = 6,
                                CollectionNeededExp = 800,
                                CollectionUnlock = "Blindheits Trank Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Tintensack",
                                CollectionLevel = 7,
                                CollectionNeededExp = 1500,
                                CollectionUnlock = "Verzauberungs Buch (Angler IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Tintensack",
                                CollectionLevel = 8,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Köderring Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Tintensack",
                                CollectionLevel = 9,
                                CollectionNeededExp = 4000,
                                CollectionUnlock = "Tintenstab Rezept"
                            },

                        //Seerosenblatt Collection
                            new Collection
                            {
                                CollectionTitle = "Seerosenblatt",
                                CollectionLevel = 1,
                                CollectionNeededExp = 10,
                                CollectionUnlock = "Gruseligerköder Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Seerosenblatt",
                                CollectionLevel = 2,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Blobfischhut Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Seerosenblatt",
                                CollectionLevel = 3,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Heilungstalisman Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Seerosenblatt",
                                CollectionLevel = 4,
                                CollectionNeededExp = 200,
                                CollectionUnlock = "Verzaubertes Seerosenblatt Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Seerosenblatt",
                                CollectionLevel = 5,
                                CollectionNeededExp = 500,
                                CollectionUnlock = "Herausfordernde Angel Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Seerosenblatt",
                                CollectionLevel = 6,
                                CollectionNeededExp = 1500,
                                CollectionUnlock = "Walköder Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Seerosenblatt",
                                CollectionLevel = 7,
                                CollectionNeededExp = 3000,
                                CollectionUnlock = "Championangel Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Seerosenblatt",
                                CollectionLevel = 8,
                                CollectionNeededExp = 6000,
                                CollectionUnlock = "Heilungsring Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Seerosenblatt",
                                CollectionLevel = 9,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Legendenangel Rezept"
                            },

                        //Prismarinkristall Collection
                            new Collection
                            {
                                CollectionTitle = "Prismarinkristall",
                                CollectionLevel = 1,
                                CollectionNeededExp = 10,
                                CollectionUnlock = "Seelaternenhut Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Prismarinkristall",
                                CollectionLevel = 2,
                                CollectionNeededExp = 25,
                                CollectionUnlock = "Lichtköder Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Prismarinkristall",
                                CollectionLevel = 3,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Verzauberter Prismarinkristall Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Prismarinkristall",
                                CollectionLevel = 4,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Verzauberungs Buch (Wasseraffinität I) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Prismarinkristall",
                                CollectionLevel = 5,
                                CollectionNeededExp = 200,
                                CollectionUnlock = "Wächterbrustplatte Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Prismarinkristall",
                                CollectionLevel = 6,
                                CollectionNeededExp = 400,
                                CollectionUnlock = "Gesegneterköder Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Prismarinkristall",
                                CollectionLevel = 7,
                                CollectionNeededExp = 800,
                                CollectionUnlock = "Verzauberungs Buch (Segen IV)  Rezept"
                            },

                        //Prismarinscherbe Collection
                            new Collection
                            {
                                CollectionTitle = "Prismarinscherbe",
                                CollectionLevel = 1,
                                CollectionNeededExp = 10,
                                CollectionUnlock = "Verzauberungs Buch (Aufspiessen II) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Prismarinscherbe",
                                CollectionLevel = 2,
                                CollectionNeededExp = 25,
                                CollectionUnlock = "Prismarinklinge Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Prismarinscherbe",
                                CollectionLevel = 3,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Verzauberte Prismarinscherbe Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Prismarinscherbe",
                                CollectionLevel = 4,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Prismarinangel Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Prismarinscherbe",
                                CollectionLevel = 5,
                                CollectionNeededExp = 200,
                                CollectionUnlock = "Prismarinbogen Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Prismarinscherbe",
                                CollectionLevel = 6,
                                CollectionNeededExp = 400,
                                CollectionUnlock = "Wetterknoten Rezept"
                            },

                        //Kugelfisch Collection
                            new Collection
                            {
                                CollectionTitle = "Kugelfisch",
                                CollectionLevel = 1,
                                CollectionNeededExp = 20,
                                CollectionUnlock = "Kugelfischhut Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kugelfisch",
                                CollectionLevel = 2,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Verzauberter Kugelfisch Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kugelfisch",
                                CollectionLevel = 3,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Verzauberungs Buch (Spalten IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kugelfisch",
                                CollectionLevel = 4,
                                CollectionNeededExp = 150,
                                CollectionUnlock = "Verzauberungs Buch (Wasserläufer II) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kugelfisch",
                                CollectionLevel = 5,
                                CollectionNeededExp = 400,
                                CollectionUnlock = "Stacheligerköder Rezept & kleiner Fischsack"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kugelfisch",
                                CollectionLevel = 6,
                                CollectionNeededExp = 800,
                                CollectionUnlock = "Verzauberungs Buch (Stacheliger Haken IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kugelfisch",
                                CollectionLevel = 7,
                                CollectionNeededExp = 2400,
                                CollectionUnlock = "Mittlerer Fischsack Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kugelfisch",
                                CollectionLevel = 8,
                                CollectionNeededExp = 4800,
                                CollectionUnlock = "Pufferboot Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kugelfisch",
                                CollectionLevel = 9,
                                CollectionNeededExp = 9000,
                                CollectionUnlock = "Grosser Fischsack Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Kugelfisch",
                                CollectionLevel = 10,
                                CollectionNeededExp = 18000,
                                CollectionUnlock = "Grosser, verzauberter Fischsack Rezept"
                            },

                        //Fisch Collection
                            new Collection
                            {
                                CollectionTitle = "Fisch",
                                CollectionLevel = 1,
                                CollectionNeededExp = 20,
                                CollectionUnlock = "Fischhut Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Fisch",
                                CollectionLevel = 2,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Fishing Minion Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Fisch",
                                CollectionLevel = 3,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Kleiner Fischrucksack Upgrade"
                            },
                            new Collection
                            {
                                CollectionTitle = "Fisch",
                                CollectionLevel = 4,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Teichinsel Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Fisch",
                                CollectionLevel = 5,
                                CollectionNeededExp = 500,
                                CollectionUnlock = "Anglerrüstungsset Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Fisch",
                                CollectionLevel = 6,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Verzauberter roher Fisch Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Fisch",
                                CollectionLevel = 7,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Mittlerer Fischrucksack Upgrade"
                            },
                            new Collection
                            {
                                CollectionTitle = "Fisch",
                                CollectionLevel = 8,
                                CollectionNeededExp = 15000,
                                CollectionUnlock = "Verzauberter gekochter Fisch Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Fisch",
                                CollectionLevel = 9,
                                CollectionNeededExp = 30000,
                                CollectionUnlock = "Grosser Fischrucksack Upgrade"
                            },
                            new Collection
                            {
                                CollectionTitle = "Fisch",
                                CollectionLevel = 10,
                                CollectionNeededExp = 45000,
                                CollectionUnlock = "Riesiger Fischrucksack Upgrade"
                            },
                            new Collection
                            {
                                CollectionTitle = "Fisch",
                                CollectionLevel = 11,
                                CollectionNeededExp = 60000,
                                CollectionUnlock = "Massiver Fischrucksack Upgrade"
                            },

                        //Lachs Collection
                            new Collection
                            {
                                CollectionTitle = "Lachs",
                                CollectionLevel = 1,
                                CollectionNeededExp = 20,
                                CollectionUnlock = "Elritzenköder Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Lachs",
                                CollectionLevel = 2,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Ausweich Trank Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Lachs",
                                CollectionLevel = 3,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Verzauberungs Buch (Köder IV) Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Lachs",
                                CollectionLevel = 4,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Verzauberter roher Lachs Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Lachs",
                                CollectionLevel = 5,
                                CollectionNeededExp = 500,
                                CollectionUnlock = "Flitzerangel Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Lachs",
                                CollectionLevel = 6,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Fischköder Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Lachs",
                                CollectionLevel = 7,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Lachsrüstungsset Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Lachs",
                                CollectionLevel = 8,
                                CollectionNeededExp = 5000,
                                CollectionUnlock = "Verzauberter gekochter Lachs Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Lachs",
                                CollectionLevel = 9,
                                CollectionNeededExp = 10000,
                                CollectionUnlock = "Lachshut Rezept"
                            },

                        //Schwamm Collection
                            new Collection
                            {
                                CollectionTitle = "Schwamm",
                                CollectionLevel = 1,
                                CollectionNeededExp = 20,
                                CollectionUnlock = "Schwammangel Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schwamm",
                                CollectionLevel = 2,
                                CollectionNeededExp = 40,
                                CollectionUnlock = "Schwamm Handel"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schwamm",
                                CollectionLevel = 3,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Verzauberter Schwamm Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schwamm",
                                CollectionLevel = 4,
                                CollectionNeededExp = 200,
                                CollectionUnlock = "Seekreaturen Talisman Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schwamm",
                                CollectionLevel = 5,
                                CollectionNeededExp = 400,
                                CollectionUnlock = "Stereohosen Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schwamm",
                                CollectionLevel = 6,
                                CollectionNeededExp = 800,
                                CollectionUnlock = "Seekreaturenring Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schwamm",
                                CollectionLevel = 7,
                                CollectionNeededExp = 1500,
                                CollectionUnlock = "Verzauberter nasser Schwamm Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schwamm",
                                CollectionLevel = 8,
                                CollectionNeededExp = 2500,
                                CollectionUnlock = "Seekreaturenartifakt Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Schwamm",
                                CollectionLevel = 9,
                                CollectionNeededExp = 4000,
                                CollectionUnlock = "Schwammrüstungsset Rezept"
                            },
                    //++Fishing Collection

                    //--Boss Collection
                        //Bonzo Collection
                            new Collection
                            {
                                CollectionTitle = "Bonzo",
                                CollectionLevel = 1,
                                CollectionNeededExp = 25,
                                CollectionUnlock = "Rote Nase Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Bonzo",
                                CollectionLevel = 2,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Bonzo's Maske Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Bonzo",
                                CollectionLevel = 3,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Goldener Bonzokopf Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Bonzo",
                                CollectionLevel = 4,
                                CollectionNeededExp = 150,
                                CollectionUnlock = "Bonzo's Stab Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Bonzo",
                                CollectionLevel = 5,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Rekombinator 3000 Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Bonzo",
                                CollectionLevel = 6,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Diamantener Bonzokopf Rezept"
                            },

                        //Scarf Collection
                            new Collection
                            {
                                CollectionTitle = "Scarf",
                                CollectionLevel = 1,
                                CollectionNeededExp = 25,
                                CollectionUnlock = "Roter Scarf Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Scarf",
                                CollectionLevel = 2,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Scarf's These Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Scarf",
                                CollectionLevel = 3,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Goldener Schalkopf Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Scarf",
                                CollectionLevel = 4,
                                CollectionNeededExp = 150,
                                CollectionUnlock = "Adaptive Klinge Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Scarf",
                                CollectionLevel = 5,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Rekombinator 3000 Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Scarf",
                                CollectionLevel = 6,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Diamantener Scarfkopf Rezept"
                            },

                        //Professor Collection
                            new Collection
                            {
                                CollectionTitle = "Professor",
                                CollectionLevel = 1,
                                CollectionNeededExp = 25,
                                CollectionUnlock = "Verdächtige Ampulle Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Professor",
                                CollectionLevel = 2,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Adaptivehosen Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Professor",
                                CollectionLevel = 3,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Goldener Professorkopf Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Professor",
                                CollectionLevel = 4,
                                CollectionNeededExp = 150,
                                CollectionUnlock = "Adaptivebrustplatte Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Professor",
                                CollectionLevel = 5,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Rekombinator 3000 Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Professor",
                                CollectionLevel = 6,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Diamantener Professorenkopf Rezept"
                            },

                        //Thorn Collection
                            new Collection
                            {
                                CollectionTitle = "Thorn",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Geisterstein Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Thorn",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Goldener Thornkopf Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Thorn",
                                CollectionLevel = 3,
                                CollectionNeededExp = 150,
                                CollectionUnlock = "Geisterbogen Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Thorn",
                                CollectionLevel = 4,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Rekombinator 3000 Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Thorn",
                                CollectionLevel = 5,
                                CollectionNeededExp = 400,
                                CollectionUnlock = "Geisterschuhe Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Thorn",
                                CollectionLevel = 6,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Diamantener Thornkopf Rezept"
                            },

                        //Livid Collection
                            new Collection
                            {
                                CollectionTitle = "Livid",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Dunkelorb Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Livid",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Goldener lividkopf Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Livid",
                                CollectionLevel = 3,
                                CollectionNeededExp = 150,
                                CollectionUnlock = "Livid Dolch Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Livid",
                                CollectionLevel = 4,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Rekombinator 3000 Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Livid",
                                CollectionLevel = 5,
                                CollectionNeededExp = 500,
                                CollectionUnlock = "Letzer Atemzug Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Livid",
                                CollectionLevel = 6,
                                CollectionNeededExp = 750,
                                CollectionUnlock = "Schattenassassinenbrustplatte Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Livid",
                                CollectionLevel = 7,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Diamantener Lividkopf Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Livid",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Dunkelorb Rezept"
                            },

                        //Sadan Collection
                            new Collection
                            {
                                CollectionTitle = "Sadan",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Riesenzahn Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Sadan",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Goldener Sadankopf Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Sadan",
                                CollectionLevel = 3,
                                CollectionNeededExp = 150,
                                CollectionUnlock = "Nekromanten-Lordhelm  Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Sadan",
                                CollectionLevel = 4,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Rekombinator 3000 Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Sadan",
                                CollectionLevel = 5,
                                CollectionNeededExp = 500,
                                CollectionUnlock = "Nekromanten-Lordbrustplatte Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Sadan",
                                CollectionLevel = 6,
                                CollectionNeededExp = 750,
                                CollectionUnlock = "Nekromantenschwert Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Sadan",
                                CollectionLevel = 7,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Diamantener Sadankopf Rezept"
                            },

                        //Necron Collection
                            new Collection
                            {
                                CollectionTitle = "Necron",
                                CollectionLevel = 1,
                                CollectionNeededExp = 50,
                                CollectionUnlock = "Witherbruut Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Necron",
                                CollectionLevel = 2,
                                CollectionNeededExp = 100,
                                CollectionUnlock = "Goldener Necronkopf Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Necron",
                                CollectionLevel = 3,
                                CollectionNeededExp = 150,
                                CollectionUnlock = "Witherkopf Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Necron",
                                CollectionLevel = 4,
                                CollectionNeededExp = 250,
                                CollectionUnlock = "Rekombinator 3000 Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Necron",
                                CollectionLevel = 5,
                                CollectionNeededExp = 500,
                                CollectionUnlock = "Witherhosen Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Necron",
                                CollectionLevel = 6,
                                CollectionNeededExp = 750,
                                CollectionUnlock = "Witherbrustplatte  Rezept"
                            },
                            new Collection
                            {
                                CollectionTitle = "Necron",
                                CollectionLevel = 7,
                                CollectionNeededExp = 1000,
                                CollectionUnlock = "Diamantener Necronkopf Rezept"
                            }
                    //++Boss Collection

                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
