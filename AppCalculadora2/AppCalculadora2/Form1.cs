using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculadora2
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            float numero1, numero2, sumar;
            numero1 = float.Parse(txtNumero1.Text);
            numero2 = float.Parse(txtNumero2.Text);
            sumar = numero1 + numero2;
            txtResultado.Text = sumar.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            txtResultado.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            float numero1, numero2, potencia=1;
            numero1 = float.Parse(txtNumero1.Text);
            numero2 = float.Parse(txtNumero2.Text);
            for(int contador = 1; contador <= numero2; contador++) 
            {
                potencia = potencia * numero1;
            }
            //txtResultado.Text = potencia.ToString();
            MessageBox.Show(potencia.ToString(), "Resultado");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numero1, factorial=1, acumulador=1;
            numero1 = int.Parse(txtNumero1.Text);
            
            while (numero1 != 0) 
            {
                factorial = factorial * numero1;
                numero1--;

            }
            /*
            for(numero1=0; factorial<=numero1; numero1--)
            {
                factorial = factorial * numero1;
            }
            */
            txtResultado.Text = factorial.ToString();
        }
    }
}
