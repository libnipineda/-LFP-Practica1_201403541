using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _LFP_Practica1_201403541
{
    class Scanner
    {
        List<Listas.Lista> ListaA = new List<Listas.Lista>();
        List<Listas.Elista> ListaB = new List<Listas.Elista>();

        int idtkn;
        int nutknen = 0;
        int idtkns = 10; // numero de tokens
        int fila = 0; int columna = 0;
        string lexema = ""; string token = "";
        String concatenar = ""; String Etoken = "";


        public void Lexico(string cadena)
        {
            int estado = 0;            
            for (int i =0; i < cadena.Length; i++)
            {
                switch (estado)
                {
                    case 0:
                        if (((char)09).Equals(cadena[i]) | ((char)10).Equals(cadena[i]) | ((char)32).Equals(cadena[i])) // tecla tab, salto de linea , espacio
                        {
                            estado = 0; fila++; columna++;
                        }
                        else if (char.IsLetter(cadena[i]))
                        {
                            estado = 1; concatenar += cadena[i]; columna++;
                        }
                        else if (char.IsNumber(cadena[i]))
                        {
                            estado = 2; concatenar += cadena[i]; columna++;
                        }
                        else if (((char)58).Equals(cadena[i]) || ((char)123).Equals(cadena[i]) || ((char)125).Equals(cadena[i])) // signo dos puntos, llave A y llave C
                        {
                            estado = 3; concatenar += cadena[i]; columna++;
                        }
                        else if (((char)34).Equals(cadena[i])) // signo de comillas
                        {
                            estado = 4; concatenar += cadena[i]; columna++;
                        }
                        else
                        {
                            Etoken += cadena[i];
                            Listas.Elista aux = new Listas.Elista();
                            aux.num = nutknen;
                            aux.fil = fila;
                            aux.col = columna;
                            aux.lex = Etoken;
                            aux.Etkn = "Valor Desconocido";                            
                            ListaB.Add(aux); nutknen++; concatenar = ""; Etoken = "";
                        }
                        break;

                    case 1:
                        if (Char.IsLetter(cadena[i]))
                        {
                            estado = 1; concatenar += cadena[i]; columna++;
                        }
                        else
                        {
                            AnalizarTkn(concatenar); i--; estado = estado - 1; estado = 0;
                            AgregarListaA(nutknen,concatenar,idtkn,token,fila,columna);
                            nutknen++; concatenar = "";
                        }
                        break;

                    case 2:
                        if (Char.IsNumber(cadena[i]))
                        {
                            estado = 2; concatenar += cadena[i]; columna++;
                        }
                        else
                        {
                            AnalizarTkn(concatenar); i--; estado = estado - 1; estado = 0;
                            AgregarListaA(nutknen,concatenar,2,"Numero.",fila,columna);
                            nutknen++; concatenar = "";
                        }
                        break;

                    case 3:
                        AnalizarTkn(concatenar); i--; estado = estado - 1; estado = 0;
                        AgregarListaA(nutknen, concatenar, idtkn, token, fila, columna);
                        nutknen++; concatenar = "";
                        break;

                    case 4:
                        if (((char)34).Equals(cadena[i]))
                        {
                            estado = 6; concatenar += cadena[i]; columna++;
                        }
                        else
                        {
                            estado = 5; concatenar += cadena[i]; columna++;
                        }
                        break;

                    case 5:
                        if (((char)34).Equals(cadena[i]))
                        {
                            estado = 6; concatenar += cadena[i]; columna++;
                        }
                        else
                        {
                            estado = 5; concatenar += cadena[i]; columna++;
                        }
                        break;

                    case 6:
                        AnalizarTkn(concatenar); i--; estado = estado - 1; estado = 0;
                        AgregarListaA(nutknen, concatenar, idtkn, token, fila, columna);
                        nutknen++; concatenar = "";
                        break;
                }
            }
            MessageBox.Show("Analisis Concluido");
        }

        public void AnalizarTkn(string tkn)
        {
            tkn.Trim();
            switch (tkn)
            {
                case "Planificador":
                    token = "Palabra Reservada"; idtkn = 1;
                    break;

                case "Año":
                    token = "Palabra Reservada"; idtkn = 3;
                    break;

                case "Mes":
                    token = "Palabra Reservada"; idtkn = 4;
                    break;

                case "Dia":
                    token = "Palabra Reservada"; idtkn = 5;
                    break;

                case "Descripción":
                    token = "Palabra Reservada"; idtkn = 6;
                    break;

                case "Imagen":
                    token = "Palabra Reservada"; idtkn = 7;
                    break;

                case ":":
                    token = "Palabra Reservada"; idtkn = 8;
                    break;

                case "{":
                    token = "Palabra Reservada"; idtkn = 9;
                    break;

                case "}":
                    token = "Palabra Reservada"; idtkn = 10;
                    break;

                default:
                    token = "Cadena"; idtkns++; idtkn = idtkns; 
                    break;
            }
        }

        public void AgregarListaA(int num,string lexema, int idtkn, string tkn,int fila,int columna)
        {
            Listas.Lista aux = new Listas.Lista();
            aux.numero = num;
            aux.lexema = lexema;
            aux.idtkn = idtkn;
            aux.tkn = tkn;
            aux.fila = fila;
            aux.columna = columna;
            ListaA.Add(aux);            
        }

        public void Reporte1()
        {
            try
            {
                MessageBox.Show("Espere en un momento se abrira el reporte de token´s", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reportes.Html item = new Reportes.Html();
                item.ReporteToken(ListaA);
                Process.Start(@"C:\Users\libni\OneDrive\Escritorio\ReporteToken.html");
                
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo abrir el reporte de Token´s","Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                        
        }

        public void Reporte2()
        {
            try
            {
                MessageBox.Show("Espere en un momento se abrira el reporte de errores", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reportes.Html html = new Reportes.Html();
                html.ReporteEtoken(ListaB);
                Process.Start(@"C:\Users\libni\OneDrive\Escritorio\ReporteErrores.html");
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo abrir el reporte de errores o no hay errores", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }    
}