using Business.Interfaces.Implements;
using Business.Mapping;
using Business.Services;
using Business.Services.Singletons;
using Data.Interfaces.Implements;
using Data.Interfaces.IRepository;
using Data.Repository;
using Data.Services;
using Entity.Infrastructure.Contexts;
using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

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

builder.Services.AddScoped<IDeckRepository, DeckRepository>();
builder.Services.AddScoped<IDeckService, DeckService>();

builder.Services.AddScoped<IGameRepository, GameRepository>();
builder.Services.AddScoped<IGameService, GameService>();

builder.Services.AddScoped<IGamePlayerRepository, GamePlayerRepository>();
builder.Services.AddScoped<IGamePLayerService, GamePlayerService>();

builder.Services.AddScoped<IRoundRepository, RoundRepository>();
builder.Services.AddScoped<IRoundService, RoundService>();

builder.Services.AddScoped<IMoveRepository, MoveRepository>();
builder.Services.AddScoped<IMoveService, MoveService>();

//builder.Services.AddScoped<IGameService, GameService>();










var conection = builder.Configuration.GetConnectionString("default");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(conection)
    );

var allowedOrigins = builder.Configuration.GetValue<string>("Origins")!.Split(",");

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins(allowedOrigins).AllowAnyHeader().AllowAnyMethod().AllowCredentials();
    });
});



var app = builder.Build();




// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
