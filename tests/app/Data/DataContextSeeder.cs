using Data.Entities;

namespace Data
{
    public static class DataContextSeeder
    {
        public static void Seed(DataContext context)
        {
            // always drop and create database
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            context.Values.Add(new Value()
            {
                Num = 42
            });

            context.Users.Add(new User()
            {
                Username = "Alex",
                Email = "alex@trainig.com",
                Password = "password"
            });

            context.SaveChanges();
        }
    }
}