using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fechaNacimiento;
            TimeSpan diferencia;

            DateTime.TryParse(txtFechaNac.Text, out fechaNacimiento);

            diferencia = DateTime.Now - fechaNacimiento;

            MessageBox.Show(diferencia.ToString(@"dd\.hh\:mm\:ss"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int segundos;
            int.TryParse(textBox1.Text, out segundos);

            TimeSpan enSegundos = new TimeSpan(0, 0, segundos);

            MessageBox.Show(enSegundos.ToString());
        }
    }
}
