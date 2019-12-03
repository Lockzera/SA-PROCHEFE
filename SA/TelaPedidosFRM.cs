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
    public partial class TelaPedidosFRM : Form
    {
        pro_chefeEntities3 bd = new pro_chefeEntities3();
        public static mesa selecionada;
        public static mesa select;
        public static produto p;
        public static produto selectProduto;
        public static mesa ver;
        public static mesa disponibilidade;

        List<produto> produtos = new List<produto>();
        List<pedido> pedidosMesa = new List<pedido>();

        public TelaPedidosFRM()
        {
            InitializeComponent();
        }

        public TelaPedidosFRM(mesa mesaSelecionada)
        {
            produtos = bd.produto.ToList();
            InitializeComponent();
            selecionada = mesaSelecionada;
            if (mesaSelecionada.disponibilidade == true)
            {
                cbDisponibilidade.Checked = true;
            }
            cbDisponibilidade.Click += CbDisponibilidade_Click;
            btnResumo.Click += resumo;
            label1.Text = $" Mesa {selecionada.id}";
            cbxNome.Text = "-Selecione ou Digite-";
            carregaCbx();
            btnVoltar.Click += voltar;
            btnIncluir.Click += selecionarItem;

            carregPedidosMesa();
        }

        private void carregPedidosMesa()
        {
            bd.pedido.ToList().ForEach(u =>
            {
                if (u.id_mesa == selecionada.id && u.finalizado == false)
                {
                    pedidosMesa.Add(u);
                }
            });
            decimal total = 0;
            bd.itens_pedido.ToList().ForEach(u =>
            {
                bd.produto.ToList().ForEach(g =>
                {
                    pedidosMesa.ForEach(i =>
                    {
                        if (i.id_mesa == selecionada.id && u.id_pedido == i.id && g.id == u.id_produto)
                        {
                            total += u.quantidade * g.preco;
                        }
                    });

                });
            });
            labelTotal.ResetText();
            labelTotal.Text = Convert.ToString(total);
        }



        private void resumo(object sender, EventArgs e)
        {
            ver = bd.mesa.Where(d => d.id.Equals(selecionada.id) && d.disponibilidade == false).FirstOrDefault();
            if (ver != null)
            {
                select = bd.mesa.Single(c => c.id.Equals(selecionada.id) && c.disponibilidade == false);
                cbDisponibilidade.Checked = true;
                select.disponibilidade = true;
                bd.SaveChanges();
            }
            bd.itens_pedido.ToList().ForEach(u =>
            {
                bd.produto.ToList().ForEach(g =>
                {
                    pedidosMesa.ForEach(i =>
                    {
                        if (i.id_mesa == selecionada.id && u.id_pedido == i.id && g.id == u.id_produto)
                        {
                            MessageBox.Show(u.quantidade + " " + Convert.ToString(g.nome) + $", R$ {g.preco}");
                        }
                    });

                });
            });
            int idMesaFinalizar = select.id;
            bd.pedido.ToList().ForEach(u =>
            {
                if (u.id_mesa == idMesaFinalizar)
                {
                    u.finalizado = true;
                    bd.SaveChanges();
                }
            });
            labelTotal.ResetText();
        }


        private void selecionarItem(object sender, EventArgs e)
        {
            ver = bd.mesa.Where(d => d.id.Equals(selecionada.id) && d.disponibilidade == false).FirstOrDefault();
            if (ver == null)
            {
                select = bd.mesa.Single(c => c.id.Equals(selecionada.id) && c.disponibilidade == true);
                select.disponibilidade = false;
                cbDisponibilidade.Checked = false;
                bd.SaveChanges();
            }
            if (nUpDown.Value != 0)
            {
                int idProduto = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                p = bd.produto.Find(idProduto); //ACHAR VALOR IDPRODUTO

                int qtd = Convert.ToInt32(nUpDown.Value);
                pedido pd = new pedido()
                {
                    data = DateTime.Now,
                    id_mesa = selecionada.id
                };
                bd.pedido.Add(pd);

                pedidosMesa.Add(pd);

                itens_pedido ip = new itens_pedido()
                {
                    id_pedido = pd.id,
                    id_produto = p.id,
                    quantidade = qtd
                };


                bd.itens_pedido.Add(ip);
                bd.SaveChanges();

                dataGridView1.Rows.Clear();
                cbxNome.ResetText();
                carregPedidos2();
            }
            else
            {
                MessageBox.Show("Preencha os campos!");
            }
        }

        private void carregPedidos2()
        {
            decimal total = 0;
            bd.itens_pedido.ToList().ForEach(u =>
            {
                bd.produto.ToList().ForEach(g =>
                {
                    pedidosMesa.ForEach(i =>
                    {
                        if (i.id_mesa == selecionada.id && u.id_pedido == i.id && g.id == u.id_produto)
                        {
                            total += u.quantidade * g.preco;
                        }
                    });

                });
            });
            labelTotal.ResetText();
            labelTotal.Text = Convert.ToString(total);
        }

        private void alteraDisponibilidade(object sender, EventArgs e)
        {
            if (selecionada.disponibilidade != true)
            {
                cbDisponibilidade.Checked = false;

                bd.SaveChanges();
            }
            else
            {
                cbDisponibilidade.Checked = true;

                bd.SaveChanges();
            }
        }
        private void CbDisponibilidade_Click(object sender, EventArgs e)
        {
            ver = bd.mesa.Where(d => d.id.Equals(selecionada.id) && d.disponibilidade == true).FirstOrDefault();
            if (ver != null)
            {
                select = bd.mesa.Single(c => c.id.Equals(selecionada.id) && c.disponibilidade == true);
                select.disponibilidade = false;
                bd.SaveChanges();
            }
            else
            {
                select = bd.mesa.Single(c => c.id.Equals(selecionada.id) && c.disponibilidade == false);
                select.disponibilidade = true;
                bd.SaveChanges();
            }
        }


        private void carregaCbx()
        {
            produtos.ForEach(u =>
            {
                cbxNome.Items.Add(u.nome);
            });

        }
        private void cbxNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            produtos.ForEach(u =>
            {
                if (cbxNome.Text == u.nome)
                {
                    dataGridView1.Rows.Add(u.id, u.nome, u.preco);
                }
            });
        }

        private void voltar(object sender, EventArgs e)
        {
            new TelaDashboard().Show();
            this.Hide();
        }
        private void TelaPedidosFRM_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
