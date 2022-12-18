using CodePatternsAPI.Data;
using CodePatternsAPI.Factories;
using CodePatternsAPI.Interfaces;
using CodePatternsAPI.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SqlContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultString")));

//Used for the IDressEntityFactory and DressEntityFactory DIP
builder.Services.AddScoped<IDressEntityFactory, DressEntityFactory>();
//Used for the IDressEntityFactory and DressEntityFactory DIP
builder.Services.AddScoped<IJacketEntityFactory, JacketEntityFactory>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
