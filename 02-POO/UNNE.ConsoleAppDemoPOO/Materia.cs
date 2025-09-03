using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNNE.ConsoleAppDemoPOO
{
    internal class Materia
    {
        //private string docente;

        //public string GetDocente() { 
        //    return docente;
        //}

        //public void SetDocente(string valor)
        //{
        //     docente = valor;
        //}

        public string Docente { get; set; }



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
