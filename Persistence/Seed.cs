
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Providers.Any()) return;

            var activities = new List<Provider>
            {
                 new Provider
                {
                    zorluk = 3,
                    sure = 6,
                    id = "IT Task 0"
                },
                 new Provider
                {
                    zorluk = 4,
                    sure = 6,
                    id = "IT Task 1"
                },
                new Provider
                {
                    zorluk = 3,
                    sure = 10,
                    id = "IT Task 2"
                },
                new Provider
                {
                    zorluk = 4,
                    sure = 4,
                    id = "IT Task 3"
                },
                new Provider
                {
                    zorluk = 3,
                    sure = 5,
                    id = "IT Task 4"
                },
                new Provider
                {
                    zorluk = 1,
                    sure = 12,
                    id = "IT Task 5"
                },
                new Provider
                {
                    zorluk = 1,
                    sure = 4,
                    id = "IT Task 6"
                },
                new Provider
                {
                    zorluk = 5,
                    sure = 6,
                    id = "IT Task 7"
                },
                new Provider
                {
                    zorluk = 3,
                    sure = 8,
                    id = "IT Task 8"
                },
                new Provider
                {
                    zorluk = 1,
                    sure = 6,
                    id = "IT Task 9"
                },
                new Provider
                {
                    zorluk = 2,
                    sure = 10,
                    id = "IT Task 10"
                },
                new Provider
                {
                    zorluk = 1,
                    sure = 6,
                    id = "IT Task 11"
                },
                new Provider
                {
                    zorluk = 4,
                    sure = 11,
                    id = "IT Task 12"
                },
                new Provider
                {
                    zorluk = 5,
                    sure = 3,
                    id = "IT Task 13"
                },
                new Provider
                {
                    zorluk = 1,
                    sure = 11,
                    id = "IT Task 14"
                },
                new Provider
                {
                    zorluk = 4,
                    sure = 6,
                    id = "IT Task 15"
                },
                new Provider
                {
                    zorluk = 5,
                    sure = 4,
                    id = "IT Task 16"
                },
                new Provider
                {
                    zorluk = 3,
                    sure = 11,
                    id = "IT Task 17"
                },
                new Provider
                {
                    zorluk = 2,
                    sure = 11,
                    id = "IT Task 18"
                },
                new Provider
                {
                    zorluk = 3,
                    sure = 8,
                    id = "IT Task 19"
                },
                new Provider
                {
                    zorluk = 3,
                    sure = 11,
                    id = "IT Task 20"
                },
                new Provider
                {
                    zorluk = 1,
                    sure = 5,
                    id = "IT Task 21"
                },
                new Provider
                {
                    zorluk = 4,
                    sure = 5,
                    id = "IT Task 22"
                },
                new Provider
                {
                    zorluk = 2,
                    sure = 7,
                    id = "IT Task 23"
                },
                new Provider
                {
                    zorluk = 2,
                    sure = 6,
                    id = "IT Task 24"
                },
                new Provider
                {
                    zorluk = 3,
                    sure = 9,
                    id = "IT Task 25"
                },
                new Provider
                {
                    zorluk = 4,
                    sure = 6,
                    id = "IT Task 26"
                },
                new Provider
                {
                    zorluk = 4,
                    sure = 7,
                    id = "IT Task 27"
                },
                new Provider
                {
                    zorluk = 1,
                    sure = 4,
                    id = "IT Task 28"
                },
                new Provider
                {
                    zorluk = 4,
                    sure = 5,
                    id = "IT Task 29"
                },
                new Provider
                {
                    zorluk = 5,
                    sure = 9,
                    id = "IT Task 30"
                },
                new Provider
                {
                    zorluk = 2,
                    sure = 5,
                    id = "IT Task 31"
                },
                new Provider
                {
                    zorluk = 2,
                    sure = 5,
                    id = "IT Task 32"
                },
                new Provider
                {
                    zorluk = 2,
                    sure = 6,
                    id = "IT Task 33"
                },
                new Provider
                {
                    zorluk = 5,
                    sure = 6,
                    id = "IT Task 34"
                },
                new Provider
                {
                    zorluk = 1,
                    sure = 10,
                    id = "IT Task 35"
                },
                new Provider
                {
                    zorluk = 1,
                    sure = 10,
                    id = "IT Task 36"
                },
                new Provider
                {
                    zorluk = 1,
                    sure = 10,
                    id = "IT Task 37"
                },
                new Provider
                {
                    zorluk = 5,
                    sure = 12,
                    id = "IT Task 38"
                },
                new Provider
                {
                    zorluk = 4,
                    sure = 12,
                    id = "IT Task 39"
                },
                new Provider
                {
                    zorluk = 2,
                    sure = 6,
                    id = "IT Task 40"
                },
                new Provider
                {
                    zorluk = 3,
                    sure = 8,
                    id = "IT Task 41"
                },
                new Provider
                {
                    zorluk = 5,
                    sure = 10,
                    id = "IT Task 42"
                },
                new Provider
                {
                    zorluk = 3,
                    sure = 10,
                    id = "IT Task 43"
                },
                new Provider
                {
                    zorluk = 5,
                    sure = 8,
                    id = "IT Task 44"
                },
                new Provider
                {
                    zorluk = 5,
                    sure = 9,
                    id = "IT Task 45"
                },
                new Provider
                {
                    zorluk = 3,
                    sure = 3,
                    id = "IT Task 46"
                },
                new Provider
                {
                    zorluk = 4,
                    sure = 4,
                    id = "IT Task 47"
                },
                new Provider
                {
                    zorluk = 1,
                    sure = 12,
                    id = "IT Task 48"
                },
                new Provider
                {
                    zorluk = 1,
                    sure = 7,
                    id = "IT Task 49"
                },
                new Provider
                {
                    zorluk = 1,
                    sure = 4,
                    id = "IT Task 50"
                },
                new Provider
                {
                    zorluk = 1,
                    sure = 10,
                    id = "IT Task 51"
                },
                new Provider
                {
                    zorluk = 4,
                    sure = 8,
                    id = "IT Task 52"
                },
                new Provider
                {
                    zorluk = 3,
                    sure = 3,
                    id = "IT Task 53"
                },
                new Provider
                {
                    zorluk = 4,
                    sure = 10,
                    id = "IT Task 54"
                },
                new Provider
                {
                    zorluk = 4,
                    sure = 12,
                    id = "IT Task 55"
                },
                new Provider
                {
                    zorluk = 3,
                    sure = 10,
                    id = "IT Task 56"
                },
                new Provider
                {
                    zorluk = 2,
                    sure = 11,
                    id = "IT Task 57"
                },
                new Provider
                {
                    zorluk = 1,
                    sure = 7,
                    id = "IT Task 58"
                },
                new Provider
                {
                    zorluk = 2,
                    sure = 4,
                    id = "IT Task 59"
                },
                new Provider
                {
                    zorluk = 3,
                    sure = 4,
                    id = "IT Task 60"
                },
                new Provider
                {
                    zorluk = 1,
                    sure = 3,
                    id = "IT Task 61"
                },
                new Provider
                {
                    zorluk = 1,
                    sure = 6,
                    id = "IT Task 62"
                },
                new Provider
                {
                    zorluk = 3,
                    sure = 3,
                    id = "IT Task 63"
                },
                new Provider
                {
                    zorluk = 4,
                    sure = 12,
                    id = "IT Task 64"
                },
                new Provider
                {
                    zorluk = 2,
                    sure = 11,
                    id = "IT Task 65"
                },
                new Provider
                {
                    zorluk = 3,
                    sure = 10,
                    id = "IT Task 66"
                }

            };

            await context.Providers.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}