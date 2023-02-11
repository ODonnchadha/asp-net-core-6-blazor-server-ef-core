using Microsoft.EntityFrameworkCore;
using WiredBrainCoffee.EmployeeManager.Contexts;
using WiredBrainCoffee.EmployeeManager.Shared;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddDbContextFactory<EmployeeManagerDbContext>(
        options => options.UseSqlServer(
            builder.Configuration.GetConnectionString("x")));

builder.Services.AddScoped<StateContainer>();

var app = builder.Build();

await Migrate(app.Services);

if (!app.Environment.IsDevelopment())
{
  app.UseExceptionHandler("/Error");
  app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.Run();
async Task Migrate(IServiceProvider services)
{
    using var scope = services.CreateScope();
    using var context = 
        scope.ServiceProvider.GetService<EmployeeManagerDbContext>();

    if (null != context)
    {
        await context.Database.MigrateAsync();
    }
}