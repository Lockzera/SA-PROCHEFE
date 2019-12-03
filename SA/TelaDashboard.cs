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
    public partial class TelaDashboard : Form
    {
        pro_chefeEntities3 bd = new pro_chefeEntities3();
        List<mesa> mesas = new List<mesa>();
        private object resultado;
        private object total;
        private object anterior;

        public TelaDashboard()
        {
            InitializeComponent();
            btnVoltar.Click += BtnVoltar_Click;
            btnVoltar2.Click += BtnVoltar2_Click;
            btnCadastroProdutos.Click += cadastroProduto;
            btnCadastroMesas.Click += cadastroMesa;
            btnCadastroClientes.Click += cadastroCliente;
            btnFinanceiro.Click += financeiro;
            btnCategorias.Click += categoria;
            btnUsuario.Click += cadastrar;
            btnDelivery.Click += delivery;
            btnEntregador.Click += entregador;
            lblUser.Text += TelaLogin.logado.nome;
            lblUser2.Text += TelaLogin.logado.nome;
            mesas = bd.mesa.ToList();
            montaMesas();
            btnCalculo.Click += calculo;
        }

        public TelaDashboard(object resultado, object total, object anterior)
        {
            InitializeComponent();
            this.resultado = resultado;
            this.total = total;
            this.anterior = anterior;
            btnVoltar.Click += BtnVoltar_Click;
            btnVoltar2.Click += BtnVoltar2_Click;
            btnCadastroProdutos.Click += cadastroProduto;
            btnCadastroMesas.Click += cadastroMesa;
            btnCadastroClientes.Click += cadastroCliente;
            btnFinanceiro.Click += financeiro;
            btnCategorias.Click += categoria;
            btnUsuario.Click += cadastrar;
            btnDelivery.Click += delivery;
            btnEntregador.Click += entregador;
            lblUser.Text += TelaLogin.logado.nome;
            lblUser2.Text += TelaLogin.logado.nome;
            mesas = bd.mesa.ToList();
            montaMesas();
            btnCalculo.Click += calculo;
        }

        private void financeiro(object sender, EventArgs e)
        {
            new TelaFinanceiro().Show();
            this.Hide();
        }

        private void categoria(object sender, EventArgs e)
        {
            new TelaCategoriaProduto().Show();
        }

        private void cadastrar(object sender, EventArgs e)
        {
            if (TelaLogin.logado.tipo_usuario == 1)
            {
                new TelaCadastroUsuario().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Somente admins podem cadastrar!");
            }
        }


        private void calculo(object sender, EventArgs e)
        {
            new TelaCalculadora().Show();
            this.Hide();
        }

        private void montaMesas()
        {
            mesas.ToList().ForEach(n =>
            {
                if (n.disponibilidade == true)
                {
                    Panel p = new Panel();
                    p.Width = 100;
                    p.Height = 90;
                    p.BackColor = Color.LightGreen;

                    Label nomeMesa = new Label();
                    nomeMesa.Text = $"Mesa {n.id}";
                    p.Controls.Add(nomeMesa);

                    PictureBox foto = new PictureBox();
                    foto.Name = n.id.ToString();
                    foto.Click += selecionaMesa;
                    foto.Location = new Point(20, 20);
                    foto.Image = Properties.Resources.ESSSSSSSSSSSSA;
                    foto.Width = 80;
                    foto.Height = 80;
                    p.Controls.Add(foto);
                    flowLayoutPanel2.Controls.Add(p);
                }
                else
                {
                    Panel p = new Panel();
                    p.Width = 100;
                    p.Height = 90;
                    p.BackColor = Color.OrangeRed;

                    Label nomeMesa = new Label();
                    nomeMesa.Text = $"Mesa {n.id}";
                    p.Controls.Add(nomeMesa);

                    Label hora = new Label();
                    int horas = DateTime.Now.Hour;
                    int minutos = DateTime.Now.Minute;
                    hora.Text = $"Hora {horas.ToString() + ":" + minutos.ToString()}";
                    p.Controls.Add(hora);
                    hora.Location = new Point(10, 70);

                    PictureBox foto = new PictureBox();
                    foto.Name = n.id.ToString();
                    foto.Click += selecionaMesa;
                    foto.Location = new Point(20, 20);
                    foto.Image = Properties.Resources.ESSSSSSSSSSSSA;
                    foto.Width = 80;
                    foto.Height = 80;
                    p.Controls.Add(foto);
                    flowLayoutPanel2.Controls.Add(p);
                }
            });
        }

        private void selecionaMesa(object sender, EventArgs e)
        {
            PictureBox mesaSelecionada = (PictureBox)sender;         //puxa o panel que recebeu o clique
            mesa selecionada = bd.mesa.Find(Convert.ToInt32(mesaSelecionada.Name));
            new TelaPedidosFRM(selecionada).Show();
            this.Hide();
        }
        private void BtnVoltar2_Click(object sender, EventArgs e)
        {
            Navegacao.voltar(this);
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Navegacao.voltar(this);
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastroProduto(object sender, EventArgs e)
        {
            new TelaCadastroProdutos().Show();
            this.Hide();
        }

        private void entregador(object sender, EventArgs e)
        {
            new TelaEntregador().Show();
            this.Hide();
        }

        private void cadastroMesa(object sender, EventArgs e)
        {
            new TelaMesas().Show();
            this.Hide();
        }

        private void delivery(object sender, EventArgs e)
        {
            new TelaDelivery().Show();
            this.Hide();
        }

        private void cadastroCliente(object sender, EventArgs e)
        {
            new TelaCadastroCliente().Show();
            this.Hide();
        }

        private void TelaDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
