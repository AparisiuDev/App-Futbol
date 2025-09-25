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
        private int _victorias = 0;
        private int _derrotas = 0;
        private int _empates = 0;
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

        public int Victorias
        {
            get { return _victorias; }
            set { _victorias = value; }
        }
        public int Derrotas
        {
            get { return _derrotas; }
            set { _derrotas = value; }
        }
        public int Empates
        {
            get { return _empates; }
            set { _empates = value; }
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

        public void VenderPlayer(Jugador player, Equipo equipo)
        {
            // Verificar si el jugador existe en la lista actual
            Jugador jugadorEnEquipo = Jugadores.First(p => p.Nombre == player.Nombre);
            if (jugadorEnEquipo != null)
            {
                // Quitar el jugador de la lista actual
                Jugadores.Remove(jugadorEnEquipo);
                
                // Agregar el jugador a la lista del equipo destino
                if (equipo.Jugadores == null)
                    equipo.Jugadores = new List<Jugador>();

                equipo.Jugadores.Add(jugadorEnEquipo);

                // Actualizar la referencia del equipo en el jugador
                jugadorEnEquipo.Equipo = Nombre;
            }
        }

        public void ComprarPlayer(string player)
        {
            Random rng = new Random();
            int edad = rng.Next(16, 41);
            Console.WriteLine("Que dorsal le quieres dar?");
            int dorsal = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuál es la posición del jugador? POR, DEF, MC, DEL");
            string posicion = Console.ReadLine().ToUpper();
            Console.WriteLine("¿Cuál es la nacionalidad del jugador?");
            string nacionalidad = Console.ReadLine().ToUpper();

            if (Jugadores == null)
                Jugadores = new List<Jugador>();
            Jugadores.Add(new Jugador(player, dorsal, edad, posicion, nacionalidad, Nombre));
        }

        public void JugarPartido(string rival)
        {
            Random rng = new Random();
            //Randomizar entre 0 y 5
            int score1 = rng.Next(0, 6);
            int score2 = rng.Next(0, 6);

            Console.WriteLine("RESULTADO DEL PARTIDO:");
            Console.WriteLine($"{Nombre} {score1} - {rival} {score2}");

            //Repartir los goles y asistencias del equipo que controlamos
            RepartirGoles(score1);
            RepartirAsistencias(score1);
            //Puntos
            if (score1 > score2)
            {
                Puntos += 3;
                Victorias++;
            }
            if (score1 == score2)
            {
                Puntos++;
                Empates++;
            }
            else 
                Derrotas++;
        }

        public void RepartirGoles(int goles)
        {
            if (Jugadores == null || Jugadores.Count == 0 || goles <= 0)
                return;

            Random rng = new Random();
            for (int i = 0; i < goles; i++)
            {
                // Selecciona un jugador aleatorio
                Jugador jugador = Jugadores[rng.Next(Jugadores.Count)];
                int chance = rng.Next(0, 101); 

                int probabilidad = 0;
                switch (jugador.Posicion.ToUpper())
                {
                    case "POR":
                        probabilidad = 0;
                        break;
                    case "DEF":
                        probabilidad = 20;
                        break;
                    case "MC":
                        probabilidad = 30;
                        break;
                    case "DEL":
                        probabilidad = 50;
                        break;
                }

                if (chance < probabilidad)
                {
                    jugador.AddGoals(1);
                }
                else
                {
                    // Repetir ciclo
                    i--;
                }
            }

        }

        //Repartir assitencias
        public void RepartirAsistencias(int asistencias)
        {
            if (Jugadores == null || Jugadores.Count == 0 || asistencias <= 0)
                return;

            Random rng = new Random();
            for (int i = 0; i < asistencias; i++)
            {
                int chanceNoRepartir = rng.Next(0, 101); 
                if (chanceNoRepartir < 5)
                    continue;

                Jugador jugador = Jugadores[rng.Next(Jugadores.Count)];
                int chance = rng.Next(0, 101); 

                int probabilidad = 0;
                switch (jugador.Posicion.ToUpper())
                {
                    case "DEL":
                        probabilidad = 40;
                        break;
                    case "MC":
                        probabilidad = 30;
                        break;
                    case "DEF":
                        probabilidad = 20;
                        break;
                    case "POR":
                        probabilidad = 5;
                        break;
                }

                if (chance < probabilidad)
                   jugador.AddAssists(1);
                else
                    i--;
            }
        }

        // Esneñar estadiscitcas de todos los jugadores del equipo
        public void ShowAllStats()
        {
            Console.WriteLine($"\n---ESTADISTICAS DEL CLUB----");
            Console.WriteLine($"W:{Victorias} D: {Empates} L: {Derrotas}");
            Console.WriteLine("\n----ESTADISTICAS DE TODOS LOS JUGADORES----");
            foreach (Jugador jugador in Jugadores)
                Console.WriteLine($" {jugador.Dorsal} {jugador.Nombre} {jugador.Nacionalidad} - G:{jugador.Goles} A:{jugador.Asistencias}");
        }
    }
}
