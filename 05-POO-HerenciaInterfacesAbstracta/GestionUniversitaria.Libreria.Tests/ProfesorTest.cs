namespace GestionUniversitaria.Libreria.Tests
{
    public class ProfesorTest
    {
        [Fact]
        public void DebeTenerUnNombre()
        {
            Profesor p1 = new Profesor();
            p1.Nombre = "Juan Perez PROFESOR";

            Assert.Equal("Juan Perez PROFESOR", p1.Nombre);
        }
    }
}
