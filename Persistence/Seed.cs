using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (!context.Activities.Any())
            {
                var activities = new List<Activity>() {
                    new Activity()
                    {
                        Title = "Past Activity 1",
                        Date = DateTime.Now,
                        Description = "HN festival",
                        Category = "drinks",
                        City = "Ha Noi",
                        Venue = "Pub"
                    },
                    new Activity()
                    {
                        Title = "Past Activity 2",
                        Date = DateTime.Now.AddDays(-3),
                        Description = "Da Nang festival",
                        Category = "drinks",
                        City = "Da Nang",
                        Venue = "Pub"
                    },
                    new Activity()
                    {
                        Title = "Past Activity 3",
                        Date = DateTime.Now.AddMonths(1),
                        Description = "HCM festival",
                        Category = "drinks",
                        City = "HCM",
                        Venue = "Pub"
                    },
                    new Activity()
                    {
                        Title = "Past Activity 4",
                        Date = DateTime.Now,
                        Description = "HN festival",
                        Category = "drinks",
                        City = "Ha Noi",
                        Venue = "Pub"
                    },
                    new Activity()
                    {
                        Title = "Past Activity 5",
                        Date = DateTime.Now.AddDays(-3),
                        Description = "Da Nang festival",
                        Category = "drinks",
                        City = "Da Nang",
                        Venue = "Pub"
                    },
                    new Activity()
                    {
                        Title = "Past Activity 6",
                        Date = DateTime.Now.AddMonths(1),
                        Description = "HCM festival",
                        Category = "drinks",
                        City = "HCM",
                        Venue = "Pub"
                    }
                };

                await context.Activities.AddRangeAsync(activities);
                await context.SaveChangesAsync();
            }
        }
    }
}