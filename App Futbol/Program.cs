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

            List<Jugador> jugadores = new List<Jugador>
            {
            new Jugador("Lionel Messi", 10, 36, "Delantero","Argentina"),
            new Jugador("Cristiano Ronaldo", 7, 38, "Delantero", "Portugal"),
            new Jugador("Kevin De Bruyne", 17, 32, "Centrocampista", "Bélgica"),
            new Jugador("Virgil van Dijk", 4, 34, "Defensa", "Países Bajos"),
            new Jugador("Thibaut Courtois", 1, 33, "Portero", "Bélgica")
             };
            //Mostrar la lista de jugadores
            foreach (var jugador in jugadores)
            {
                Console.WriteLine(jugador);
            }



        }
    }
}
