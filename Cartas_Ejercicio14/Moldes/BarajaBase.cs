using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartasEjercicio14.Moldes
{
    internal class BarajaBase
    {      
        public void Barajar(List<Naipe> BarajaDeCartas)
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

           
        public int CartasDisponibles(List<Naipe> BarajaDeCartas)
        {     
            return BarajaDeCartas.Count;
        }        

    }
}
