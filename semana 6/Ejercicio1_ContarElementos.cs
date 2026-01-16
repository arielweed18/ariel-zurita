using System;

namespace semana6
{
    public class Nodo
    {
        public int Dato;
        public Nodo Siguiente;

        public Nodo(int dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }

    public class ListaEnlazada
    {
        private Nodo cabeza;

        public void Agregar(int dato)
        {
            Nodo nuevo = new Nodo(dato);

            if (cabeza == null)
                cabeza = nuevo;
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                    actual = actual.Siguiente;

                actual.Siguiente = nuevo;
            }
        }

        public int ContarElementos()
        {
            int contador = 0;
            Nodo actual = cabeza;

            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }

            return contador;
        }
    }

    public class Ejercicio1_ContarElementos
    {
        public static void Probar()
        {
            ListaEnlazada lista = new ListaEnlazada();
            lista.Agregar(5);
            lista.Agregar(10);
            lista.Agregar(15);
            lista.Agregar(20);

            Console.WriteLine("Cantidad de elementos: " + lista.ContarElementos());
        }
    }
}
