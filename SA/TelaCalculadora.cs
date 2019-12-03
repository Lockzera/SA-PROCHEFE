using SA.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA
{
    public partial class TelaCalculadora : Form
    {
        public static double resultado = 0;
        public static double anterior = 0;
        public TelaCalculadora()
        {
            InitializeComponent();
            btnVoltar.Click += voltar;
            btnSomar.Click += somar;
            btnMultiplicar.Click += multiplicar;
            btnDividir.Click += dividir;
            btnSubtrair.Click += subtrair;
            btnLimpar.Click += limpar;
        }

        private void limpar(object sender, EventArgs e)
        {
            resultado = 0;
            txtNumeroUm.Clear();
            txtNumeroDois.Clear();
            lblResultado.ResetText();
        }

        private void subtrair(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumeroUm.Text) || string.IsNullOrWhiteSpace(txtNumeroDois.Text))
            {
                MessageBox.Show("Digite os dois numeros");
            }
            else
            {
                anterior = resultado;
                resultado = Convert.ToDouble(txtNumeroUm.Text) - Convert.ToDouble(txtNumeroDois.Text) + anterior - resultado;
                lblResultado.Text = $"{resultado}";
                txtNumeroUm.Text = Convert.ToString(resultado);
                txtNumeroDois.Clear();
            }
        }

        private void dividir(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumeroUm.Text) || string.IsNullOrWhiteSpace(txtNumeroDois.Text))
            {
                MessageBox.Show("Digite os dois numeros");
            }
            else
            {
                anterior = resultado;
                resultado = (Convert.ToDouble(txtNumeroUm.Text) / Convert.ToDouble(txtNumeroDois.Text)) + anterior - resultado;
                lblResultado.Text = $"{resultado}";
                txtNumeroUm.Text = Convert.ToString(resultado);
                txtNumeroDois.Clear();
            }
        }

        private void multiplicar(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumeroUm.Text) || string.IsNullOrWhiteSpace(txtNumeroDois.Text))
            {
                MessageBox.Show("Digite os dois numeros");
            }
            else
            {
                anterior = resultado;
                resultado = (Convert.ToDouble(txtNumeroUm.Text) * Convert.ToDouble(txtNumeroDois.Text)) + anterior - resultado;
                lblResultado.Text = $"{resultado}";
                txtNumeroUm.Text = Convert.ToString(resultado);
                txtNumeroDois.Clear();
            }
        }

        private void somar(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumeroUm.Text) || string.IsNullOrWhiteSpace(txtNumeroDois.Text))
            {
                MessageBox.Show("Digite os dois numeros");
            }
            else
            {
                anterior = resultado;
                resultado = Convert.ToDouble(txtNumeroUm.Text) + Convert.ToDouble(txtNumeroDois.Text) + anterior - resultado;
                lblResultado.Text = $"{resultado}";
                txtNumeroUm.Text = Convert.ToString(resultado);
                txtNumeroDois.Clear();
            }
        }

        private void voltar(object sender, EventArgs e)
        {
            new TelaDashboard().Show();
            this.Hide();
        }

        private void txtNumeroUm_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.validarNumero(sender, e);
        }

        private void txtNumeroDois_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.validarNumero(sender, e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
