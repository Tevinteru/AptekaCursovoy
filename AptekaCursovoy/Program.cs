using AptekaCursovoy.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AptekaCursovoy.Data;
using System.Configuration;
using AptekaCursovoy.Controllers;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<AptekaCursovoyContext>(options =>
//    options.UseMySql(builder.Configuration.GetConnectionString("AptekaCursovoyContext"), ServerVersion.Parse("8.0.26-mysql")));

string? connection = builder.Configuration.GetConnectionString("AptekaCursovoyContext");

builder.Services.AddDbContext<AptekaCursovoyContext>(options =>
        options.UseMySQL(connection));

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddScoped<EmployeesController>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
