using Microsoft.EntityFrameworkCore;
using MusicsAPI.Data;

var builder = WebApplication.CreateBuilder(args);

//var connectionString = "DefaultConnection";

//builder.Services.AddDbContext<MarketContext>(opts =>
//    opts.UseMySql(builder.Configuration.GetConnectionString(connectionString), 
//        ServerVersion.AutoDetect(connectionString)));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
