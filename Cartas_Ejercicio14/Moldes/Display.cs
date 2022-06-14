using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartasEjercicio14.Moldes
{
    internal class Display
    {
        public static void MostrarContinuar()
        {
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

    }
}