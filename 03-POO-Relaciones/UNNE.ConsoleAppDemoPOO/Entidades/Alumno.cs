using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNNE.ConsoleAppDemoPOO.Entidades
{
    public class Alumno : Persona
    {
        public DateTime FechaNacimiento { get; set; }

        public int Edad { 
            get {
                return CalcularEdadInterno();
            } 
        }

        public Alumno()
        {
        }

        private int CalcularEdadInterno()
        {
            var hoy = DateTime.Today;
            var edad = hoy.Year - FechaNacimiento.Year;
            if (FechaNacimiento > hoy.AddYears(-edad)) edad--;
            return edad;
        }
    }
}
