using System;

namespace semana6
{
    public class NodoInvertir
    {
        public int Dato;
        public NodoInvertir Siguiente;

        public NodoInvertir(int dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }

    public class ListaInvertible
    {
        private NodoInvertir cabeza;

        public void Agregar(int dato)
        {
            NodoInvertir nuevo = new NodoInvertir(dato);
            nuevo.Siguiente = cabeza;
            cabeza = nuevo;
        }

        public void Invertir()
        {
            NodoInvertir anterior = null;
            NodoInvertir actual = cabeza;
            NodoInvertir siguiente;

            while (actual != null)
            {
                siguiente = actual.Siguiente;
                actual.Siguiente = anterior;
                anterior = actual;
                actual = siguiente;
            }

            cabeza = anterior;
        }

        public void Mostrar()
        {
            NodoInvertir actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.Dato + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }
    }

    public class Ejercicio2_InvertirLista
    {
        public static void Probar()
        {
            ListaInvertible lista = new ListaInvertible();
            lista.Agregar(1);
            lista.Agregar(2);
            lista.Agregar(3);
            lista.Agregar(4);

            Console.WriteLine("Lista original:");
            lista.Mostrar();

            lista.Invertir();

            Console.WriteLine("Lista invertida:");
            lista.Mostrar();
        }
    }
}
