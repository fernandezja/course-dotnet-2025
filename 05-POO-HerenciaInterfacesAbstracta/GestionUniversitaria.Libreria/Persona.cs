using GestionUniversitaria.Libreria.Interfaces;

namespace GestionUniversitaria.Libreria
{
    public abstract class Persona: INombrable,
                                   IRegistrableEnEntrada
    {
        private DateOnly _fechaNacimiento2;
       
        public string Nombre { get; set; }

        public DateOnly FechaNacimiento 
        { 
            get {
                //Acciones adicionales
                return _fechaNacimiento2;
            }
            private set { 
                //Acciones adicionales
                _fechaNacimiento2 = value;
            }
           
        }

        public int Edad
        {
            get
            {
                //Acciones adicionales
                return CalcularEdad();
            }

        }

        private int CalcularEdad()
        {
            DateOnly hoy = DateOnly.FromDateTime(DateTime.Now);
            int edad = hoy.Year - this.FechaNacimiento.Year;
            if (hoy < this.FechaNacimiento.AddYears(edad))
            {
                edad--;
            }
            return edad;

        }

        //public DateOnly FechaNacimiento2 { get; }

        public Persona(string nombre, DateOnly fechaNacimiento)
        {
            this.Nombre = nombre;
            this.FechaNacimiento = fechaNacimiento;
        }

    }
}
