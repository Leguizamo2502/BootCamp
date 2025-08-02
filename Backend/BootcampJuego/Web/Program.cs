using Business.Interfaces.Implements;
using Business.Mapping;
using Business.Services;
using Data.Interfaces.Implements;
using Data.Interfaces.IRepository;
using Data.Repository;
using Data.Services;
using Entity.Infrastructure.Contexts;
using Mapster;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Mapster
builder.Services.AddMapster();
MapsterConfig.Register();

//Services


builder.Services.AddScoped(typeof(IData<>), typeof(DataGeneric<>));

builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();
builder.Services.AddScoped<IPlayerService, PlayerService>();
builder.Services.AddScoped<ICardRepository, CardRepository>();
builder.Services.AddScoped<ICardService, CardService>();


var conection = builder.Configuration.GetConnectionString("default");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(conection)
    );



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
