using GestionUniversitaria.Libreria.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionUniversitaria.Libreria
{
    public class GestorDeAcceso
    {
        private int Ingresos { get; set; }

        public int IngresosCantidad()
        {
            return Ingresos;
        }

        //public void RegistrarIngreso(Profesor profesor)
        //{
        //    Ingresos++;
        //}

        //public void RegistrarIngreso(Alumno alumno)
        //{
        //    Ingresos++;
        //}

        //public void RegistrarIngreso(Persona persona)
        //{
        //    Ingresos++;
        //}

        public void RegistrarIngreso(IRegistrableEnEntrada alguienRegistrableEnEntrada)
        {
            //alguienRegistrableEnEntrada.No
            Ingresos++;
        }
    }
}
