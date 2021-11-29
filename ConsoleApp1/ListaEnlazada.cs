using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ListaEnlazada
    {
        public Nodo AgregarAListaVacia(Nodo nodoFinal, Jugador dato)
        {
            if (nodoFinal != null)
            {
                return nodoFinal;
            }
            Nodo temp = new Nodo();
            temp.dato = dato;
            nodoFinal = temp;
            nodoFinal.next = nodoFinal;
            return nodoFinal;
        }

        public Nodo GenerarListaInicial(Nodo nodoFinal, Jugador dato)
        {
            if (nodoFinal == null)
            {
                return AgregarAListaVacia(nodoFinal, dato);
            }
            Nodo temp = new Nodo();
            temp.dato = dato;
            temp.next = nodoFinal.next;
            nodoFinal.next = temp;
            nodoFinal = temp;
            return nodoFinal;
        }
        public void MostrarLista(Nodo nodoFinal)
        {
            Nodo actual;
            if (nodoFinal == null)
            {
                Console.WriteLine("Mensaje: La lista se encuentra vacía.");
                return;
            }
            actual = nodoFinal.next;
            do
            {
                Console.WriteLine(actual.dato.id + " | " + actual.dato.nombre + " | " + actual.dato.puntos);
                actual = actual.next;
            } while (actual != nodoFinal.next);
            Console.WriteLine();
        }
        public Nodo AgregarJugadorAlFinal(Nodo nodoFinal, Jugador dato)
        {
            if (nodoFinal == null)
            {
                return AgregarAListaVacia(nodoFinal, dato);
            }
            Console.WriteLine(" Se agregó al jugador " + dato.nombre +  "al final - Id: " + dato.id);
            Nodo temp = new Nodo();
            temp.dato = dato;
            temp.next = nodoFinal.next;
            nodoFinal.next = temp;
            nodoFinal = temp;
            return nodoFinal;
        }
        public void EliminarJugadorDespuesDe(Nodo nodoFinal, Jugador referencia)
        {
            Nodo temp, actual = new Nodo();
            if (nodoFinal == null)
            {
                Console.WriteLine("Mensaje: La lista se encuentra vacía.");
                return;
            }
            actual = nodoFinal.next;
            do
            {
                actual = actual.next;
            } while (actual.next.dato.id != referencia.id);
            temp = actual.next;
            actual.next = actual.next.next;
            temp = null;
            Console.WriteLine(" Se eliminó al jugador " + referencia.nombre);
        }
    }
}
