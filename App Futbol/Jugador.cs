using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Futbol
{
    internal class Jugador
    {
        // Atributos
        private string _nombre;
        private int _dorsal;
        private int _edad;
        private string _posicion;
        private bool _esLesionado;
        private int _goles;
        private int _asistencias;
        private string _nacionalidad;

        // Propiedades
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public int Numero
        {
            get { return _dorsal; }
            set { _dorsal = value; }
        }

        public int Edad
        {
            get { return Edad; }
            set { Edad = value; }
        }

        public string Posicion
        {
            get { return _posicion; }
            set { _posicion = value; }
        }

        public bool EsLesionado
        {
            get { return _esLesionado; }
            set { _esLesionado = value; }
        }

        public int Goles
        {
            get { return _goles; }
            set { _goles = value; }
        }

        public int Asistencias
        {
            get { return _asistencias; }
            set { _asistencias = value; }
        }

        public string Nacionalidad
        {
            get { return _nacionalidad; }
            set { _nacionalidad = value; }
        }



        // Constructor
        public Jugador()
        {

        }

    }
}
