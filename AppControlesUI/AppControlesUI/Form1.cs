using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppControlesUI
{
    public partial class FrmControles : Form
    {
        public FrmControles()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string nombre, biografia="";
            string navegador="";
            nombre = txtNombre.Text;
            biografia = rtbBiografia.Text;
            if (chkGoogle.Checked==true) 
            {
                navegador = navegador+chkGoogle.Text+" ";
            }
            if (chkOpera.Checked==true)
            {
                navegador = navegador+chkOpera.Text+" ";
            }
            if (chkMicrosoft.Checked ==true)
            {
                navegador = navegador+chkMicrosoft.Text+" ";
            }
            MessageBox.Show(nombre+", "+navegador+biografia,"Su nombre es:");

        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (rd800.Checked == true) 
            {
                Width = 800;
                Height = 600;
            }
            else if (rd1024.Checked == true) 
            {
                Width = 1024;
                Height = 768;
            }
            else if (rd1280.Checked == true)
            {
                Width = 1280;
                Height = 720;
            }

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            int rojo, verde, azul;
            rojo = int.Parse(cmbRojo.Text);
            verde = int.Parse(cmbVerde.Text);
            azul = int.Parse(cmbAzul.Text);
            BackColor = Color.FromArgb(rojo,verde,azul);
        }

        private void FrmControles_Load(object sender, EventArgs e)
        {
            for (int conta = 0; conta <= 255; conta++)
            {
                cmbRojo.Items.Add(conta.ToString());
                cmbVerde.Items.Add(conta.ToString());
                cmbAzul.Items.Add(conta.ToString());
            }
            cmbRojo.SelectedIndex = 0;
            cmbVerde.SelectedIndex = 0;
            cmbAzul.SelectedIndex = 0;
        }

        private void btnMostrarFechaNac_Click(object sender, EventArgs e)
        {
            DateTime fechaNac;
            fechaNac = dtpFechaNac.Value;
            MessageBox.Show(fechaNac.ToString(), "La fecha de Nacimiento:");
        }
    }
}
