using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartasEjercicio14.Moldes
{
    internal class Baraja : BarajaBase
    {
        private int[] Numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 10, 11, 12 };
        private string[] Palos = new string[] { "Espada", "Oro", "Basto", "Copa" };
        private List<Naipe> _barajaDeCartas = new List<Naipe>();
        private BarajaDelMonton _cartasDelMonton;

        public List<Naipe> BarajaDeCartas
        {
            get { return _barajaDeCartas; }
            set { _barajaDeCartas = value; }
        }

        public BarajaDelMonton CartasDelMonton
        {
            get { return _cartasDelMonton; }
            set { _cartasDelMonton = value; }
        }


        public Baraja() // Al instanciar una variable de la clase Baraja, se inicializa una List de tipo Naipe con las 40 cartas de la baraja
        {
            for (int i = 0; i < Palos.Length; i++)
            {
                for (int j = 0; j < Numeros.Length; j++)
                {
                    Naipe Carta = new Naipe(Palos[i], Numeros[j]);
                    BarajaDeCartas.Add(Carta);
                }
            }
            CartasDelMonton = new BarajaDelMonton();
        }


        public void SiguienteCarta() // Si quedan cartas en la baraja, se muestra por consola la última carta, se la guarda el la List de cartas del montón y se elimina
        {
            if (BarajaDeCartas.Count != 0) // Si no quedan cartas se le indica al usuario
            {
                Console.WriteLine($"{BarajaDeCartas[BarajaDeCartas.Count - 1].Numero} de {BarajaDeCartas[BarajaDeCartas.Count - 1].Palo} "); // Mostramos por consola la ultima carta
                CartasDelMonton.BarajasDelMonton.Add(BarajaDeCartas[BarajaDeCartas.Count - 1]); // Guardamos la carta a las 'BarajasDelMonton'
                BarajaDeCartas.RemoveAt(BarajaDeCartas.Count - 1); // Elimiamos la ultima carta
            }
            else Console.WriteLine("Ya no quedan mas cartas en la baraja.");
        }


        public void DarCartas(int cantidad) // Si quedan cartas en la baraja, se muestran por consola la cantidad pedida por el usuario mediante el método SiguienteCarta()
        {
            if (BarajaDeCartas.Count == 0) // Si no quedan cartas se le indica al usuario
            {
                Console.WriteLine("No quedan cartas en el mazo.");
                return;
            }
            Console.WriteLine("Cartas repartidas: ");
            for (int i = 0; i < cantidad; i++) SiguienteCarta();
        }


        public void MostrarBaraja()
        {
            if (BarajaDeCartas.Count == 0) Console.WriteLine("No quedan cartas en la baraja."); // Si no quedan cartas se le indica al usuario
            else
            {
                Console.WriteLine("Cartas de la baraja");
                foreach (Naipe naipe in BarajaDeCartas) Console.WriteLine($"{naipe.Numero} de {naipe.Palo}");
            }
        }


        new public void CartasDisponibles(List<Naipe> BarajaDeCartas)
        {
            Console.WriteLine($"Quedan {base.CartasDisponibles(BarajaDeCartas)} cartas disponibles en el mazo."); 
        }

    }
}
