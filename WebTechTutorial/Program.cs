using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyWeb.Shared.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddSingleton(builder.Configuration);
builder.Services.AddDbContext<MyWebDatabaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnectionString")));
//builder.Services.AddDefaultIdentity<IdentityUser>(options =>
//    {
//        options.User.RequireUniqueEmail = true;
//        options.Password.RequireDigit = false;
//        options.Password.RequireLowercase = false;
//        options.Password.RequireNonAlphanumeric = false;
//        options.Password.RequireUppercase = false;
//        options.Password.RequiredLength = 6;
//        options.Password.RequiredUniqueChars = 0;
//        options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
//        options.Lockout.MaxFailedAccessAttempts = 5;
//        options.Lockout.AllowedForNewUsers = true;
//    })
//    .AddRoles<IdentityRole>()
//    .AddEntityFrameworkStores<MyWebDatabaseContext>()
//    .AddDefaultTokenProviders();

//builder.Services.ConfigureApplicationCookie(options =>
//{
//    // Cookie settings
//    options.Cookie.HttpOnly = true;
//    options.ExpireTimeSpan = TimeSpan.FromDays(365);
//    options.LoginPath = "/Account/Login";
//    options.AccessDeniedPath = "/Account/AccessDenied";
//    options.SlidingExpiration = true;
//});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

//app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
