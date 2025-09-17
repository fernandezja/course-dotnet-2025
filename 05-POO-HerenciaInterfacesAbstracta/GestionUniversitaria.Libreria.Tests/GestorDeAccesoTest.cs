namespace GestionUniversitaria.Libreria.Tests
{
    public class GestorDeAccesoTest
    {
        [Fact]
        public void DebeMarcarCuandoIngresa1Persona()
        {
            var fechaNacimiento20000917 = new DateOnly(2000, 9, 17);

            Profesor p1 = new Profesor("Juan Perez PROFESOR", fechaNacimiento20000917);
            
            GestorDeAcceso gestor = new GestorDeAcceso();

            gestor.RegistrarIngreso(p1);

            Assert.Equal(1, gestor.IngresosCantidad());
        }


        [Fact]
        public void DebeMarcarCuandoIngresa2Personas()
        {
            var fechaNacimiento20000917 = new DateOnly(2000, 9, 17);

            Profesor p1 = new Profesor("Juan Perez PROFESOR", fechaNacimiento20000917);
            Profesor p2 = new Profesor("Juan Perez PROFESOR", fechaNacimiento20000917);

            GestorDeAcceso gestor = new GestorDeAcceso();

            gestor.RegistrarIngreso(p1);
            gestor.RegistrarIngreso(p2);

            Assert.Equal(2, gestor.IngresosCantidad());
        }


        [Fact]
        public void DebeMarcarCuandoIngresa2Personas1Alumno1Profesor()
        {
            var fechaNacimiento20000917 = new DateOnly(2000, 9, 17);

            Profesor p1 = new Profesor("Juan Perez PROFESOR", fechaNacimiento20000917);
            Alumno a1 = new Alumno("Juan Perez ALUMNO", fechaNacimiento20000917);

            GestorDeAcceso gestor = new GestorDeAcceso();

            gestor.RegistrarIngreso(p1);

            Assert.Equal(1, gestor.IngresosCantidad());

            gestor.RegistrarIngreso(a1);

            Assert.Equal(2, gestor.IngresosCantidad());

        }


        [Fact]
        
    }
}
