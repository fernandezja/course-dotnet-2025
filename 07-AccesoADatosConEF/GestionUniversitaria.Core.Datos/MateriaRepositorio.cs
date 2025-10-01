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
        private ConfigActual _configActual;

        public MateriaRepositorio(ConfigActual configActual)
        {
            _configActual = configActual;
        }

        public List<Materia> ListadoFiltrado(string textoParaFiltrar) {

            //1 - Conexion
         
            var conn = new Microsoft.Data.SqlClient.SqlConnection(_configActual.ConnectionString);


            //2 - Comando
            var query = "SELECT MateriaId, Nombre FROM Materia WHERE Nombre LIKE '%'+@TextoParaFiltrar+'%'";
            var command = new Microsoft.Data.SqlClient.SqlCommand();
            command.Connection = conn;
            command.CommandText = query;
            command.CommandType = System.Data.CommandType.Text;

            //Agregar parametros @TextoParaFiltrar
            var parametro1 = new Microsoft.Data.SqlClient.SqlParameter();
            parametro1.ParameterName = "@TextoParaFiltrar";
            parametro1.SqlDbType = System.Data.SqlDbType.VarChar;
            parametro1.Size = 100;
            parametro1.Value = textoParaFiltrar;

            command.Parameters.Add(parametro1);



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
