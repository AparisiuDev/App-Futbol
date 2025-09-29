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

        public void AddTeam()
        {
            Console.WriteLine("Añade el nombre del nuevo equipo!");
            Equipo equipo = new Equipo(Console.ReadLine());
            LaLiga.Add(equipo);
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

        public void HacerPartido(Equipo team1, Equipo team2)
        {
            Random rng = new Random();
            //Randomizar entre 0 y 5
            int score1 = rng.Next(0, 6);
            int score2 = rng.Next(0, 6);
            //Resultado
            Console.WriteLine("RESULTADO DEL PARTIDO:");
            Console.WriteLine($"{team1.Nombre} {score1} - {team2} {score2}");

            //Repartir los goles y asistencias de los equipos
            team1.RepartirGoles(score1);
            team1.RepartirAsistencias(score1);
            team2.RepartirGoles(score2);
            team2.RepartirAsistencias(score2);

            //Puntos
            if (score1 > score2)
            {
                team1.Puntos+= 3;
                team1.Victorias++;
                team2.Derrotas++;
            }
            else if (score1 == score2)
            {
                team1.Puntos++;
                team2.Puntos++;
                team1.Empates++;
                team2.Empates++;
            }
            else if(score1 < score2)
            {
                team2.Puntos += 3;
                team2.Victorias++;
                team1.Derrotas++;
            }
        }

    }
}
