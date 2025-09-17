namespace GestionUniversitaria.Libreria.Tests
{
    public class AlumnoTest
    {
        [Fact]
        public void DebeTenerUnNombre()
        {
            var fechaNacimiento20000917 = new DateOnly(2000, 9, 17);

            Alumno a1 = new Alumno("Juan Perez", fechaNacimiento20000917);


            //a1.Nombre = "Juan Perez";
            //a1.FechaNacimiento = new DateOnly(2000, 1, 1);


            Assert.Equal("Juan Perez", a1.Nombre);
            Assert.Equal(2000, a1.FechaNacimiento.Year);
        }


        [Fact]
        public void DebeCrearUnAlumnoDesdeConstructorConNombreYFechaNacimiento()
        {
            var fechaNacimiento20000917 = new DateOnly(2000, 9, 17);
           
            Alumno a1 = new Alumno("Juan Perez", fechaNacimiento20000917);
     
           

            Assert.Equal("Juan Perez", a1.Nombre);
            Assert.Equal(2000, a1.FechaNacimiento.Year);
        }


        [Fact]
        public void DebeCrearUnAlumnoCon25Anios()
        {
            var fechaNacimiento20000917 = new DateOnly(2000, 9, 17);

            Alumno a1 = new Alumno("Juan Perez", fechaNacimiento20000917);

            Assert.Equal(25, a1.Edad);
        }

        [Fact]
        public void DebeCrearUnAlumnoCon24Anios()
        {
            var fechaNacimiento20010917 = new DateOnly(2001, 9, 17);

            Alumno a1 = new Alumno("Juan Perez", fechaNacimiento20010917);
           
            Assert.Equal(24, a1.Edad);
        }
    }
}
