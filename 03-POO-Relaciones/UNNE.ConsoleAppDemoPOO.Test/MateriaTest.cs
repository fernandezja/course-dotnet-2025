using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UNNE.ConsoleAppDemoPOO.Entidades;

namespace UNNE.ConsoleAppDemoPOO.Test
{
    public class MateriaTest
    {
        [Fact]
        public void UnaMateriaDebeTenerAsociadoUnProfesor()
        {
            //Profesor profesor1 = new Profesor();
            //profesor1.Nombre = "Profesor 1";

            Profesor profesor1 = new Profesor() {
                Nombre = "Profesor 1"
            };

            Materia materia = new Materia();
            materia.Docente = profesor1;
            materia.Nombre = "Programacion III";

            Assert.NotNull(materia.Docente);
            Assert.Equal("Profesor 1", materia.Docente.Nombre);

        }
    }
}
