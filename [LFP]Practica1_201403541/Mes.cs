using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LFP_Practica1_201403541
{
    class Mes
    {
        private int dia;
        private List<Dia> ListaDias;

        public Mes(int dia)
        {
            this.Dia = dia;
            ListaDias1 = new List<Dia>();
        }

        public int Dia { get => dia; set => dia = value; }
        internal List<Dia> ListaDias1 { get => ListaDias; set => ListaDias = value; }
    }
}
