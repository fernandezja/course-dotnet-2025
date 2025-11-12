using GestionUniversitaria.Core.Entidades;

namespace GestionUniversitaria.Core.Datos
{
    public class AlumnoRepository
    {
        public int UniqueId { 
            get { 
               return this.GetHashCode();
            } 
        } 

        private GestionUniversitariaDBContext _dBContext;


        //Lazy Load
        private GestionUniversitariaDBContext GetDBContext()
        {
            if (_dBContext is null)
            {
                _dBContext = new GestionUniversitariaDBContext();
            }

            return _dBContext;
        }


        public bool Guardar(Alumno alumno)
        {
            
            var dbContext = GetDBContext();
            dbContext.Alumnos.Add(alumno);
            dbContext.SaveChanges();


            return true; // Simulación de éxito
        }


        public List<Alumno> Todos()
        {

            var dbContext = GetDBContext();
           
            return dbContext.Alumnos.ToList();
        }

        public void Eliminar(int alumnoId)
        {
            var dbContext = GetDBContext();

            var alumno = dbContext.Alumnos.Find(alumnoId);

            if (alumno is not null)
            {
                dbContext.Alumnos.Remove(alumno);
                dbContext.SaveChanges();
            }
        }

        public Alumno Obtener(int alumnoId)
        {
            var dbContext = GetDBContext();

            var alumno = dbContext.Alumnos.Find(alumnoId);

            return alumno;
        }
    }
}
