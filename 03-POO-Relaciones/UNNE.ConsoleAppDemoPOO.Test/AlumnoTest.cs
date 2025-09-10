using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNNE.ConsoleAppDemoPOO.Test
{
    public class AlumnoTest
    {

        [Fact]
        public void DebeTenerUnNombre()
        {
           
            var alumno = new Entidades.Alumno();
            var nombreEsperado = "Juan Perez";
           
            alumno.Nombre = nombreEsperado;
            
            Assert.Equal(nombreEsperado, alumno.Nombre);
        }

        [Fact]
        public void DebeTenerUnaEdadDe25()
        {

            var alumno = new Entidades.Alumno();           

            alumno.FechaNacimiento = new DateTime(2000, 9, 10);

            Assert.Equal(25, alumno.Edad);
        }

        [Fact]
        public void DebeTenerUnaEdadDe20()
        {

            var alumno = new Entidades.Alumno();

            alumno.FechaNacimiento = new DateTime(2005, 9, 10);

            Assert.Equal(20, alumno.Edad);
        }
    }
}
