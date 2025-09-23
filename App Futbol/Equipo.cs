using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Futbol
{
    internal class Equipo
    {
        private string _nombre;
        private int _puntos;
        private List<Jugador> _jugadorList;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public int Puntos
        {
            get { return _puntos; }
            set { _puntos = value; }
        }

        public List<Jugador> Jugadores
        {
            get { return _jugadorList; }
            set { _jugadorList = value; }
        }
        public Equipo()
        {

        }

        public Equipo(string nombre)
        {
            Nombre = nombre;
        }

        public Equipo(string nombre, int puntos)
        {
            Nombre = nombre;
            Puntos = puntos;
        }
    }
}
