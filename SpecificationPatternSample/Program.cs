using Microsoft.EntityFrameworkCore;
using SpecificationPatternSample;
using SpecificationPatternSample.Interfaces;
using SpecificationPatternSample.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(x => x.UseInMemoryDatabase("InMemory"));
builder.Services.AddScoped<IMovieRepository, MovieRepository>();

var app = builder.Build();

DbSeed.Seed(app.Services.CreateScope().ServiceProvider.GetRequiredService<ApplicationDbContext>());

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