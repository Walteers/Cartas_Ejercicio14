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
        private Naipe[] _barajaDeCartas = new Naipe[40];
        private Naipe[] _barajasDelMonton = new Naipe[40];

        public Naipe[] BarajaDeCartas
        {
            get { return _barajaDeCartas; }
            set { _barajaDeCartas = BarajaDeCartas; }
        }

        public Naipe[] BarajaDelMonton
        {
            get { return _barajaDeCartas; }
            set { _barajaDeCartas = BarajaDeCartas; }
        }


        public Baraja()
        {
            int pos = 0;
            for (int i = 0; i < Palos.Length; i++)
            {
                for (int j = 0; j < Numeros.Length; j++)
                {
                    Naipe Carta = new Naipe(Palos[i], Numeros[j]);
                    BarajaDeCartas[pos] = Carta;
                    pos++;
                }
            }
        }


        public void Barajar()
        {
            if (CartasDisponiblesEnBaraja(BarajaDeCartas) > 1)
            {
                Random numRandom = new Random();
                int numeroRandom = numRandom.Next(500, 1500); // Se elije aleatoriamente la cantidad de veces que se abaraja o se cambia una carta de posicion
                int indice;
                Naipe AuxNaipe;
                for (int i = 0; i < numeroRandom; i++)
                {
                    indice = numRandom.Next(0, CartasDisponiblesEnBaraja(BarajaDeCartas)); // Elejimos al azar una carta de la baraja que no sea la ultima, y la intercambiamos con la ultima carta de la baraja
                    AuxNaipe = BarajaDeCartas[indice]; // Copiamos la carta elejida
                    BarajaDeCartas[indice] = BarajaDeCartas[CartasDisponiblesEnBaraja(BarajaDeCartas) - 1]; // Pasamos la ultima carta a la posicion elejida aleatoreamente
                    BarajaDeCartas[CartasDisponiblesEnBaraja(BarajaDeCartas) - 1] = AuxNaipe; // Pegamos a la ultima posicion la carta elejida aleatoreamente
                }
                Console.WriteLine("Baraja mezclada.");
            }
            if (CartasDisponiblesEnBaraja(BarajaDeCartas) == 1) Console.WriteLine("Solo hay una sola carta en la baraja.");
            if (CartasDisponiblesEnBaraja(BarajaDeCartas) < 1) Console.WriteLine("No quedan cartas en la baraja.");
        }


        public void SiguienteCarta()
        {
            if (CartasDisponiblesEnBaraja(BarajaDeCartas) != 0)
            {
                Console.WriteLine($"{BarajaDeCartas[CartasDisponiblesEnBaraja(BarajaDeCartas) - 1].Numero} de {BarajaDeCartas[CartasDisponiblesEnBaraja(BarajaDeCartas) - 1].Palo} "); // Mostramos por consola la ultima carta

                _barajasDelMonton[CartasDisponiblesEnBaraja(_barajasDelMonton)] = BarajaDeCartas[CartasDisponiblesEnBaraja(BarajaDeCartas) - 1]; // Guardamos la última carta a las cartas 'BarajasDelMonton'

                BarajaDeCartas[CartasDisponiblesEnBaraja(BarajaDeCartas) - 1] = null; // Elimiamos la ultima carta
            }
            else Console.WriteLine("Ya no quedan mas cartas en la baraja.");
        }


        public void CartasDisponibles()
        {
            Console.WriteLine($"Quedan para repartir {CartasDisponiblesEnBaraja(BarajaDeCartas)} cartas en la baraja.");
        }


        public void DarCartas(int cantidad)
        {
            if (cantidad > CartasDisponiblesEnBaraja(BarajaDeCartas)) Console.WriteLine("No hay suficientes cartas para repartir.");
            else
            {
                Console.WriteLine("Cartas repartidas: ");
                for (int i = 0; i < cantidad; i++) SiguienteCarta();
            }
        }


        public void CartasMonton()
        {
            if (CartasDisponiblesEnBaraja(_barajasDelMonton) == 0) Console.WriteLine("No hay cartas en el montón. No a salido ninguna carta de la baraja.");
            else
            {
                Console.WriteLine("Cartas del montón");
                for (int i = 0; i < CartasDisponiblesEnBaraja(_barajasDelMonton); i++) Console.WriteLine($"{_barajasDelMonton[i].Numero} de {_barajasDelMonton[i].Palo}");
            }
        }


        public void MostrarBaraja()
        {
            if (CartasDisponiblesEnBaraja(BarajaDeCartas) == 0) Console.WriteLine("No quedan cartas en la baraja.");
            else
            {
                Console.WriteLine("Cartas de la baraja:");
                for (int i = 0; i < CartasDisponiblesEnBaraja(BarajaDeCartas); i++) Console.WriteLine($"{BarajaDeCartas[i].Numero} de {BarajaDeCartas[i].Palo}");
            }
        }


        public int CartasDisponiblesEnBaraja(Naipe[] BarajaDeCartasVerificar)
        {
            int cont = 0;
            for (int i = 0; i < BarajaDeCartasVerificar.Length; i++)
            {
                if (BarajaDeCartasVerificar[i] != null) cont++;
                else break;
            }
            return cont;
        }
    }
}
