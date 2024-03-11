using yr_api.Models.Entities;

namespace yr_api.Data.Seeders;

public static class UserSeeder
{
    public static void SeedUsers(this DatabaseContext context)
    {
        var users = new List<ApplicationUser>
        {
            new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "muhamed@live.com",
                SecurityStamp = Guid.NewGuid().ToString(),
                IsActive = true,
                EmailConfirmed = true
            }
        };

        var exists = context.AppUsers.Any(x => x.Email == users.First().Email);
        if (!exists)
        {
            context.AppUsers.AddRange(users);
            context.SaveChanges();
        }
    }
}
