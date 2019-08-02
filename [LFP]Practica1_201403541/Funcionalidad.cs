using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LFP_Practica1_201403541
{
    class Funcionalidad
    {
        public string nombre, descripcion;
        public int año, mes, dia;

        Boolean insertar = false, insertar1 = false, sinsertar = false;

        public void ObtenerDatos(List<Listas.Lista> listas)
        {
            foreach (var item in listas)
            {
                String temp = item.lexema.Trim();

                if (temp.Equals("Planificador"))
                {
                    sinsertar = true;
                }
                if (sinsertar)
                {
                    if (item.tkn.Equals("Cadena"))
                    {
                        insertar = true;
                        sinsertar = false;
                    }
                }
                if (insertar)
                {
                    nombre = item.lexema;
                    insertar = false;
                }
            }
        }

    }
}
