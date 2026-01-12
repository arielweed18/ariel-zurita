using System;

class Program
{
	static void Main()
	{
		int opcion;

		do
		{
			Console.Clear();
			Console.WriteLine("MENÚ PRINCIPAL");
			Console.WriteLine("1. Ejercicio 1 (Suma)");
			Console.WriteLine("2. Ejercicio 2 (Par o Impar)");
			Console.WriteLine("3. Ejercicio 3 (Mayor de 3 números)");
			Console.WriteLine("4. Ejercicio 4 (Tabla de multiplicar)");
			Console.WriteLine("5. Ejercicio 5 (Factorial)");
			Console.WriteLine("0. Salir");
			Console.Write("Seleccione una opción: ");

			opcion = int.Parse(Console.ReadLine());

			Console.Clear();

			switch (opcion)
			{
				case 1:
					Ejercicio1();
					break;
				case 2:
					Ejercicio2();
					break;
				case 3:
					Ejercicio3();
					break;
				case 4:
					Ejercicio4();
					break;
				case 5:
					Ejercicio5();
					break;
				case 0:
					Console.WriteLine("Saliendo del programa...");
					break;
				default:
					Console.WriteLine("Opción inválida");
					break;
			}

			Console.WriteLine("\nPresione una tecla para continuar...");
			Console.ReadKey();

		} while (opcion != 0);
	}

	static void Ejercicio1()
	{
		Console.WriteLine("Ejercicio 1");
		Console.Write("Ingrese el primer número: ");
		int a = int.Parse(Console.ReadLine());
		Console.Write("Ingrese el segundo número: ");
		int b = int.Parse(Console.ReadLine());
		int suma = a + b;
		Console.WriteLine("La suma es: " + suma);
	}

	static void Ejercicio2()
	{
		Console.WriteLine("Ejercicio 2");
		Console.Write("Ingrese un número: ");
		int n = int.Parse(Console.ReadLine());
		if (n % 2 == 0)
			Console.WriteLine("El número es par");
		else
			Console.WriteLine("El número es impar");
	}

	static void Ejercicio3()
	{
		Console.WriteLine("Ejercicio 3");
		Console.Write("Ingrese el primer número: ");
		int a = int.Parse(Console.ReadLine());
		Console.Write("Ingrese el segundo número: ");
		int b = int.Parse(Console.ReadLine());
		Console.Write("Ingrese el tercer número: ");
		int c = int.Parse(Console.ReadLine());

		int mayor = a;
		if (b > mayor) mayor = b;
		if (c > mayor) mayor = c;

		Console.WriteLine("El mayor es: " + mayor);
	}

	static void Ejercicio4()
	{
		Console.WriteLine("Ejercicio 4");
		Console.Write("Ingrese un número: ");
		int n = int.Parse(Console.ReadLine());

		for (int i = 1; i <= 10; i++)
		{
			Console.WriteLine($"{n} x {i} = {n * i}");
		}
	}

	static void Ejercicio5()
	{
		Console.WriteLine("Ejercicio 5");
		Console.Write("Ingrese un número: ");
		int n = int.Parse(Console.ReadLine());

		int factorial = 1;
		for (int i = 1; i <= n; i++)
		{
			factorial *= i;
		}

		Console.WriteLine("El factorial es: " + factorial);
	}
}