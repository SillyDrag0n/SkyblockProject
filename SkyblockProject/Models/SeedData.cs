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
                            }
                            ,
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
                            }
                    //++Mining Collection

                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
