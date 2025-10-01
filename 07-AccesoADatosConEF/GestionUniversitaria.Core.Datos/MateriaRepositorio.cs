using GestionUniversitaria.Core.Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionUniversitaria.Core.Datos
{
    public class MateriaRepositorio
    {

        public List<Materia> ListadoFiltrado(string textoParaFiltrar) {

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

            //3 - DataReader
            var reader = command.ExecuteReader();


            var materias = new List<Materia>();

            while (reader.Read())
            {
                var materiaId = reader.GetInt32(0);
                var nombre = reader.GetString(1);

                materias.Add(new Materia
                {
                    MateriaId = materiaId,
                    Nombre = nombre
                });

            }



            conn.Close();


            return materias;
        }
    }
}
