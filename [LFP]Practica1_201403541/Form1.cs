using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _LFP_Practica1_201403541
{
    public partial class Form1 : Form
    {
        int a = 2; // Genera las pestañas
        

        public Form1()
        {
            InitializeComponent();
        }

        private void nuevaPestañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage pagina = new TabPage(); // Crea la pestaña
            RichTextBox rich = new RichTextBox(); // Crea la superficie donde se ingresan los datos
            rich.Width = 452;
            rich.Height = 524;
            rich.Name = "Pestaña " + a.ToString(); //Carga el nombre del archivo en la pestaña
            rich.Location = new Point(-4, 0);
            pagina.Name = "Pestaña " + a.ToString();
            pagina.Text = "Pestaña " + a.ToString();
            pagina.Controls.Add(rich);
            this.tabControl1.TabPages.Add(pagina); // agrega la pestaña
            this.tabControl1.SelectedTab = pagina; // agrega la superficie donde se ingresan los datos
            a++; //Contador para generar pestañas
        }

        private void cargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            RichTextBox archivos = (RichTextBox)tabControl1.SelectedTab.Controls[0];
            abrir.Filter = "Documento | *.ly";
            abrir.Title = "Abrir Documento";
            abrir.FileName = "Sin titulo";
            var dato = abrir.ShowDialog();
            if (dato == DialogResult.OK)
            {
                StreamReader leer = new StreamReader(abrir.FileName);
                archivos.Text = leer.ReadToEnd();
                leer.Close();
                tabControl1.SelectedTab.Text = abrir.SafeFileName;
            }
        }

        private void guardarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox archivo = (RichTextBox)tabControl1.SelectedTab.Controls[0];
            if (MessageBox.Show("Desea Guardar los cambios", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.Filter = "Documento|*.ly";
                guardar.Title = "Guardar Archivo";
                guardar.FileName = "Sin Titulo";
                var dato = guardar.ShowDialog();
                if (dato == DialogResult.OK)
                {
                    StreamWriter escribir = new StreamWriter(guardar.FileName);
                    foreach (Object line in archivo.Lines)
                    {
                        escribir.WriteLine(line);
                    }
                    escribir.Close();
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir de la aplicación", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void manualAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process aux = new System.Diagnostics.Process();
                aux.StartInfo.FileName = "E:\\Lenguajes\\Segundo_semestre\\[LFP]Practica1_201403541\\Manual de Usuario.pdf";
                aux.Start(); aux.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al encontrar manual de usuario","Información", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }                
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "LFP PRACTICA No.1\n Uzzi Libni Aarón Pineda Solórzano\n 201403541",
               "Acerca de...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pintar();
            Scanner valor = new Scanner();

            RichTextBox texto = (RichTextBox)tabControl1.SelectedTab.Controls[0];
            valor.Lexico(texto.Text);
            valor.Reporte1();
            //valor.Reporte2();
            
        }
        
        // Codigo para pintar las palbras        
        string valor; int indice;

        public void Pintar()
        {
          string comparar = richTextBox1.Text;

            valor = "Planificador";
            indice = richTextBox1.Text.IndexOf(valor);
            pintaReservadas(indice, comparar);

            valor = "Año";
            indice = richTextBox1.Text.IndexOf(valor);
            pintaReservadas(indice, comparar);


            valor = "Mes";
            indice = richTextBox1.Text.IndexOf(valor);
            pintaReservadas(indice, comparar);

            valor = "Dia";
            indice = richTextBox1.Text.IndexOf(valor);
            pintaReservadas(indice, comparar);

            valor = "Descripción";
            indice = richTextBox1.Text.IndexOf(valor);
            pintaReservadas(indice, comparar);

            valor = "Imagen";
            indice = richTextBox1.Text.IndexOf(valor);
            pintaReservadas(indice, comparar);


            valor = "0";
            indice = richTextBox1.Text.IndexOf(valor);
            pintaNumeros(indice, comparar);

            valor = "1";
            indice = richTextBox1.Text.IndexOf(valor);
            pintaNumeros(indice, comparar);

            valor = "2";
            indice = richTextBox1.Text.IndexOf(valor);
            pintaNumeros(indice, comparar);

            valor = "3";
            indice = richTextBox1.Text.IndexOf(valor);
            pintaNumeros(indice, comparar);

            valor = "4";
            indice = richTextBox1.Text.IndexOf(valor);
            pintaNumeros(indice, comparar);

            valor = "5";
            indice = richTextBox1.Text.IndexOf(valor);
            pintaNumeros(indice, comparar);

            valor = "6";
            indice = richTextBox1.Text.IndexOf(valor);
            pintaNumeros(indice, comparar);

            valor = "7";
            indice = richTextBox1.Text.IndexOf(valor);
            pintaNumeros(indice, comparar);

            valor = "8";
            indice = richTextBox1.Text.IndexOf(valor);
            pintaNumeros(indice, comparar);

            valor = "9";
            indice = richTextBox1.Text.IndexOf(valor);
            pintaNumeros(indice, comparar);            
        }

        public void pintaReservadas(int pintar, String comparar)
        {
            indice = pintar + valor.Length - 1;
            try
            {
                richTextBox1.Select(pintar, valor.Length);
                richTextBox1.SelectionColor = Color.Blue;
                richTextBox1.SelectionStart = richTextBox1.Text.Length;

                comparar = richTextBox1.Text.Substring(pintar + valor.Length);
                pintar = comparar.IndexOf(valor) + pintar + valor.Length;

                if (pintar != indice)
                {
                    pintaReservadas(pintar, comparar);
                }
                else
                {
                    indice = 0;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error en metodo pintaReservadas");                
            }
        }

        public void pintaNumeros(int pindice, String comparar)
        {
            try
            {
                indice = pindice + valor.Length - 1;

                richTextBox1.Select(pindice, valor.Length);
                richTextBox1.SelectionColor = Color.Purple;
                richTextBox1.SelectionStart = richTextBox1.Text.Length;

                comparar = richTextBox1.Text.Substring(pindice + valor.Length);
                pindice = comparar.IndexOf(valor) + pindice + valor.Length;

                if (pindice != indice)
                {
                    pintaNumeros(pindice,comparar);
                }
                else
                {
                    indice = 0;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error en metodo pintaNumeros");                
            }
        }

        public void pintaCadena(int pindice, String comparar)
        {
            try
            {
                indice = pindice + valor.Length - 1;

                richTextBox1.Select(pindice, valor.Length);
                richTextBox1.SelectionColor = Color.Orange;
                richTextBox1.SelectionStart = richTextBox1.Text.Length;

                comparar = richTextBox1.Text.Substring(pindice + valor.Length);
                pindice = comparar.IndexOf(valor) + pindice + valor.Length;

                if (pindice != indice)
                {
                    pintaCadena(pindice, comparar);
                }
                else
                {
                    indice = 0;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error en metodo pintaCadena");
            }
        }

        // Treeview        
        String hola; int year, month, day;
        public void AgregarDatos(String dato,int año, int mes, int dia)
        {
            hola = dato;
            year = año;
            month = mes;
            day = dia;
            Console.WriteLine("Form1 metodo agregar datos nombre: " + hola + " año: " + year + " mes: "+ month + " dia: "+day);
        }

        public void NodoNombre()
        {
            TreeNode nodo = new TreeNode();
            nodo.Text = hola;
            treeView1.Nodes.Add(nodo);
            treeView1.Nodes.Add(Convert.ToString(year));
        }
    }    
}