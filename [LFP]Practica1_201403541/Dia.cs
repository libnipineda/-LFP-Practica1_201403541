using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LFP_Practica1_201403541
{
    class Dia
    {
        private string datos;
        private List<Descripcion> ListaDescripcion;

        public Dia(int datos)
        {
            this.Datos = datos;
            ListaDescripcion1 = new List<Descripcion>();
        }

        public string Datos { get => datos; set => datos = value; }
        internal List<Descripcion> ListaDescripcion1 { get => ListaDescripcion; set => ListaDescripcion = value; }
    }
}