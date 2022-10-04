using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad5
{
    public partial class Form1 : Form
    {
        ArrayList lista = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numeroIngresado;
            double.TryParse(textBox1.Text, out numeroIngresado);
            double sumatotal = 0, promedio;

            if (lista.Count < 5)
            {
                lista.Add(numeroIngresado);
            }
            else
            {
                foreach (double item in lista)
                {
                    sumatotal += item;
                }
                promedio = sumatotal / lista.Count;
                lblResultado.Text = promedio.ToString();
            }

        }
    }
}
