using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartasEjercicio14.Moldes
{
    internal class Naipe
    {
        private string _palo = "";
        private int _numero;

        public Naipe(string Palo, int Numero)
        {
            _palo = Palo;
            _numero = Numero;
        }

        public string Palo
        {
            get { return this._palo; }
        }

        public int Numero
        {
            get { return this._numero; }
        }

    }

}