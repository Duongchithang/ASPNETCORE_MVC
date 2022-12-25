
using Microsoft.EntityFrameworkCore;

using WebApplication4.Models;
using WebApplication4.Services;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddSingleton<PlanetService>();
builder.Services.AddSingleton<UserService>();
builder.Services.AddTransient<ProductServices>();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    string connectString = builder.Configuration.GetConnectionString("AppMvc");
    options.UseSqlServer(connectString);
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

app.UseStatusCodePages(Error =>
{
    Error.Run(async context =>
    {
        var reponse = context.Response;
        var StatusCode = reponse.StatusCode.ToString();
        await context.Response.WriteAsync(StatusCode);
    });
}
);

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages();
    endpoints.MapGet("/", async (context) =>
    {
        await context.Response.WriteAsync("Hello world");
    });
    endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=First}/{action=Index}/{id?}");
    endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=Planet}/{action=Index}");
    endpoints.MapControllerRoute(
   name: "default",
   pattern: "{controller=Contact}/{action=Create}");

});

app.UseAuthorization();



app.Run();
