// See https://aka.ms/new-console-template for more information
using GestionUniversitaria.Core.Datos;
using GestionUniversitaria.Core.Datos.Entidades;
using Microsoft.Extensions.Configuration;


//Leer la configuracion desde appsettings.json
var builder = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory)
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();


var titulo = builder.GetValue<string>("Titulo");

//var connectionString1 = builder.GetValue<string>("ConnectionStrings:DefaultConnectionString");
var connectionString = builder.GetConnectionString("DefaultConnectionString");


Console.WriteLine("Acceso a Datos!");


var configActual = new ConfigActual
{
    Titulo = titulo,
    ConnectionString = connectionString
};

var repositorio = new MateriaRepositorio(configActual);

var materias = repositorio.ListadoFiltrado("status");

Console.WriteLine("Listado de materias: ", materias.Count());

foreach (var materia in materias)
{
    Console.WriteLine($"MateriaId: {materia.MateriaId}, Nombre: {materia.Nombre}");
}
