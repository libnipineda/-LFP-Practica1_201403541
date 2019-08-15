using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LFP_Practica1_201403541
{
    class Nombre
    {
        private int año;
        private List<Año> ListaAño;

        public Nombre(int año)
        {
            this.Año = año;
            ListaAño1 = new List<Año>();
        }

        public int Año { get => año; set => año = value; }
        internal List<Año> ListaAño1 { get => ListaAño; set => ListaAño = value; }
    }
}
