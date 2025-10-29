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

        public void Eliminar(int alumnoId)
        {
            var dbContext = new GestionUniversitariaDBContext();

            var alumno = dbContext.Alumnos.Find(alumnoId);

            if (alumno is not null)
            {
                dbContext.Alumnos.Remove(alumno);
                dbContext.SaveChanges();
            }
        }
    }
}
