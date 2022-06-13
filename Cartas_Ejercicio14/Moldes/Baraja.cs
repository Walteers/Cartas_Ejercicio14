using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartas_Ejercicio14.Moldes
{
    internal class Baraja
    {
        private int[] Numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 10, 11, 12 };
        private string[] Palos = new string[] { "Espada", "Oro", "Basto", "Copa" };
        private List<Naipe> _barajaDeCartas = new List<Naipe>();
        private List<Naipe> _barajasDelMonton = new List<Naipe>();

        public List<Naipe> BarajaDeCartas
        {
            get { return _barajaDeCartas; }
            set { _barajaDeCartas = BarajaDeCartas; }
        }

        public List<Naipe> BarajasDelMonton
        {
            get { return _barajasDelMonton; }
            set { _barajasDelMonton = BarajasDelMonton; }
        }


        public Baraja()
        {
            for (int i = 0; i < Palos.Length; i++)
            {
                for (int j = 0; j < Numeros.Length; j++)
                {
                    Naipe Carta = new Naipe(Palos[i], Numeros[j]);
                    BarajaDeCartas.Add(Carta);
                }
            }
        }


        public void Barajar()
        {
            if (BarajaDeCartas.Count > 1)
            {
                Random numRandom = new Random();
                int numeroRandom = numRandom.Next(500, 1500); // Se elije aleatoriamente la cantidad de veces que se abaraja o se cambia una carta de posicion
                int indice;
                Naipe AuxNaipe;
                // Elejimos una carta al azar, la copiamos a una variable auxiliar, eliminamos la posicion e insertamos aleatoriamente la varible auxiliar en otra posición
                for (int i = 0; i < numeroRandom; i++)
                {
                    indice = numRandom.Next(0, BarajaDeCartas.Count);
                    AuxNaipe = BarajaDeCartas[indice];
                    BarajaDeCartas.RemoveAt(indice);
                    BarajaDeCartas.Insert(numRandom.Next(0, BarajaDeCartas.Count), AuxNaipe);
                }
                Console.WriteLine("Baraja mezclada.");
            }
            if (BarajaDeCartas.Count == 1) Console.WriteLine("Solo hay una sola carta en la baraja.");
            if (BarajaDeCartas.Count < 1) Console.WriteLine("No quedan cartas en la baraja.");
        }


        public void SiguienteCarta()
        {
            if (BarajaDeCartas.Count != 0)
            {
                Console.WriteLine($"{BarajaDeCartas[BarajaDeCartas.Count - 1].Numero} de {BarajaDeCartas[BarajaDeCartas.Count - 1].Palo} "); // Mostramos por consola la ultima carta
                BarajasDelMonton.Add(BarajaDeCartas[BarajaDeCartas.Count - 1]); // Guardamos la carta a las 'BarajasDelMonton'
                BarajaDeCartas.RemoveAt(BarajaDeCartas.Count - 1); // Elimiamos la ultima carta
            }
            else Console.WriteLine("Ya no quedan mas cartas en la baraja.");
        }


        public void CartasDisponibles()
        {
            Console.WriteLine($"Quedan para repartir {BarajaDeCartas.Count} cartas en la baraja.");
        }


        public void DarCartas(int cantidad)
        {
            if (cantidad > BarajaDeCartas.Count) Console.WriteLine("No hay suficientes cartas para repartir.");
            else
            {
                Console.WriteLine("Cartas repartidas: ");
                for (int i = 0; i < cantidad; i++) SiguienteCarta();
            }
        }


        public void CartasMonton()
        {
            if (BarajasDelMonton.Count == 0) Console.WriteLine("No hay cartas en el montón. No a salido ninguna carta de la baraja.");
            else
            {
                Console.WriteLine("Cartas del montón");
                foreach (Naipe carta in BarajasDelMonton) Console.WriteLine($"{carta.Numero} de {carta.Palo}");
            }
        }


        public void MostrarBaraja()
        {
            Console.WriteLine("Cartas de la baraja");
            foreach (Naipe naipe in BarajaDeCartas) Console.WriteLine($"{naipe.Numero} de {naipe.Palo}");
        }

    }

}