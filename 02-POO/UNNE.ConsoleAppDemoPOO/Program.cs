using UNNE.ConsoleAppDemoPOO;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int anio = 2025;
string demo = "2025";

UNNE.ConsoleAppDemoPOO.Materia materia0;

Materia materia;
materia = new Materia();
materia.Docente = "Profesor 1";
materia.Nombre = "Programacion III";

Console.WriteLine($"{materia.Formatear()}");

Console.ReadKey();
