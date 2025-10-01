// See https://aka.ms/new-console-template for more information
using GestionUniversitaria.Core.Datos.Entidades;

Console.WriteLine("Acceso a Datos!");


//1 - Conexion
var connectionString = "Data Source=.;Initial Catalog=GestionUniversitaria;Integrated Security=true;TrustServerCertificate=True;";

var conn = new Microsoft.Data.SqlClient.SqlConnection(connectionString);


//2 - Comando
var query = "SELECT MateriaId, Nombre FROM Materia WHERE Nombre LIKE '%status2%'";
var command = new Microsoft.Data.SqlClient.SqlCommand();
command.Connection = conn;
command.CommandText = query;
command.CommandType = System.Data.CommandType.Text;



conn.Open();

Console.WriteLine("Conexión abierta!");

//3 - DataReader
var reader = command.ExecuteReader();


var materias = new List<Materia>();

while (reader.Read())
{
    var materiaId = reader.GetInt32(0);
    var nombre = reader.GetString(1);

    materias.Add(new Materia { 
                    MateriaId = materiaId, 
                    Nombre = nombre 
                });

    //Console.WriteLine($"MateriaId: {materiaId}, Nombre: {nombre}");
}



conn.Close();
Console.WriteLine("Conexión cerrada!");

Console.WriteLine("Listado de materias: ", materias.Count());

foreach (var materia in materias)
{
    Console.WriteLine($"MateriaId: {materia.MateriaId}, Nombre: {materia.Nombre}");
}
