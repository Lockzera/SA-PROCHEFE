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
    public partial class TelaDelivery : Form
    {
        pro_chefeEntities3 bd = new pro_chefeEntities3();
        public static cliente clienteF = new cliente();
        public static cliente validar = new cliente();
        List<delivery> deliverys = new List<delivery>();
        List<usuario> entregadores = new List<usuario>();
        List<usuario> usuarios = new List<usuario>();
        public static delivery verProcess;
        //List<cliente> clientes = new List<cliente>();
        private decimal total;

        public TelaDelivery()
        {
            InitializeComponent();
            btnPesquisar.Click += pesquisar;
            btnAdicionar.Click += adicionar;   //ADICIONA UM PEDIDO
            //FAZER UMA LEITURA DA CHECKBOX == TRUE FINALIZAR
            btnVoltar.Click += voltar;
            usuarios = bd.usuario.ToList();
            deliverys = bd.delivery.ToList();
            //clientes = bd.cliente.ToList();
            btnProcessarDelivery.Click += processarDelivery;
            btnProcurarProdutos.Click += procurar;
            montarTbl();
        }


        private void procurar(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add("id", "id");
            dataGridView2.Columns.Add("id_pedido", "id_Pedido");
            dataGridView2.Columns.Add("nome", "Nome do Cliente");
            dataGridView2.Columns.Add("id", "Entregador");
            dataGridView2.Columns.Add("processamento", "Processamento");
            dataGridView2.Columns.Add("preco", "Preço");
            dataGridView2.Columns.Add("hora", "Horário do pedido");
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            bd.delivery.ToList().ForEach(u =>
            {
                if (u.processamento != true)
                {
                    bd.cliente.ToList().ForEach(f =>
                    {
                        itens_pedido itemPedido = bd.itens_pedido.Where(h => h.id_pedido.Equals(u.id_pedido)).FirstOrDefault();
                        produto produtoS = bd.produto.Where(g => g.id.Equals(itemPedido.id_produto)).FirstOrDefault();
                        pedido pedido = bd.pedido.Single(i => i.id.Equals(u.id_pedido));
                        if (u.id_cliente == f.id && id == u.id_cliente)
                        {
                            total = produtoS.preco * itemPedido.quantidade;
                            usuario nomeEntregador = bd.usuario.Single(t => t.id.Equals(u.id_entregador));
                            dataGridView2.Rows.Add(u.id, u.id_pedido, f.nome, nomeEntregador.nome, u.processamento, total, pedido.data);
                        }
                    });
                }
            });
            somar();
            //bd.delivery.ToList().ForEach(u =>
            //{
            //    if (u.processamento != true)
            //    {
            //        bd.cliente.ToList().ForEach(f =>
            //        {
            //            if (u.id_cliente == f.id && id == u.id_cliente)
            //            {
            //                usuario nomeEntregador = bd.usuario.Single(g => g.id.Equals(u.id_entregador));
            //                dataGridView2.Rows.Add(u.id, u.id_pedido, f.nome, nomeEntregador.nome, u.processamento, total);
            //            }
            //        });
            //    }
            //});
            //deliverys.ForEach(u =>
            //{
            //    if (u.processamento != true)
            //    {
            //        clientes.ForEach(e =>
            //        {
            //            if (e.id == u.id_cliente)
            //            {
            //                cliente client = bd.cliente.Single(f => f.id.Equals(e.id));
            //            }

            //        });
            //    }
            //});

        }

        private void somar()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (!string.IsNullOrEmpty(Convert.ToString(row.Cells["preco"].Value))){
                    total += Convert.ToDecimal(row.Cells["preco"].Value);
                }
            }
            MessageBox.Show("O total é de "+Convert.ToString(total)+ " Reais.");
        }

        private void processarDelivery(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            bd.delivery.ToList().ForEach(u =>
            {
                if (u.id_cliente == idCliente)
                {
                    u.processamento = true;
                    bd.SaveChanges();
                }
            });
            dataGridView2.Rows.Clear();
            //verProcess = bd.delivery.Where(d => d.id.Equals(idDelivery) && d.processamento == false).FirstOrDefault();
            //if (verProcess != null)
            //{
            //    verProcess = bd.delivery.Single(c => c.id.Equals(idDelivery) && c.processamento == false);
            //    verProcess.processamento = true;
            //    bd.SaveChanges();
            //    MessageBox.Show("Processado com sucesso!");
            //    dataGridView1.Rows.Clear();
            //    carregaTbl();
            //}
        }
        private void montarTbl()
        {

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("id", "ID do Cliente");
            dataGridView1.Columns.Add("nome", "Nome do Cliente");
            bd.cliente.ToList().ForEach(u =>
            {
                dataGridView1.Rows.Add(u.id, u.nome);
            });


            //deliverys.ForEach(u =>
            //{
            //    if (u.processamento != true)
            //    {
            //        clientes.ForEach(e =>
            //        {
            //            if (e.id == u.id_cliente)
            //            {
            //                dataGridView1.Rows.Add(u.id, u.id_pedido, e.nome, u.id_entregador, u.processamento); //trocar id POR NOME DO CARA
            //            }

            //        });
            //    }
            //});



            //deliverys.ForEach(u =>
            //{
            //    if (u.processamento != true)
            //    {
            //        clientes.ForEach(e =>
            //        {
            //            if (e.id == u.id_cliente)
            //            {
            //            }
            //        });
            //    }
            //});
        }

        private void voltar(object sender, EventArgs e)
        {

            Navegacao.voltarDashboard(this);
        }

        private void adicionar(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTelefone.Text) && !string.IsNullOrEmpty(txtNome.Text))
            {

                usuarios.ForEach(u =>
                {
                    if (u.tipo_usuario.Equals(3))
                    {
                        entregadores.Add(u);
                    }
                });
                if (entregadores.Count() >= 1)
                {
                    if (String.IsNullOrWhiteSpace(txtNome.Text) && String.IsNullOrWhiteSpace(txtTelefone.Text))
                    {
                        MessageBox.Show("Preencha os valores!");
                    }
                    else
                    {
                        new CadastroDelivery(clienteF, montarTbl).Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Deve haver um entregador cadastrado!");
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos!");
            }
        }

        private void pesquisar(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            clienteF = bd.cliente.Where(c => c.telefone.Equals(txtTelefone.Text)).FirstOrDefault();
            if (clienteF != null)
            {
                txtNome.Text = clienteF.nome;
                txtLogradouro.Text = clienteF.logradouro;
                txtNumero.Text = clienteF.numero;
                txtBairro.Text = clienteF.bairro;
                txtComplemento.Text = clienteF.complemento;
                txtCpf.Text = clienteF.cpf;
                txtCep.Text = clienteF.cep;
                txtUf.Text = clienteF.uf;
                txtCidade.Text = clienteF.cidade;
                clienteF = bd.cliente.Where(c => c.telefone.Equals(txtTelefone.Text)).FirstOrDefault();

                delivery achado = bd.delivery.Where(u => u.id_cliente.Equals(clienteF.id) && u.processamento == false).FirstOrDefault();
                if (achado != null)
                {
                    dataGridView1.Rows.Add(clienteF.id, clienteF.nome);
                }
                //bd.delivery.ToList().ForEach(g =>
                //{
                //    if (g.id_cliente == clienteF.id && g.processamento != true)
                //    {
                //    }
                //});
            }
            else
            {
                MessageBox.Show("Cliente não cadastrado");
            }
        }


        private void TelaDelivery_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TxtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.validarNumero(sender, e);
        }

        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.validarTexto(sender, e);
        }

        private void TxtLogradouro_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.validarTexto(sender, e);
        }


        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.validarNumero(sender, e);
        }

        private void TxtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.validarTexto(sender, e);
        }

        private void TxtComplemento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.removeEspecial(sender, e);
        }

        private void TxtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.validarNumero(sender, e);
        }

        private void TxtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.validarNumero(sender, e);
        }

        private void TxtUf_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.validarTexto(sender, e);
        }

        private void TxtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.validarTexto(sender, e);
        }

        private void txtTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pesquisar(sender, e);
            }
        }

        private void txtCpf_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.validarNumero(sender, e);
        }

        private void txtCep_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.validarNumero(sender, e);
        }
    }
}
