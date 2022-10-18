namespace EjemploCompleto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has hecho click en mi botón", "Clicaste!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Como te atreves a pasar por encima de mi boton");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("El valor actual es: " + checkBox1.Checked);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Clicaste en el LinkLabel");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("El indice seleccionado es el: " + listBox1.SelectedIndex);
            MessageBox.Show("Es decir, selecciono a: " + listBox1.SelectedItem);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }
    }
}