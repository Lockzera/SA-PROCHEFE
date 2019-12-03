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
    public partial class TelaCadastroUsuario : Form
    {
        pro_chefeEntities3 bd = new pro_chefeEntities3();
        List<tipo_usuario> tipoUser;
        public static usuario validar = new usuario();
        public static usuario logado;
        public static delivery usado;
        private string telaEntregador;
        private Action carregaTbl;
        private Action carregaCbx;

        public TelaCadastroUsuario()
        {
            InitializeComponent();
            btnSalvarCadastro.Click += salvarCadastro;
            btnVoltar.Click += voltar;
            btnExcluir.Click += excluir;
            cbMostrar.Click += mostrar;
            btnAlterar.Click += alterar;
            tipoUser = bd.tipo_usuario.ToList();
            montarTabela();
            carregaTipoUsuario();
            txtSenha.UseSystemPasswordChar = true;
            btnSalvarAlteracao.Visible = false;
            btnSalvarAlteracao.Click += salvarAlteracao;
        }

        public TelaCadastroUsuario(string telaEntregador, Action carregaTbl, Action carregaCbx)
        {
            InitializeComponent();
            this.telaEntregador = telaEntregador;
            btnSalvarCadastro.Click += salvarCadastro;
            btnVoltar.Click += voltar2;
            btnExcluir.Click += excluir;
            cbMostrar.Click += mostrar;
            btnAlterar.Click += alterar;
            tipoUser = bd.tipo_usuario.ToList();
            montarTabela();
            carregaTipoUsuario();
            txtSenha.UseSystemPasswordChar = true;
            btnSalvarAlteracao.Visible = false;
            btnSalvarAlteracao.Click += salvarAlteracao;
            this.carregaTbl = carregaTbl;
            this.carregaCbx = carregaCbx;
        }

        private void salvarAlteracao(object sender, EventArgs e)
        {
            int idUser = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            usuario altera = bd.usuario.Single(u => u.id.Equals(idUser));
            altera.nome = txtNome.Text;
            altera.login = txtLogin.Text;
            altera.senha = txtSenha.Text;
            bd.SaveChanges();
            montarTabela();
            MessageBox.Show("Alterado com sucesso");
            btnSalvarAlteracao.Visible = false;
            txtNome.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
        }

        private void alterar(object sender, EventArgs e)
        {
            btnSalvarAlteracao.Visible = true;
            int idUser = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            usuario altera = bd.usuario.Single(u => u.id.Equals(idUser));
            txtNome.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
            txtLogin.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value);
            txtSenha.Text = altera.senha;
        }

        private void excluir(object sender, EventArgs e)
        {
            int idUsuario = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            string nome = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
            logado = bd.usuario.Where(u => u.login.Equals(TelaLogin.logado.nome) && u.tipo_usuario == 1).FirstOrDefault();

            int idEntregador = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            usado = bd.delivery.Where(u => u.id_entregador.Equals(idEntregador) && u.processamento==false).FirstOrDefault();

            if (logado != null && usado == null)
            {
                var db = bd.usuario.Where(u => u.id.Equals(idUsuario)).FirstOrDefault();
                bd.usuario.Remove(db);
                bd.SaveChanges();
                montarTabela();
            }

            else if (usado != null)
            {
                MessageBox.Show("Entregador está sendo usado!");
            }
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

        private void salvarCadastro(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLogin.Text) && !string.IsNullOrEmpty(txtNome.Text) && !string.IsNullOrEmpty(txtSenha.Text) && !string.IsNullOrEmpty(cbxTipoUsuario.Text))
            {

                tipo_usuario tp = tipoUser.ElementAt(cbxTipoUsuario.SelectedIndex);
                usuario novo = new usuario()
                {
                    nome = txtNome.Text,
                    login = txtLogin.Text,
                    senha = txtSenha.Text,
                    tipo_usuario = tp.id
                };
                validar = bd.usuario.Where(u => u.login.Equals(novo.login) && u.tipo_usuario == novo.tipo_usuario).FirstOrDefault();
                if (validar != null)
                {
                    MessageBox.Show("Usuário já cadastrado");
                }
                else
                {

                    bd.usuario.Add(novo);
                    bd.SaveChanges();
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                }
                montarTabela();
                txtNome.Clear();
                txtLogin.Clear();
                txtSenha.Clear();
                cbMostrar.ResetText();
            }
            else
            {
                MessageBox.Show("Preencha os campos!");
            }
        }
        private void carregaTipoUsuario()
        {
            cbxTipoUsuario.DataSource = bd.tipo_usuario.Select(c => c.nome).ToList();

        }

        private void montarTabela()
        {
            dataGridView1.DataSource = bd.usuario.Select(c => new { c.id, c.nome, c.login, c.tipo_usuario }).ToList();
        }
        private void voltar(object sender, EventArgs e)
        {
            new TelaDashboard().Show();
            this.Hide();
        }
        private void voltar2(object sender, EventArgs e)
        {
            this.Hide();
            carregaTbl();
            carregaCbx();
        }

        private void TelaCadastroUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.validarTexto(sender, e);
        }

        private void TxtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.removeEspecial(sender, e);
        }

    }
}
