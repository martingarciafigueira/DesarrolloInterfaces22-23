using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            double dineroIntroducido, dineroCambio, precioProducto;
            string productoSeleccionado, nombreProducto;
            bool flag;
            int numeroMonedas2Euros, numeroMonedas1Euro, numeroMonedas50cts, numeroMonedas20cts, numeroMonedas10cts, numeroMonedas5cts;
            int centimosCambio;

            flag = double.TryParse(txtDineroIntroducido.Text, out dineroIntroducido);

            if (flag)
            {
                if (lstProductos.SelectedItem != null)
                {
                    productoSeleccionado = lstProductos.SelectedItem.ToString();

                    if (productoSeleccionado.Split('|').Length >= 2)
                    {
                        nombreProducto = productoSeleccionado.Split('|')[0];
                        flag = double.TryParse(productoSeleccionado.Split('|')[1], out precioProducto);

                        if (flag)
                        {
                            if (dineroIntroducido >= precioProducto)
                            {
                                dineroCambio = dineroIntroducido - precioProducto;
                                txtCambio.Text = dineroCambio.ToString();

                                centimosCambio = (int)(dineroCambio * 100);

                                //Aquí empezamos a calcular la devolución del importe

                                numeroMonedas2Euros = centimosCambio / 200;
                                centimosCambio = centimosCambio - numeroMonedas2Euros * 200;

                                numeroMonedas1Euro = centimosCambio / 100;
                                centimosCambio = centimosCambio - numeroMonedas1Euro * 100;

                                numeroMonedas50cts = centimosCambio / 50;
                                centimosCambio = centimosCambio - numeroMonedas50cts * 50;

                                numeroMonedas20cts = centimosCambio / 20;
                                centimosCambio = centimosCambio - numeroMonedas20cts * 20;

                                numeroMonedas10cts = centimosCambio / 10;
                                centimosCambio = centimosCambio - numeroMonedas10cts * 10;

                                numeroMonedas5cts = centimosCambio / 5;
                                centimosCambio = centimosCambio - numeroMonedas5cts * 5;

                                lblResultadoOperacion.Text = "Monedas 2€: " + numeroMonedas2Euros + ", Monedas 1€: "
                                    + numeroMonedas1Euro + ", Monedas 50cts: " + numeroMonedas50cts + ", Monedas 20cts: "
                                    + numeroMonedas20cts + ", Monedas 10cts: " + numeroMonedas10cts + "Monedas 5cts: " + numeroMonedas5cts;

                            }
                            else
                            {
                                lblResultadoOperacion.Text = "Falta dinero";
                            }
                        }
                        else
                        {
                            lblResultadoOperacion.Text = "Ha habido un error";
                        }
                    }
                }
            }
            else
            {
                lblResultadoOperacion.Text = "Ha habido un error";
            }
        }
    }
}
