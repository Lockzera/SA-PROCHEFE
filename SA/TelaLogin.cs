using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SA.utils;

namespace SA
{
    public partial class TelaLogin : Form
    {
        pro_chefeEntities3 bd = new pro_chefeEntities3();
        public static usuario logado = new usuario();
        public static string login;
        public static string senha;
        public TelaLogin()
        {
            InitializeComponent();
            btnEntrar.Click += entrar;
            btnEntrar.Enabled = false;
            cbMostrar.Click += mostrar;
            txtSenha.UseSystemPasswordChar = true;
        }

        private void mostrar(object sender, EventArgs e)
        {
            if (cbMostrar.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void cadastrar(object sender, EventArgs e)
        {
            login = txtLogin.Text;
            senha = txtSenha.Text;
            new TelaCadastroUsuario().Show();
            this.Hide();
        }

        private void entrar(object sender, EventArgs e)
        {
            logado = bd.usuario.Where(u => u.login.Equals(txtLogin.Text)
                && u.senha.Equals(txtSenha.Text) && (u.tipo_usuario == 1 || u.tipo_usuario == 2)).FirstOrDefault();
            if (logado != null)
            {
                TelaDashboard menu = new TelaDashboard();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login ou senha inválidos!");
            }
            txtLogin.Clear();
            txtSenha.Clear();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                entrar(sender, e);
            }
        }

        private void TelaLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.removeEspecial(sender, e);
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.removeEspecial(sender, e);
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLogin.Text) && !string.IsNullOrEmpty(txtSenha.Text))
            {
                btnEntrar.Enabled = true;
            }
            else
            {
                btnEntrar.Enabled = false;
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLogin.Text) || !string.IsNullOrEmpty(txtSenha.Text))
            {
                btnEntrar.Enabled = true;
            }
            else
            {
                btnEntrar.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtRelogio.Text = DateTime.Now.ToLongTimeString();
        }

    }
}
