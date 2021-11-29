using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jugador player1 = new Jugador("1", "Patrick", 1000);
            Jugador player2 = new Jugador("2", "Victor", 1900);
            Jugador player3 = new Jugador("3", "Miriam", 1100);
            Jugador player4 = new Jugador("4", "Manuel", 1800);
            Jugador player5 = new Jugador("5", "Pamela", 1300);
            Nodo nodoFinal = null;
            ListaEnlazada lista = new ListaEnlazada();
            Console.WriteLine("********** LISTA DE JUGADORES **********");
            nodoFinal = lista.GenerarListaInicial(nodoFinal, player1);
            nodoFinal = lista.GenerarListaInicial(nodoFinal, player2);
            nodoFinal = lista.GenerarListaInicial(nodoFinal, player3);
            nodoFinal = lista.GenerarListaInicial(nodoFinal, player4);
            nodoFinal = lista.GenerarListaInicial(nodoFinal, player5);
            lista.MostrarLista(nodoFinal);

            Console.WriteLine("********** AGREGANDO JUGADOR AL FINAL **********");
            Jugador player6 = new Jugador("6", "Diego", 1750);
            nodoFinal = lista.AgregarJugadorAlFinal(nodoFinal, player6);
            lista.MostrarLista(nodoFinal);

            Console.WriteLine("<********** ELIMINANDO JUGADORES POR REFERENCIA **********");
            lista.EliminarJugadorDespuesDe(nodoFinal, player5);
            lista.EliminarJugadorDespuesDe(nodoFinal, player1);
            lista.MostrarLista(nodoFinal);

            Console.ReadKey();
        }
    }
}
