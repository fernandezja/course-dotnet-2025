// See https://aka.ms/new-console-template for more information
using GestionUniversitaria.Core.Datos.Entidades;

Console.WriteLine("Acceso a Datos!");

var repositorio = new GestionUniversitaria.Core.Datos.MateriaRepositorio();

var materias = repositorio.ListadoFiltrado("status");

Console.WriteLine("Listado de materias: ", materias.Count());

foreach (var materia in materias)
{
    Console.WriteLine($"MateriaId: {materia.MateriaId}, Nombre: {materia.Nombre}");
}
