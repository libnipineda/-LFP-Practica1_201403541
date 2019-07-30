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
            for (int i = 0; i < tabControl1.TabCount; i++)
            {

            }
        }
    }
}