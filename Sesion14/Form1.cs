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

namespace Sesion14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream archivo = new FileStream("datos.dat", FileMode.Append, FileAccess.Write))
                using (BinaryWriter escritor = new BinaryWriter(archivo))
                {
                    string nombre = tbName.Text;
                    int edad = int.Parse(tbAge.Text);
                    int nota = int.Parse(tbGrade.Text);
                    char genero = char.Parse(tbGender.Text);

                    escritor.Write(nombre.Length); 
                    escritor.Write(nombre.ToCharArray());
                    escritor.Write(edad); 
                    escritor.Write(nota); 
                    escritor.Write(genero); 
                }
                MessageBox.Show("Datos guardados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

       
        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream archivo = new FileStream("datos.dat", FileMode.Open, FileAccess.Read))
                using (BinaryReader lector = new BinaryReader(archivo))
                {
                    lbResults.Items.Clear();

                    while (archivo.Position != archivo.Length)
                    {
                        int longitudNombre = lector.ReadInt32(); 
                        char[] nombreArray = lector.ReadChars(longitudNombre);
                        string nombre = new string(nombreArray); 
                        int edad = lector.ReadInt32(); 
                        int nota = lector.ReadInt32(); 
                        char genero = lector.ReadChar(); 

                        lbResults.Items.Add($"Nombre: {nombre}, Edad: {edad}, Nota: {nota}, Género: {genero}");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}




