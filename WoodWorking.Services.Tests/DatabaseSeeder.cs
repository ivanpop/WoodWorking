using Microsoft.AspNetCore.Identity;
using WoodWorking.Data;

namespace WoodWorking.Services.Tests
{
    public static class DatabaseSeeder
    {
        private static IdentityUser StandardUser1;
        private static IdentityUser StandardUser2;

        public static void SeedDatabase(WoodWorkingDbContext dbContext)
        {
            StandardUser1 = new IdentityUser()
            {
                UserName = "Pesho",
                NormalizedUserName = "PESHO",
                Email = "pesho@mail.bg",
                NormalizedEmail = "PESHO@MAIL.BG",
                EmailConfirmed = true,
                PasswordHash = "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92",
                SecurityStamp = "b70c962d-2c67-4a96-b460-7e1ff07c47b4",
                ConcurrencyStamp = "b70c962d-2c67-4a96-b460-7e1ff07c47b5",
                TwoFactorEnabled = false
            };

            StandardUser2 = new IdentityUser()
            {
                UserName = "Gosho",
                NormalizedUserName = "GOSHO",
                Email = "gosho@mail.bg",
                NormalizedEmail = "GOSHO@MAIL.BG",
                EmailConfirmed = true,
                PasswordHash = "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92",
                SecurityStamp = "b70c962d-2c67-4a96-b460-7e1ff07c57b6",
                ConcurrencyStamp = "b70c962d-2c67-4a96-b460-7e1ff07c57b7",
                TwoFactorEnabled = false
            };

            dbContext.Users.Add(StandardUser1);
            dbContext.Users.Add(StandardUser2);

            dbContext.SaveChanges();
        }
    }
}