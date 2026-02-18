using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Conjunto universal: 500 ciudadanos
        HashSet<string> ciudadanos = new HashSet<string>();

        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add("Ciudadano " + i);
        }

        // Conjunto Pfizer (75 ciudadanos)
        HashSet<string> pfizer = new HashSet<string>();

        for (int i = 1; i <= 75; i++)
        {
            pfizer.Add("Ciudadano " + i);
        }

        // Conjunto AstraZeneca (75 ciudadanos)
        HashSet<string> astraZeneca = new HashSet<string>();

        for (int i = 50; i <= 124; i++)
        {
            astraZeneca.Add("Ciudadano " + i);
        }

        // Ambas dosis (Intersección)
        var ambasDosis = pfizer.Intersect(astraZeneca);

        // Unión de vacunados
        var vacunados = pfizer.Union(astraZeneca);

        // No vacunados
        var noVacunados = ciudadanos.Except(vacunados);

        // Solo Pfizer
        var soloPfizer = pfizer.Except(astraZeneca);

        // Solo AstraZeneca
        var soloAstraZeneca = astraZeneca.Except(pfizer);

        // Mostrar resultados
        Console.WriteLine("===== CIUDADANOS CON AMBAS DOSIS =====");
        foreach (var c in ambasDosis)
            Console.WriteLine(c);

        Console.WriteLine("\n===== CIUDADANOS NO VACUNADOS =====");
        foreach (var c in noVacunados)
            Console.WriteLine(c);

        Console.WriteLine("\n===== CIUDADANOS SOLO PFIZER =====");
        foreach (var c in soloPfizer)
            Console.WriteLine(c);

        Console.WriteLine("\n===== CIUDADANOS SOLO ASTRAZENECA =====");
        foreach (var c in soloAstraZeneca)
            Console.WriteLine(c);
    }
}

