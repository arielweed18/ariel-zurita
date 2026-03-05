using System;
using System.Collections.Generic;

class Program
{
    // Diccionario (Mapa)
    static Dictionary<string, HashSet<string>> equipos = new Dictionary<string, HashSet<string>>();

    static void RegistrarEquipo()
    {
        Console.Write("Ingrese el nombre del equipo: ");
        string nombre = Console.ReadLine();

        if (equipos.ContainsKey(nombre))
        {
            Console.WriteLine("El equipo ya está registrado.\n");
        }
        else
        {
            equipos[nombre] = new HashSet<string>(); // Conjunto
            Console.WriteLine("Equipo registrado correctamente.\n");
        }
    }

    static void AgregarJugador()
    {
        Console.Write("Ingrese el nombre del equipo: ");
        string nombreEquipo = Console.ReadLine();

        if (!equipos.ContainsKey(nombreEquipo))
        {
            Console.WriteLine("El equipo no existe.\n");
            return;
        }

        Console.Write("Ingrese el nombre del jugador: ");
        string jugador = Console.ReadLine();

        if (equipos[nombreEquipo].Add(jugador))
        {
            Console.WriteLine("Jugador agregado correctamente.\n");
        }
        else
        {
            Console.WriteLine("El jugador ya pertenece a este equipo.\n");
        }
    }

    static void MostrarEquipos()
    {
        if (equipos.Count == 0)
        {
            Console.WriteLine("No hay equipos registrados.\n");
            return;
        }

        Console.WriteLine("\n===== LISTA DE EQUIPOS =====");

        foreach (var equipo in equipos)
        {
            Console.WriteLine($"\nEquipo: {equipo.Key}");

            if (equipo.Value.Count == 0)
            {
                Console.WriteLine(" No tiene jugadores.");
            }
            else
            {
                foreach (var jugador in equipo.Value)
                {
                    Console.WriteLine($" - {jugador}");
                }
            }
        }

        Console.WriteLine();
    }

    static void BuscarJugador()
    {
        Console.Write("Ingrese el nombre del jugador a buscar: ");
        string nombre = Console.ReadLine();
        bool encontrado = false;

        foreach (var equipo in equipos)
        {
            if (equipo.Value.Contains(nombre))
            {
                Console.WriteLine($"El jugador {nombre} pertenece al equipo {equipo.Key}.\n");
                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Jugador no encontrado.\n");
        }
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("===== MENÚ TORNEO DE FÚTBOL =====");
            Console.WriteLine("1. Registrar equipo");
            Console.WriteLine("2. Agregar jugador");
            Console.WriteLine("3. Mostrar equipos");
            Console.WriteLine("4. Buscar jugador");
            Console.WriteLine("5. Salir");

            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    RegistrarEquipo();
                    break;
                case "2":
                    AgregarJugador();
                    break;
                case "3":
                    MostrarEquipos();
                    break;
                case "4":
                    BuscarJugador();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Opción inválida.\n");
                    break;
            }
        }
    }
}
