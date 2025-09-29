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
            Equipo tuEquipo;
            //Path para guardar
            string filePath = "equipo.json";

            // Si ya existe un archivo guardado, lo cargamos, si no, creamos uno de 0
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                tuEquipo = JsonConvert.DeserializeObject<Equipo>(json);
                Console.WriteLine($"Se cargó el equipo existente: {tuEquipo.Nombre}");
            }
            else
            {
                Console.WriteLine("Como quieres llamar a tu equipo?");
                string nombreEquipo = Console.ReadLine();
                tuEquipo = new Equipo(nombreEquipo);
            }


            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Bienvenido al gestor de fútbol, qué quieres hacer?\n" +
                  "1. Para crear un Jugador\n" +
                  "2. Ver estadisticas\n" + 
                  "3. Jugar un partido\n" +
                  "0. Salir (Se guardará los Jugadores Creados)\n");

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
                        Console.WriteLine("Has elegido la opción 2: Listar Jugadores\n");
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
                    case 0:
                        // Guardar el equipo en JSON antes de salir
                        string json = JsonConvert.SerializeObject(tuEquipo);
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
