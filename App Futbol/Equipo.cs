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
        private string _nacionalidad;
        private int _puntos;
        public Equipo()
        {

        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Nacionalidad
        {
            get { return _nacionalidad; }
            set { _nombre = value; }
        }
        public int Puntos
        {
            get { return _puntos; }
            set { _puntos = value; }
        }
    }
}
