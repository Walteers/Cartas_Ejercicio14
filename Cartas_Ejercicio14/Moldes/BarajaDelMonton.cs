using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartasEjercicio14.Moldes
{
    internal class BarajaDelMonton : BarajaBase
    {
        private List<Naipe> _barajasDelMonton = new List<Naipe>();

        public List<Naipe> BarajasDelMonton {
            get { return _barajasDelMonton; }
            set { _barajasDelMonton = value; }
        }


        public void CartasMonton()
        {
            if (BarajasDelMonton.Count == 0) Console.WriteLine("No hay cartas en el montón. No a salido ninguna carta de la baraja.");
            else
            {
                CartasDisponibles(BarajasDelMonton);
                foreach (Naipe carta in BarajasDelMonton) Console.WriteLine($"{carta.Numero} de {carta.Palo}");
            }
        }

        new public void CartasDisponibles(List<Naipe> BarajaDeCartas)
        {
            Console.WriteLine($"Hay {base.CartasDisponibles(BarajaDeCartas)} cartas en el montón.");
        }

    }
}
