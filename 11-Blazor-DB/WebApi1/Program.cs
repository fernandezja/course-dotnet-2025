using GestionUniversitaria.Core.Datos;
using GestionUniversitaria.Core.Entidades;
using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
});



app.MapGet("/api/alumno", () =>
{
    var alumnoRepository = new AlumnoRepository();
    var alumnos = alumnoRepository.Todos();

    return alumnos;
});


app.MapPost("/api/alumno", (Alumno alumno, HttpContext context) =>
{
    //Validar alumno
    if (alumno is null)
    {
        return Results.BadRequest("Alumno no puede ser nulo");
    }

    var alumnoRepository = new AlumnoRepository();
    var seGuardo = alumnoRepository.Guardar(alumno);

    return Results.Ok();
});





app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
