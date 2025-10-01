// See https://aka.ms/new-console-template for more information
using GestionUniversitaria.Core.Datos.Entidades;

Console.WriteLine("Acceso a Datos!");

var connectionString = "Data Source=.;Initial Catalog=GestionUniversitaria;Integrated Security=true;TrustServerCertificate=True;";

var repositorio = new GestionUniversitaria.Core.Datos.MateriaRepositorio(connectionString);

var materias = repositorio.ListadoFiltrado("status");

Console.WriteLine("Listado de materias: ", materias.Count());

foreach (var materia in materias)
{
    Console.WriteLine($"MateriaId: {materia.MateriaId}, Nombre: {materia.Nombre}");
}
