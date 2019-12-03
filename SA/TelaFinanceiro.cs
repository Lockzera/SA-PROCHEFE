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
using System.Windows.Forms.DataVisualization.Charting;


namespace SA
{
    public partial class TelaFinanceiro : Form
    {
        pro_chefeEntities3 bd = new pro_chefeEntities3();
        public TelaFinanceiro()
        {
            InitializeComponent();
            btnVoltar.Click += BtnVoltar_Click;
            produtoMaisVendido();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Navegacao.voltarDashboard(this);
        }

        private void produtoMaisVendido()
        {
            int nProdutos = bd.produto.Count();
            int nDelivery = bd.delivery.Count();
            int nMesa = bd.pedido.Where(u => u.id_mesa == null).Count();
            int nClientes = bd.cliente.Count();
            lblProduto.Text = Convert.ToString(nProdutos);
            lblCliente.Text = Convert.ToString(nClientes);
            lblMesa.Text = Convert.ToString(nMesa);
            lblDelivery.Text = Convert.ToString(nDelivery);
            //var resultado = bd.itens_pedido.GroupBy(u => u.id_produto).Select(u => u.id_produto).Count();
            //int maiorVenda = bd.itens_pedido.Select(u => u.id_produto).Count();
            //int nProdut = bd.itens_pedido.Select(f => f.id_produto).Count().GroupBy(u => u.id_produto);
            var query = bd.itens_pedido
                   .GroupBy(p => p.id_produto)
                   .Select(g => new { idProd = g.Key, count = g.Count() })
                   .OrderByDescending(g => g.count).First();

            bd.produto.ToList().ForEach(u =>
            {
                if (query.idProd == u.id)
                {
                    lblNomeProd.Text = $"{u.nome}";
                }
            });
        }

        private void TelaFinanceiro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TelaFinanceiro_Load(object sender, EventArgs e)
        {
            var carre = bd.itens_pedido
              .GroupBy(p => p.id_produto)
              .Select(g => new { idProd = g.Key, count = g.Count() })
              .OrderByDescending(g => g.count)
              .Take(5);
            //MessageBox.Show(Convert.ToString(carre.Take(1).ToList()));
            var prod = carre.Take(5).ToList();
            foreach (var idPod in prod)
            {
                bd.produto.ToList().ForEach(u =>
                {
                    if (idPod.idProd == u.id)
                    {
                        chart1.Series["s1"].Points.AddXY(Convert.ToString(u.nome), Convert.ToString(idPod.count));
                    }
                }
                );
            }
            //for (int i = 0; i < 5; i++)
            //{
            //    Series series = this.chart1.Series.Add(carre.Take.to());

            //}

            // Add point.
            ////Nesse for eu adiciono automaticamente as series(meses) e associo ao gráfico
        }
    }
}


