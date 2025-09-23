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
        private bool _esLesionado = false;
        private int _goles = 0;
        private int _asistencias = 0;
        private string _nacionalidad;
        private Equipo _equipo;

        // Propiedades
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public int Dorsal
        {
            get { return _dorsal; }
            set { _dorsal = value; }
        }

        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
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

        public Equipo Equipo
        {
            get { return _equipo; }
            set { _equipo = value; }
        }

        // Constructor
        public Jugador(string nombre, int dorsal, int edad, string posicion, string nacionalidad)
        {
            Nombre = nombre;
            Dorsal = dorsal;
            Edad = edad;
            Posicion = posicion;
            Nacionalidad = nacionalidad;
        }


        // Metodo ToString
        public override string ToString()
        {
            return $"Nombre: {Nombre}, Dorsal: {Dorsal}, Edad: {Edad}, Posición: {Posicion}, " +
                $"Lesionado: {EsLesionado}, Goles: {Goles}, Asistencias: {Asistencias}, Nacionalidad: {Nacionalidad}";
        }



    }
}
