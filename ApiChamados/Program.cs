using ApiChamados.Context;
using ApiChamados.Interfaces;
using ApiChamados.Interfaces.Repository;
using ApiChamados.Interfaces.Service;
using ApiChamados.Repository;
using ApiChamados.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ConnectionContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<ICalledService, CalledService>();
builder.Services.AddTransient<ICalledRepository, CalledRepository>();
builder.Services.AddTransient<ICalledStatusService, CalledStatusService>();
builder.Services.AddTransient<ICalledStatusRepository, CalledStatusRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
