using GestionUniversitaria.Libreria.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionUniversitaria.Libreria
{
    public class Invitado: INombrable,
                           IRegistrableEnEntrada
    {
        public string Nombre { get; set; }

        public Invitado( string nombre)
        {
            this.Nombre = nombre;
        }
    }
}
