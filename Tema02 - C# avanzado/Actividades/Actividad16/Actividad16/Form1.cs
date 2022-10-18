namespace Actividad16
{
    public partial class Form1 : Form
    {
        public string totalOperaciones = "";
        public double resultadoFinal;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumero0_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "0";
        }

        private void btnNumero1_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "1";
        }

        private void btnNumero2_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "2";
        }

        private void btnNumero3_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "3";
        }

        private void btnNumero4_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "4";
        }

        private void btnNumero5_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "5";
        }

        private void btnNumero6_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "6";
        }

        private void btnNumero7_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "7";
        }

        private void btnNumero8_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "8";
        }

        private void btnNumero9_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "9";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
            txtTodasOperaciones.Clear();
            resultadoFinal = 0;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            double numero;
            numero = double.Parse(txtPantalla.Text);
            if (txtTodasOperaciones.Text != "")
            {
                
            }
            txtTodasOperaciones.Text = txtPantalla.Text + " + ";
            txtPantalla.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "-" + txtPantalla.Text;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += ',';
        }

        private void btnValorAbsoluto_Click(object sender, EventArgs e)
        {
            double numero;
            numero = double.Parse(txtPantalla.Text);
            resultadoFinal = Math.Abs(numero);
            txtPantalla.Text = "Abs(" + txtPantalla.Text + ")";
        }

        private void btnRaizCuadrada_Click(object sender, EventArgs e)
        {
            double numero;
            numero = double.Parse(txtPantalla.Text);
            resultadoFinal = Math.Sqrt(numero);
            txtPantalla.Text = "√(" + txtPantalla.Text + ")";
        }

        private void btnExponente_Click(object sender, EventArgs e)
        {
            double numero;
            numero = double.Parse(txtPantalla.Text);
            resultadoFinal = Math.Pow(numero,2);
            txtPantalla.Text = txtPantalla.Text + "^2";
        }

        private void btnRedondeo_Click(object sender, EventArgs e)
        {
            double numero;
            numero = double.Parse(txtPantalla.Text);
            resultadoFinal = Math.Round(numero);
            txtPantalla.Text = "Round(" + txtPantalla.Text + ")";
        }

        private void btnResultadoFinal_Click(object sender, EventArgs e)
        {

            txtTodasOperaciones.Text = txtPantalla.Text + " = ";
            txtPantalla.Text = resultadoFinal.ToString();
        }
    }
}