using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarCaracteres_Click(object sender, EventArgs e)
        {
            string cadena;
            cadena = txtCadena.Text;

            MessageBox.Show("El número de caracteres es: " + cadena.Length);
        }

        private void btnMostrarNCaracteres_Click(object sender, EventArgs e)
        {
            string cadena;
            int caracteres;
            cadena = txtCadena.Text;
            int.TryParse(txtNElementos.Text, out caracteres);

            MessageBox.Show("Los primeros " + caracteres + " caracteres son: " + cadena.Substring(0, caracteres));
        }

        private void btnReemplazar_Click(object sender, EventArgs e)
        {
            string cadena, busqueda, reemplazo;

            cadena = txtCadena.Text;
            busqueda = txtBuscar.Text;
            reemplazo = txtReemplazar.Text;

            MessageBox.Show("La cadena resultado es: " + cadena.Replace(busqueda, reemplazo));
        }

        private void btnCompararCadenas_Click(object sender, EventArgs e)
        {
            string cadena1, cadena2;
            int comparacion;

            cadena1 = txtCadena.Text;
            cadena2 = txtCadena2.Text;

            comparacion = cadena1.CompareTo(cadena2);

            switch (comparacion)
            {
                case -1:
                {
                    MessageBox.Show(cadena1 + " es menor que" + cadena2);
                    break;                 
                }
                case 0:
                {
                    MessageBox.Show(cadena1 + " es igual que" + cadena2);
                    break;
                }
                case 1:
                {
                    MessageBox.Show(cadena1 + " es mayor que" + cadena2);
                    break;
                }
            }

            //MessageBox.Show("La cadena resultado es: " + cadena.Replace(busqueda, reemplazo));
        }
    }
}
