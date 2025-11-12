using GestionUniversitaria.Core.Datos;
using GestionUniversitaria.Core.Entidades;
using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);

var configActual = new Config
{
    Titulo = "Gestion Universitaria API",
    ConnectionString = "InMemoryDb_GestionUniversitaria"
};

// Add services to the container.
builder.Services.AddSingleton<Config>(configActual);
builder.Services.AddScoped<AlumnoRepository>();
//builder.Services.AddTransient<AlumnoRepository>();
//builder.Services.AddSingleton<AlumnoRepository>()

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



app.MapGet("/api/alumno/{alumnoId}", (int alumnoId,
                                      AlumnoRepository alumnoRepository,
                                        HttpContext context) =>
{
    var alumno = alumnoRepository.Obtener(alumnoId);

    if (alumno is null)
    {
        return Results.NotFound();
    }

    return Results.Ok(alumno);
});

app.MapGet("/api/alumno", (AlumnoRepository alumnoRepository) =>
{
    var alumnos = alumnoRepository.Todos();

    return alumnos;
});


app.MapPost("/api/alumno", (Alumno alumno,
                            AlumnoRepository alumnoRepository,
                            HttpContext context) =>
{
    //Validar alumno
    if (alumno is null)
    {
        return Results.BadRequest("Alumno no puede ser nulo");
    }

    //var alumnoRepository = new AlumnoRepository();
    var seGuardo = alumnoRepository.Guardar(alumno);

    return Results.Ok();
});

app.MapGet("/api/alumno/demo", (AlumnoRepository alumnoRepository1, 
                                AlumnoRepository alumnoRepository2) =>
{
    //var alumnoRepository1 = new AlumnoRepository();
    //var alumnoRepository2 = new AlumnoRepository();

    var alumnos = alumnoRepository1.Todos();

    return alumnos;
});




app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
