using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace App_Futbol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            Console.WriteLine("Como quieres llamar a tu equipo?");
            string nombreEquipo = Console.ReadLine();
            Equipo tuEquipo = new Equipo(nombreEquipo);

            while (exit==false)
            {
                Console.Clear();
                Console.WriteLine("Bienvenido al gestor de fútbol, qué quieres hacer?\n" +
                  "1. Para crear un Jugador\n" +
                  "2. Listar un Jugador\n" + 
                  "3. Jugar un partido\n");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Has elegido la opción 1: Crear Jugador\n"+
                            "Qué jugador quieres comprar?");
                        tuEquipo.ComprarPlayer(Console.ReadLine());
                        //exit = true;
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Has elegido la opción 2: Listar Jugadores");
                        // Aquí iría el código para listar los jugadores
                        tuEquipo.ShowAllStats();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Elije contra que equipo quieres jugar!");
                        tuEquipo.JugarPartido(Console.ReadLine());
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}
