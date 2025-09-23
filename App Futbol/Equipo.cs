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
        private int _puntos = 0;
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

        public void TraspasarPlayer(Jugador player, Equipo equipo)
        {
            // Verificar si el jugador existe en la lista actual
            Jugador jugadorEnEquipo = Jugadores.FirstOrDefault(p => p.Nombre == player.Nombre);
            if (jugadorEnEquipo != null)
            {
                // Quitar el jugador de la lista actual
                Jugadores.Remove(jugadorEnEquipo);
                
                // Agregar el jugador a la lista del equipo destino
                if (equipo.Jugadores == null)
                    equipo.Jugadores = new List<Jugador>();
                equipo.Jugadores.Add(jugadorEnEquipo);

                // Actualizar la referencia del equipo en el jugador
                jugadorEnEquipo.Equipo = equipo;
            }
        }
    }
}
