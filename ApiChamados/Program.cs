using ApiChamados.Interfaces;
using ApiChamados.Repository;
using ApiChamados.Service;
using ApiChamados.Service.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<ICalledRepository, CalledRepository>();
builder.Services.AddTransient<ICalledStatusRepository, CalledStatusRepository>();
builder.Services.AddTransient<ICalledStatusService, CalledStatusService>();

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
