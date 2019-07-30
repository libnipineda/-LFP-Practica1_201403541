using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LFP_Practica1_201403541.Reportes
{
    class Html
    {
        string tabla = "";
        string Etabla = "";

        public void ReporteToken(List<Listas.Lista> datos)
        {
            if (datos.Count !=0)
            {
                for (int i = 0; i < datos.Count; i++)
                {
                    tabla = tabla + "<tr>"
                      + "<td><strong>" + datos[i].numero + "</strong></td>"
                      + "<td><strong>" + datos[i].lexema + "</strong></td>"
                      + "<td><strong>" + datos[i].idtkn + "</strong></td>"
                      + "<td><strong>" + datos[i].tkn + "</strong></td>"                 
                      + "</tr>";
                }
            }

            string[] texto = { "<html>"
                    ,"<head>"
                ,"<title>TABLA DE TOKEN´S</title>"
                ,"</head>"
                ,"<body>"
                ,"<h1> LFP PRACTICA NO.1 Listado de Tokens</h1>"
                ,"<table border>"
                ,"<tr>"
                ,"<td><strong>No</strong></td>"
                ,"<td><strong>Lexema</strong></td>"
                ,"<td><strong>ID_Token</strong></td>"
                ,"<td><strong>Token</strong></td>"
                ,"</tr>"
                ,tabla
                ,"</table>"
                ,"</body>"
                ,"</html> "
                };
            System.IO.File.WriteAllLines(@"C:\Users\libni\OneDrive\Escritorio\ReporteToken.html", texto);
        }        


        public void ReporteEtoken(List<Listas.Elista> datos)
        {
            if (datos.Count !=0)
            {
                for (int i=0; i < datos.Count; i++)
                {
                    Etabla = Etabla + "<tr>"
                        + "<td><strong>" + datos[i].num + "</strong></td>"
                        + "<td><strong>" + datos[i].fil + "</strong></td>"
                        + "<td><strong>" + datos[i].col + "</strong></td>"
                        + "<td><strong>" + datos[i].lex + "</strong></td>"
                        + "<td><strong>" + datos[i].Etkn + "</strong></td>"
                        + "</tr>";
                }
            }

            string[] text = { "<html>"
                ,"<head>"
                ,"<title>TABLA DE ERRORES</title>"
                ,"</head>"
                ,"<body>"
                ,"<h1> LFP PRACTICA NO.1 Listado de Errores</h1>"
                ,"<table>"
                ,"<tr>"
                ,"<td><strong>No</strong></td>"
                ,"<td><strong>Fila</strong></td>"
                ,"<td><strong>Columna</strong></td>"
                ,"<td><strong>Caracter</strong></td>"                                
                ,"<td><strong>Descripcion</strong></td>"
                ,"</tr>"
                ,Etabla
                ,"</table>"
                ,"</body>"
                ,"</html> " };
            System.IO.File.WriteAllLines(@"C:\Users\Aarón\Desktop\ReporteErroresTokens.html", text);
        }
    }
}