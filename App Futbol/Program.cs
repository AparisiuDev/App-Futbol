using System;
using System.Collections.Generic;
using System.IO;
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
            int n = 0;
            Liga LaLiga = new Liga();
            //Path para guardar
            string filePath = "liga.json";

            // Si ya existe un archivo guardado, lo cargamos, si no, creamos uno de 0
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                LaLiga = JsonConvert.DeserializeObject<Liga>(json);
                Console.WriteLine($"Se cargó la liga existente");
            }
            else
            {
                Console.WriteLine("Bienvenid@ a LaLiga!");
                Console.WriteLine("Pulsa cualquier tecla para empezar");
                Console.ReadKey();

                Console.Clear();
                Console.WriteLine("Crea un primer equipo");
                LaLiga.AddTeam();
            }


            while (!exit)
            {
                Console.Clear();

                Console.WriteLine("Bienvenido al gestor de fútbol, qué quieres hacer?\n");
                Console.WriteLine($"Equipo actual seleccionado: {LaLiga.Equipos[n].Nombre}");
                Console.WriteLine(
                  "1. Crear un equipo\n" +
                  "2. Crear un jugador\n" +
                  "3. Ver estadisticas\n" + 
                  "4. Jugar un partido\n" +
                  "5. Seleccionar otro equipo\n" +
                  "0. Salir (Se guardará los Jugadores Creados)\n");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        LaLiga.AddTeam();
                        //exit = true;
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Has elegido la opción 1: Crear Jugador\n"+
                            "Qué jugador quieres comprar?");
                        LaLiga.Equipos[n].ComprarPlayer(Console.ReadLine());
                        //exit = true;
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Has elegido la opción 2: Listar Jugadores\n");
                        // Aquí iría el código para listar los jugadores
                        LaLiga.Equipos[n].ShowAllStats();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("Elije que equipos quieres enfrentar! (Usa su nunero en la clasificacion)");
                        LaLiga.MostrarClasificacion();
                        Console.WriteLine("Equipo local:");
                        int team1 = int.Parse(Console.ReadLine())-1;
                        Console.WriteLine("Equipo visitante: ");
                        int team2 = int.Parse(Console.ReadLine()) - 1;
                        LaLiga.HacerPartido(LaLiga.Equipos[team1], LaLiga.Equipos[team2]);
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.Write("Selecciona el equipo que quieres editar!");
                        LaLiga.MostrarClasificacion();
                        n = int.Parse(Console.ReadLine()) - 1;
                        break;
                    case 0:
                        // Guardar el equipo en JSON antes de salir
                        string json = JsonConvert.SerializeObject(LaLiga);
                        File.WriteAllText(filePath, json);
                        Console.WriteLine("Equipo guardado. Adios!");
                        Console.ReadKey();
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}
