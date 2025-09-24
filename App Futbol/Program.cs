using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Futbol
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Lista de Jugadores
            /***
            List<Jugador> jugadores = new List<Jugador>
            {
            new Jugador("Lionel Messi", 10, 36, "Delantero","Argentina", "Barça"),
            new Jugador("Cristiano Ronaldo", 7, 38, "Delantero", "Portugal", "Barça"),
            new Jugador("Kevin De Bruyne", 17, 32, "Centrocampista", "Bélgica", "Barça"),
            new Jugador("Virgil van Dijk", 4, 34, "Defensa", "Países Bajos", "Barça"),
            new Jugador("Thibaut Courtois", 1, 33, "Portero", "Bélgica", "Barça")
             };
            //Mostrar la lista de jugadores
            foreach (var jugador in jugadores)
            {
                Console.WriteLine(jugador);
            }
            ***/


            Equipo Barcelona = new Equipo("Barcelona");
            Equipo Getafe = new Equipo("Getafe");
            Console.WriteLine("Que jugador quieres comprar?");
            Barcelona.ComprarPlayer(Console.ReadLine());
            
            for (int i = 0; i < Barcelona.Jugadores.Count(); i++)
            {
                Console.WriteLine(Barcelona.Jugadores[i].Equipo);
                Console.WriteLine(Barcelona.Jugadores[i].EsLesionado);
                Console.WriteLine(Barcelona.Jugadores[i].Edad);
                Console.WriteLine(Barcelona.Jugadores[i].Goles);
            }
            Console.WriteLine("Contra quien quieres jugar?");
            Barcelona.JugarPartido(Console.ReadLine());
            Console.ReadKey();
        }
    }
}
