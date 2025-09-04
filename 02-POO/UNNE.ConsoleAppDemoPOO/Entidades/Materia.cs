using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNNE.ConsoleAppDemoPOO.Entidades
{
    public class Materia
    {
        //private string docente;

        //public string GetDocente() { 
        //    return docente;
        //}

        //public void SetDocente(string valor)
        //{
        //     docente = valor;
        //}

        public Profesor Docente { get; set; }



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
            //interpolacion
            return $"MATERIA: {Nombre}";
            //return "MATERIA: " + Nombre;
        }
    }
}
