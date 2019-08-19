using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LFP_Practica1_201403541
{
    class Nuevo
    {
        private string nombre;
        private int año;
        private int mes;
        private int dia;

        public Nuevo(string nombre, int año, int mes, int dia)
        {
            this.Nombres = nombre;
            this.Año = año;
            this.Mes = mes;
            this.Dia = dia;            
        }

        public string Nombres { get => nombre; set => nombre = value; }
        public int Año { get => año; set => año = value; }
        public int Mes { get => mes; set => mes = value; }
        public int Dia { get => dia; set => dia = value; }
    }
}