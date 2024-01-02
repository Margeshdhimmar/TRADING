using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using MVC_TUTORIAL_5_12_23.Data;
using MVC_TUTORIAL_5_12_23.Models;
using System.Drawing;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
string cs = "Data Source=MARGESH-DT\\SQLEXPRESS; Initial Catalog = TRADING; Integrated Security = True; Trust Server Certificate=True";
builder.Services.AddDbContext<DataContext>(op => op.UseSqlServer(cs));
builder.Services.AddSession();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseSession();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();
