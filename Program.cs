
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Lägg till CORS för att tillåta access från webbsidor (viktigt för uppgiften)
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

builder.Services.AddControllers();

var app = builder.Build();


app.UseCors();

// Aktivera static files (för att servera katbilder från wwwroot-mappen)
app.UseStaticFiles();

// Mappa controllers
app.MapControllers();

app.Run();
