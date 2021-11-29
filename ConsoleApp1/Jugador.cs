using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Jugador
    {
        public string id, nombre;
        public int puntos;

        public Jugador(string id, string nombre, int puntos)
        {
            this.id = id;
            this.nombre = nombre;
            this.puntos = puntos;
        }
    }
}
