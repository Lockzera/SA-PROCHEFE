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
    public partial class CadastroDelivery : Form
    {
        pro_chefeEntities3 bd = new pro_chefeEntities3();
        List<cliente> clientes;
        List<produto> produtos;
        List<usuario> entregadores;
        private cliente cliente;
        public static decimal resultado = 0;
        public static decimal anterior = 0;
        public static decimal total = 0;

        public Action MontarTbl { get; }

        public CadastroDelivery()
        {
            InitializeComponent();
            clientes = bd.cliente.ToList();
        }
        public CadastroDelivery(cliente clienteF, Action montarTbl)
        {
            InitializeComponent();
            produtos = bd.produto.ToList();
            this.cliente = clienteF;
            MontarTbl = montarTbl;
            txtNome.Text = this.cliente.nome;
            txtTelefone.Text = this.cliente.telefone;
            btnIncluir.Click += incluir;
            entregadores = bd.usuario.ToList();
            cbxEntregador.Text = "-SELECIONE-";
            cbxProdutos.Text = "-SELECIONE-";
            btnVoltar.Click += voltar;
            carregaCbx();
        }
        private void carregaCbx()
        {
            produtos.ForEach(u =>
            {
                cbxProdutos.Items.Add(u.nome);
            });
            //List<usuario> entregadoresCbx = new List<usuario>();
            usuario entregador = new usuario();
            entregadores.ForEach(u =>
            {
                if (u.tipo_usuario.Equals(3))
                {
                    entregador = u;
                    cbxEntregador.Items.Add(entregador.nome);
                }
            });
        }

        private void incluir(object sender, EventArgs e)
        {

            //ver = bd.pedido.Where(d => d.id.Equals(selecionada.id) && d.disponibilidade == false).FirstOrDefault();
            //if (ver != null)
            //{
            //    select = bd.mesa.Single(c => c.id.Equals(selecionada.id) && c.disponibilidade == false);
            //    cbDisponibilidade.Checked = true;
            //    select.disponibilidade = true;
            //    bd.SaveChanges();
            //};
            //MessageBox.Show($"O total é de {resultado}");
            //LimpaLista();
            //total = 0;
            //resultado = 0;
            //anterior = 0;

            if (nUPQuantidade.Value != 0 && !string.IsNullOrEmpty(txtNome.Text) && !string.IsNullOrEmpty(txtTelefone.Text) && !string.IsNullOrEmpty(cbxProdutos.Text) && !string.IsNullOrEmpty(cbxEntregador.Text) && cbxProdutos.Text != "-SELECIONE-" && cbxEntregador.Text != "-SELECIONE-")
            {
                int idProduto = Convert.ToInt32(dataGridViewPedido.SelectedRows[0].Cells[0].Value);
                produto p = bd.produto.Find(idProduto); //ACHAR VALOR IDPRODUTO

                int qtd = Convert.ToInt32(nUPQuantidade.Value);
                cliente cliente = bd.cliente.Where(u => u.nome.Equals(txtNome.Text)).FirstOrDefault(); 
                pedido pd = new pedido()
                {
                    data = DateTime.Now,
                };
                bd.pedido.Add(pd);

                itens_pedido ip = new itens_pedido()

                {
                    id_pedido = pd.id,
                    id_produto = p.id,
                    quantidade = qtd
                };
                bd.itens_pedido.Add(ip);

                delivery dl = new delivery()
                {
                    id_pedido = pd.id,
                    id_cliente = cliente.id,                    //ERRO NO ID
                    //id_entregador = cbxEntregador.SelectedIndex
                };
                entregadores.ForEach(u =>
                {
                    if (cbxEntregador.Text == u.nome)
                    {
                        dl.id_entregador = u.id;
                    }
                });
                bd.delivery.Add(dl);

                bd.SaveChanges();
                MessageBox.Show("Incluido com sucesso! ");


                decimal precoProduto = Convert.ToDecimal(dataGridViewPedido.SelectedRows[0].Cells[2].Value);
                anterior = resultado;
                resultado = anterior + (precoProduto * qtd);
                lblTotal.Text = Convert.ToString(resultado);
                dataGridViewPedido.Rows.Clear();
                cbxProdutos.ResetText();
                cbxEntregador.ResetText();
            }
            else
            {
                MessageBox.Show("Preencha os campos!");
            }

        }

        private void voltar(object sender, EventArgs e)
        {
            total = 0;
            anterior = 0;
            resultado = 0;
            MontarTbl();
            new TelaDelivery().Show();
            this.Hide();
        }

        private void CadastroDelivery_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cbxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            produtos.ForEach(u =>
            {
                if (cbxProdutos.Text == u.nome)
                {
                    dataGridViewPedido.Rows.Add(u.id, u.nome, u.preco);
                }
            });
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.validarTexto(sender, e);
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.validarNumero(sender, e);
        }

        private void CadastroDelivery_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
