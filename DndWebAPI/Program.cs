using DnDWebAPI.Interfaces;
using DnDWebAPI.Models;
using DnDWebAPI.Services;

using Microsoft.Extensions.Caching.Memory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IDiceRollService, DiceRollService>();

builder.Services.AddScoped<ICritFumbleService, CritFumbleService>();

builder.Services.AddMemoryCache();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
