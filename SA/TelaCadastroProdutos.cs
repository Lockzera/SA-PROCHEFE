using SA.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA
{
    public partial class TelaCadastroProdutos : Form
    {
        pro_chefeEntities3 bd = new pro_chefeEntities3();
        //
        string caminhoFoto;
        public static produto alterar;
        public static itens_pedido usado = new itens_pedido();
        public static produto_ingrediente usando = new produto_ingrediente();
        public static produto nomeUsado;
        public static bool usandoIngrediente;
        public static ingrediente vazio;
        List<categoria> categorias;
        List<ingrediente> ingredientesUsados = new List<ingrediente>();
        List<ingrediente> ingredientes = new List<ingrediente>();
        public TelaCadastroProdutos()
        {
            InitializeComponent();
            //buttons
            btnSalvarProdutos.Click += salvarCadastroProduto;
            btnExcluirProdutos.Click += excluirProdutos;
            btnAlterar.Click += alterarProduto;
            btnSalvarAlteracao.Click += BtnSalvarAlteracao_Click;
            btnSalvarAlteracao.Visible = false;


            btnCarregarArquivo.Click += carregaImagem;
            btnCadastrarCategoria.Click += cadastrarCategoria;

            btnSalvarIngrediente.Click += salvarIngrediente;
            btnExcluirIngrediente.Click += excluirIngrediente;
            btnAlterarIngrediente.Click += alterarIngrediente;
            btnSalvarAlteracao2.Click += BtnSalvarAlteracao2_Click;
            btnSalvarAlteracao2.Visible = false;

            btnVoltarProdutos.Click += voltar;
            btnVoltarIngrediente.Click += voltar2;

            carregaIngredientes();
            carregaCategorias();
            carregaUnidadeMedida();

            montarTabela();
            montarTabelaIngrediente();

            categorias = bd.categoria.ToList();
            ingredientes = bd.ingrediente.ToList();
        }

        private void BtnSalvarAlteracao2_Click(object sender, EventArgs e)
        {
            int idIng = Convert.ToInt32(dgIngrediente.SelectedRows[0].Cells[0].Value);
            ingrediente alterar = bd.ingrediente.Single(u => u.id.Equals(idIng));
            if (String.IsNullOrWhiteSpace(txtNomeIngrediente.Text) && nUpQuantidade.Value.Equals(0))
            {
                MessageBox.Show("Não houve alteração!");
            }
            else
            {
                alterar.nome = txtNomeIngrediente.Text;
                alterar.estoque = Convert.ToInt32(nUpQuantidade.Value);
                alterar.medida = cbxUnidadeMedida.Text;
                bd.SaveChanges();
                montarTabelaIngrediente();
            }
        }

        private void alterarIngrediente(object sender, EventArgs e)
        {
            int idIng = Convert.ToInt32(dgIngrediente.SelectedRows[0].Cells[0].Value);
            ingrediente alterar = bd.ingrediente.Single(u => u.id.Equals(idIng));
            txtNomeIngrediente.Text = alterar.nome;
            nUpQuantidade.Value = Convert.ToInt32(alterar.estoque);
            cbxUnidadeMedida.Text = alterar.medida;
            btnSalvarAlteracao2.Visible = true;
        }

        private void carregaUnidadeMedida()
        {
            cbxUnidadeMedida.Items.Add("Fatia");
            cbxUnidadeMedida.Items.Add("Kg");
            cbxUnidadeMedida.Items.Add("g");
            cbxUnidadeMedida.Items.Add("mg");
            cbxUnidadeMedida.Items.Add("L");
            cbxUnidadeMedida.Items.Add("mL");
            cbxUnidadeMedida.Items.Add("Lata");
        }

        private void alterarProduto(object sender, EventArgs e)
        {
            txtNome.Text = Convert.ToString(dgProdutos.SelectedRows[0].Cells[1].Value);
            txtDescricao.Text = Convert.ToString(dgProdutos.SelectedRows[0].Cells[4].Value);
            cbxCategoria.Text = Convert.ToString(dgProdutos.SelectedRows[0].Cells[2].Value);
            txtValor.Text = Convert.ToString(dgProdutos.SelectedRows[0].Cells[3].Value);
            btnSalvarAlteracao.Visible = true;
            //
            int idProduto = Convert.ToInt32(dgProdutos.SelectedRows[0].Cells[0].Value);
            bd.produto_ingrediente.ToList().ForEach(u => { 
            
                if(u.id_produto == idProduto)
                {
                    bd.produto_ingrediente.Remove(u);
                }
            });
            bd.SaveChanges();
        }

        private void BtnSalvarAlteracao_Click(object sender, EventArgs e)
        {
            int idProduto = Convert.ToInt32(dgProdutos.SelectedRows[0].Cells[0].Value);
            categoria selecionada = categorias.ElementAt(cbxCategoria.SelectedIndex);
            produto alteracao = new produto();
            if (String.IsNullOrWhiteSpace(txtNome.Text) && String.IsNullOrWhiteSpace(txtValor.Text))
            {
                MessageBox.Show("Não houve alteração!");
            }
            else
            {
                alteracao = bd.produto.Single(c => c.id.Equals(idProduto));
                alteracao.nome = txtNome.Text;
                alteracao.descricao = txtDescricao.Text;
                alteracao.id_categoria = selecionada.id;
                alteracao.preco = Convert.ToDecimal(txtValor.Text);
                bd.SaveChanges();
                montarTabela();
                txtNome.Clear();
                txtValor.Clear();
                txtDescricao.Clear();
                bd.SaveChanges();
                clbIngredientes.Items.Clear();
                carregaIngredientes();
                ingredientesUsados.ForEach(u =>
                {
                    produto_ingrediente novoProdIng = new produto_ingrediente()
                    {
                        id_produto = idProduto,
                        id_ingrediente = u.id
                    };
                    bd.produto_ingrediente.Add(novoProdIng);
                    bd.SaveChanges();
                });
            }
            btnSalvarAlteracao.Visible = false;
        }

        private void carregaIngredientes()
        {
            bd.ingrediente.ToList().ForEach(u =>
            {
                clbIngredientes.Items.Add(u.nome, CheckState.Unchecked);
            });
        }

        private void cadastrarCategoria(object sender, EventArgs e)
        {
            new TelaCategoriaProduto(carregaCategorias).Show();
            txtNome.Clear();
            txtValor.Clear();
            txtDescricao.Clear();
            bd.SaveChanges();
            clbIngredientes.Items.Clear();
            carregaIngredientes();
        }

        private void montarTabelaIngrediente()
        {
            dgIngrediente.DataSource = bd.ingrediente.Select(u => new { u.id, u.nome, u.medida, u.estoque }).ToList();
        }

        private void excluirIngrediente(object sender, EventArgs e)
        {
            int idIngrediente = Convert.ToInt32(dgIngrediente.SelectedRows[0].Cells[0].Value);
            usando = bd.produto_ingrediente.Where(f => f.id_ingrediente.Equals(idIngrediente)).FirstOrDefault();
            if (usando != null)
            {
                MessageBox.Show("Ingrediente sendo usado!");
            }
            else
            {
                var db = bd.ingrediente.Where(u => u.id.Equals(idIngrediente)).FirstOrDefault();
                bd.ingrediente.Remove(db);
                bd.SaveChanges();
                montarTabelaIngrediente();
            }

        }

        private void salvarIngrediente(object sender, EventArgs e)
        {
            usandoIngrediente = true;
            if (string.IsNullOrEmpty(txtNomeIngrediente.Text) || nUpQuantidade.Value == 0)
            {
                MessageBox.Show("Preencha os campos!");
            }
            else
            {
                ingrediente novo = new ingrediente()
                {
                    nome = txtNomeIngrediente.Text,
                    estoque = Convert.ToInt32(nUpQuantidade.Value),
                    medida = cbxUnidadeMedida.Text,
                };
                bd.ingrediente.Add(novo);
                bd.SaveChanges();
                montarTabelaIngrediente();
                txtNomeIngrediente.Clear();
                nUpQuantidade.Value = 0;
                clbIngredientes.Items.Clear();
                carregaIngredientes();
            }

        }
        private void carregaImagem(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Selecione uma imagem...";
            openFileDialog1.Filter = "png|*.png| jpg|*.jpg| jpeg|*.jpeg";
            openFileDialog1.Title = "Open image file";

            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                desenhaImagem();
            }
        }
        private void desenhaImagem()
        {
            caminhoFoto = openFileDialog1.FileName;
            byte[] content = File.ReadAllBytes(openFileDialog1.FileName);
            MemoryStream ms = new MemoryStream(content);
            pbImagem.Image = Image.FromStream(ms);
        }

        public void carregaCategorias()
        {
            cbxCategoria.DataSource = bd.categoria.Select(c => c.nome).ToList();
        }

        private void excluirProdutos(object sender, EventArgs e)
        {
            int idProduto = Convert.ToInt32(dgProdutos.SelectedRows[0].Cells[0].Value);
            usado = bd.itens_pedido.Where(u => u.id_produto.Equals(idProduto)).FirstOrDefault();
            if (usado == null)
            {
                var db = bd.produto.Where(u => u.id.Equals(idProduto)).FirstOrDefault();
                bd.produto.Remove(db);
                bd.SaveChanges();
            }
            else
            {
                MessageBox.Show("Produto está sendo usado!");
            }
            montarTabela();
        }

        private void salvarCadastroProduto(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNome.Text) || String.IsNullOrWhiteSpace(txtValor.Text))
            {
                MessageBox.Show("Preencha os campos!");
            }
            else
            {
                nomeUsado = bd.produto.Where(c => c.nome.Equals(txtNome.Text)).FirstOrDefault();
                if (nomeUsado == null)
                {
                    categoria selecionada = categorias.ElementAt(cbxCategoria.SelectedIndex);
                    produto novo = new produto()
                    {
                        nome = txtNome.Text,
                        descricao = txtDescricao.Text,
                        preco = Convert.ToDecimal(txtValor.Text),
                        id_categoria = selecionada.id,
                        imagem = caminhoFoto
                    };

                    bd.produto.Add(novo);
                    bd.SaveChanges();
                    montarTabela();
                    produto nomeProd = bd.produto.Where(u => u.nome.Equals(txtNome.Text)).FirstOrDefault();
                    ingredientesUsados.ForEach(u =>
                    {
                        produto_ingrediente novoProdIng = new produto_ingrediente()
                        {
                            id_produto = nomeProd.id,
                            id_ingrediente = u.id
                        };
                        bd.produto_ingrediente.Add(novoProdIng);
                        bd.SaveChanges();
                    });
                    //bd.produto.ToList().ForEach(f =>
                    //{
                    //    if (txtNome.Text == f.nome)
                    //    {

                    //        ingredientesUsados.ForEach(u =>
                    //        {
                    //            produto_ingrediente novoProdIng = new produto_ingrediente()
                    //            {
                    //                id_produto = f.id,
                    //                id_ingrediente = u.id
                    //            };
                    //            bd.produto_ingrediente.Add(novoProdIng);
                    //        });
                    //    }
                    //});
                    txtNome.Clear();
                    txtValor.Clear();
                    txtDescricao.Clear();
                    bd.SaveChanges();
                    clbIngredientes.Items.Clear();
                    carregaIngredientes();

                }
                else
                {
                    MessageBox.Show("Produto ja cadastrado!");
                }
            }
        }

        private void montarTabela()
        {
            dgProdutos.Rows.Clear();
            bd.categoria.ToList().ForEach(g =>
            {
                bd.produto.ToList().ForEach(u =>
                {
                    if (g.id == u.id_categoria)
                    {
                        dgProdutos.Rows.Add(u.id, u.nome, g.nome, u.preco, u.descricao);
                    }

                });

            });
        }

        private void clbIngredientes_Click(object sender, EventArgs e)
        {
            ingrediente selecionado = ingredientes.ElementAt(clbIngredientes.SelectedIndex);
            ingredientesUsados.Add(selecionado);
        }

        private void voltar(object sender, EventArgs e)
        {
            Navegacao.voltarDashboard(this);
        }

        private void voltar2(object sender, EventArgs e)
        {
            Navegacao.voltarDashboard(this);
        }

        private void TelaCadastroProdutos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.validarNumero(sender, e);
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.validarTexto(sender, e);
        }

        private void nUpQuantidade_ValueChanged(object sender, EventArgs e)
        {
            nUpQuantidade.Maximum = 10000;
            nUpQuantidade.Minimum = 0;
        }

    }
}
