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
    public partial class TelaCategoriaProduto : Form
    {
        pro_chefeEntities3 bd = new pro_chefeEntities3();
        public static categoria existe;
        private Action carregaCategorias;

        public TelaCategoriaProduto()
        {
            InitializeComponent();
            btnVoltar.Click += voltar2;
            btnSalvar.Click += salvar;
            btnAlterar.Click += alterar;
            btnSalvarAlteracao.Click += salvarAlter;
            btnSalvarAlteracao.Visible = false;
            btnExcluir.Click += excluir;
            carregaTabela();
            carregaTabela();
        }

        public TelaCategoriaProduto(Action carregaCategorias)
        {
            InitializeComponent();
            this.carregaCategorias = carregaCategorias;
            btnVoltar.Click += voltar;
            btnSalvar.Click += salvar;
            btnAlterar.Click += alterar;
            btnSalvarAlteracao.Click += salvarAlter;
            btnSalvarAlteracao.Visible = false;
            btnExcluir.Click += excluir;
            carregaTabela();
        }

        private void excluir(object sender, EventArgs e)
        {
            int idCat = Convert.ToInt32(dgCategorias.SelectedRows[0].Cells[0].Value);
            categoria exclui = bd.categoria.Single(u => u.id.Equals(idCat));
            bool usada = false;
            bd.produto.ToList().ForEach(u =>
            {
                if (idCat == u.id_categoria)
                {
                    usada = true;
                }
            }
            );
            if (usada == false)
            {
                bd.categoria.Remove(exclui);
                bd.SaveChanges();
                carregaTabela();
            }
            else
            {
                MessageBox.Show("Categoria sendo usada!");
            }
        }

        private void salvarAlter(object sender, EventArgs e)
        {
            string nome = Convert.ToString(dgCategorias.SelectedRows[0].Cells[1].Value);
            categoria alterar = new categoria();
            alterar = bd.categoria.Where(u => u.nome.Equals(nome)).FirstOrDefault();
            alterar.nome = txtNome.Text;
            bd.SaveChanges();
            MessageBox.Show("Salvo com sucesso!");
            carregaTabela();
            btnSalvarAlteracao.Visible = false;
        }


        private void alterar(object sender, EventArgs e)
        {
            txtNome.Text = Convert.ToString(dgCategorias.SelectedRows[0].Cells[1].Value);
            btnSalvarAlteracao.Visible = true;
        }

        private void carregaTabela()
        {
            dgCategorias.DataSource = bd.categoria.Select(u => new { u.id, u.nome }).ToList();
        }

        private void salvar(object sender, EventArgs e)
        {
            existe = bd.categoria.Where(u => u.nome.Equals(txtNome.Text)).FirstOrDefault();
            if (existe == null)
            {
                categoria nova = new categoria()
                {
                    nome = txtNome.Text
                };
                bd.categoria.Add(nova);
                bd.SaveChanges();
                MessageBox.Show("Categoria cadastrada com sucesso!");
            }
            else
            {
                MessageBox.Show("Categoria já existe!");
            }
            carregaTabela();
        }
        private void voltar2(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void voltar(object sender, EventArgs e)
        {
            carregaCategorias();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.validarTexto(sender, e);
        }

        private void TelaCategoriaProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
