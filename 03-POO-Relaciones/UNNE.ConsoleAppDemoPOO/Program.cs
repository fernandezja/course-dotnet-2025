using UNNE.ConsoleAppDemoPOO.Entidades;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int anio = 2025;
string demo = "2025";

Materia materia0;

Profesor profesor1 = new Profesor();
profesor1.Nombre = "Profesor 1";

Materia materia;
materia = new Materia();
materia.Docente = profesor1;
materia.Nombre = "Programacion III";

//Materia soporte una lista de alumnos

Console.WriteLine(materia.Formatear());

Console.WriteLine($"DEMO {materia.Formatear()}");

Console.ReadKey();
