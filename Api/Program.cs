using Api;
using Domain.Entities;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.ResolveAllServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("health-check", () =>
{
    return "Ok";
});

app.MapGet("getAllClubs", (IClubService service) =>
{
    return service.GetAllClubs();
}).Produces<IEnumerable<Club>>();


app.MapPost("registerClub", (IClubService service, Club club) =>
{
    var result = service.RegisterClub(club);

    return result;
});


app.Run();
