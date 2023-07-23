using WoodWorking.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WoodWorking.Contracts;
using WoodWorking.Service;
using Library.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<WoodWorkingDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
}
)
.AddRoles<IdentityRole>()
.AddEntityFrameworkStores<WoodWorkingDbContext>();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IMaterialService, MaterialService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IEdgeService, EdgeService>();
builder.Services.AddScoped<IOrderService, OrderService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

using (var scope = app.Services.CreateScope())
{
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

    if (await roleManager.FindByNameAsync("admin") == null)
    {
        var role = new IdentityRole();
        role.Name = "admin";
        role.NormalizedName = "ADMIN";

        await roleManager.CreateAsync(role);
    }

    if (await roleManager.FindByNameAsync("editor") == null)
    {
        var role = new IdentityRole();
        role.Name = "editor";
        role.NormalizedName = "EDITOR";

        await roleManager.CreateAsync(role);
    }

    if (await roleManager.FindByNameAsync("user") == null)
    {
        var role = new IdentityRole();
        role.Name = "user";
        role.NormalizedName = "USER";

        await roleManager.CreateAsync(role);
    }

    if (await userManager.FindByEmailAsync("admins@mr-bricolage.bg") == null)
    {
        var user = new IdentityUser();
        user.UserName = "admins@mr-bricolage.bg";
        user.Email = "admins@mr-bricolage.bg";

        await userManager.CreateAsync(user, "pass123");
        await userManager.AddToRoleAsync(user, "admin");
    }

    if (await userManager.FindByEmailAsync("trade@mr-bricolage.bg") == null)
    {
        var user = new IdentityUser();
        user.UserName = "trade@mr-bricolage.bg";
        user.Email = "trade@mr-bricolage.bg";

        await userManager.CreateAsync(user, "pass123");
        await userManager.AddToRoleAsync(user, "editor");
    }
}

app.Run();