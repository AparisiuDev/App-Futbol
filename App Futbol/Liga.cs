using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Futbol
{
    internal class Liga
    {
        private List<Equipo> _laLiga;

        public List<Equipo> LaLiga
        {
            get { return _laLiga; }
            set { _laLiga = value; }
        }

        public void OrdenarPorPuntos()
        {
            // Ordenar de mayor a menor
            _laLiga = _laLiga.OrderByDescending(e => e.Puntos).ToList();
        }

        public void MostrarClasificacion()
        {
            OrdenarPorPuntos();

            Console.WriteLine("=== Clasificación de LaLiga ===");
            int pos = 1;
            foreach (var equipo in _laLiga)
            {
                Console.WriteLine($"{pos}. {equipo.Nombre} - {equipo.Puntos} pts");
                pos++;
            }
        }

    }
}
