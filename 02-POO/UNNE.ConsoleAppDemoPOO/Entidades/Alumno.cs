using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNNE.ConsoleAppDemoPOO.Entidades
{
    public class Alumno
    {


        private string _nombre;

        public string Nombre
        {
            get { 
                //Acciones
                return _nombre;
            }
            set {
                //Acciones
                _nombre = value;
                //Acciones
            }
        }


        public string Formatear() {
            return $"MATERIA: {Nombre}";
        }
    }
}
