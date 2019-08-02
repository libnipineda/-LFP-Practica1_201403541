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

        public Lista(int numero, string lexema, int idtkn, string tkn, int fila, int columna)
        {
            this.numero = numero;
            this.lexema = lexema;
            this.idtkn = idtkn;
            this.tkn = tkn;
            this.fila = fila;
            this.columna = columna;
        }

        public int getNumero()
        {
            return this.numero;
        }

        public string getLexema()
        {
            return this.lexema;
        }

        public int getidtkn()
        {
            return this.idtkn;
        }

        public string gettkn()
        {
            return this.tkn;
        }

        public int getfila()
        {
            return this.fila;
        }

        public int getcolumna()
        {
            return this.columna;
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