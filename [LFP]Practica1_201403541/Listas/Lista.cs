using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LFP_Practica1_201403541.Listas
{
    class Lista
    {
        public int numero = 0;
        public string lexema = "";
        public int idtkn = 0;
        public string tkn = "";
        public int fila = 0;
        public int columna = 0;
        

        public int getNumero()
        {
            return numero;
        }

        public string getLexema()
        {
            return lexema;
        }
    }


    class Elista
    {
        public int num = 0;
        public int fil = 0;
        public int col = 0;
        public string lex = "";
        public string Etkn = "";
    }
}