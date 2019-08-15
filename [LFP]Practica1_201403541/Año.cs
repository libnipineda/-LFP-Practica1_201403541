using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LFP_Practica1_201403541
{
    class Año
    {
        private int mes;
        private List<Mes> ListaMeses;

        public Año(int mes)
        {
            this.Mes = mes;
            ListaMese1 = new List<Mes>();
        }

        public int Mes { get => mes; set => mes = value; }
        internal List<Mes> ListaMese1 { get => ListaMeses; set => ListaMeses = value; }

    }
}
