using IdentityManagers.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//Adding Connection String
builder.Services.AddDbContext<ApplicationDbContext>(options => {  // => Add ApplicationDbContext to the server
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")); // => Link between connections string in json and sql server
});
//Adding Identity Service in the application
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

//This To Access The Password Requirements on the identity options like :-
builder.Services.Configure<IdentityOptions>(opt =>
{
    opt.Password.RequireDigit = false; // => Controll RequireCapitale 
    opt.Password.RequireLowercase = false; // => Controll The Size OF the Letter
    opt.Password.RequireNonAlphanumeric = false; // => Controll The Things That Should You Write in The Password
    opt.Lockout.MaxFailedAccessAttempts = 3; // => Controll the maximum of the failed times before it Lock The User 
    opt.SignIn.RequireConfirmedEmail = false; // => Controll If Do You want To Require Email Or Not
    opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5); // Controll How Long The User Will be Locked out For
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
//use u
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
