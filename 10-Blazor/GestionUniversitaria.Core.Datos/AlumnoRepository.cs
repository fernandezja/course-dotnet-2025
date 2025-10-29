using GestionUniversitaria.Core.Entidades;

namespace GestionUniversitaria.Core.Datos
{
    public class AlumnoRepository
    {
        public bool Guardar(Alumno alumno)
        {
            
            var dbContext = new GestionUniversitariaDBContext();
            dbContext.Alumnos.Add(alumno);
            dbContext.SaveChanges();


            return true; // Simulación de éxito
        }


        public List<Alumno> Todos()
        {

            var dbContext = new GestionUniversitariaDBContext();
           
            return dbContext.Alumnos.ToList();
        }
    }
}
