using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnd_Click(object sender, EventArgs e)
        {
            bool resultado;
            resultado = (textBox1 != null && textBox1.Text == textBox2.Text);

            lblResultado.Text = resultado.ToString();

        }

        private void btnOr_Click(object sender, EventArgs e)
        {
            bool resultado;
            resultado = (textBox1 != null || textBox1.Text == textBox2.Text);

            lblResultado.Text = resultado.ToString();
        }

        private void btnXOR_Click(object sender, EventArgs e)
        {
            bool resultado;
            resultado = (textBox1 != null ^ textBox1.Text == textBox2.Text);

            lblResultado.Text = resultado.ToString();
        }
    }
}
