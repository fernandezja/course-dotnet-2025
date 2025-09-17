namespace GestionUniversitaria.Libreria.Tests
{
    public class AlumnoTest
    {
        [Fact]
        public void DebeTenerUnNombre()
        {
            Alumno a1 = new Alumno();
            a1.Nombre = "Juan Perez";

            Assert.Equal("Juan Perez", a1.Nombre);
        }
    }
}
