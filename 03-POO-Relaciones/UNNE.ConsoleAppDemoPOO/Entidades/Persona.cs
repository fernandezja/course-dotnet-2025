
namespace UNNE.ConsoleAppDemoPOO.Entidades
{
    public class Persona
    {

        private string _nombre;

        public string Nombre
        {
            get
            {
                //Acciones
                return _nombre;
            }
            set
            {
                //Acciones
                _nombre = value;
                //Acciones
            }
        }


        public string Formatear()
        {
            return $"MATERIA: {Nombre}";
        }
    }
}
