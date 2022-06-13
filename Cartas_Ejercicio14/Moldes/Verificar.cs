using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartas_Ejercicio14.Moldes
{
    internal class Verificar
    {
        public static bool VerificarNumero(string opcion,  int max)
        {
            int cantCartas;
            if (Int32.TryParse(opcion, out cantCartas))
            {
                if (cantCartas == 0)
                {
                    Console.WriteLine("!!!Ingreso CERO cartas para ver¡¡¡¿?");
                    return false;
                }
                if (cantCartas < 0)
                {
                    Console.WriteLine("!Ingreso un número negativo no válido¡");
                    return false;
                }
                if (cantCartas > max)
                {
                    Console.WriteLine($"No hay suficientes cartas a repartir. Quedan {max} cartas en el mazo.");
                    return false;
                }
                return true;
            }
            else
            {
                Console.WriteLine("!No ingresó un dato numérico válido¡");
                return false;
            }
        }
    }
}