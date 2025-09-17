namespace GestionUniversitaria.Libreria.Tests
{
    public class ProfesorTest
    {
        [Fact]
        public void DebeTenerUnNombre()
        {
            var fechaNacimiento20000917 = new DateOnly(2000, 9, 17);

            Profesor p1 = new Profesor("Juan Perez PROFESOR", fechaNacimiento20000917);
            
            //p1.Nombre = "Juan Perez PROFESOR";

            Assert.Equal("Juan Perez PROFESOR", p1.Nombre);
        }
    }
}
