using Microsoft.EntityFrameworkCore;
using FinalProject_BJSS5.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<FinalContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("FinalContext")));

builder.Services.AddSwaggerDocument();

builder.Services.AddScoped<IFinalService, FinalService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

using (var scope = app.Services.CreateScope()) // if DB hasn't been created before, create DB
{
    var context = scope.ServiceProvider.GetRequiredService<FinalContext>();
    context.Database.EnsureCreated();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseOpenApi();
app.UseSwaggerUi3();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
