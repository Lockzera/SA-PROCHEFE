using Correios.Net;
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
    public partial class TelaCadastroCliente : Form
    {
        pro_chefeEntities3 bd = new pro_chefeEntities3();
        string caminhoFoto;
        public static int idCliente;
        public TelaCadastroCliente()
        {
            InitializeComponent();
            btnSalvar.Click += salvarCliente;
            btnImagem.Click += carregaImagem;
            btnAlterar.Click += alteracao;
            btnBuscarCep.Click += buscarCep;
            btnSalvarAlteracao.Click += salvarAlteracao;
            btnSalvarAlteracao.Visible = false;
            btnVoltar.Click += voltar;
        }


        private void salvarAlteracao(object sender, EventArgs e)
        {
            btnSalvarAlteracao.Visible = false;
            cliente alterar = bd.cliente.Single(u => u.id.Equals(idCliente));
            if (String.IsNullOrWhiteSpace(txtNome.Text) || String.IsNullOrWhiteSpace(txtTelefone.Text.Replace('(', ' ').Replace('-', ' ').Replace(')', ' ')) || String.IsNullOrWhiteSpace(txtCpf.Text) || String.IsNullOrWhiteSpace(txtCep.Text) || String.IsNullOrWhiteSpace(txtLogradouro.Text) || String.IsNullOrWhiteSpace(txtNumero.Text) || String.IsNullOrEmpty(txtBairro.Text) || String.IsNullOrEmpty(txtUf.Text) || String.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show("Alterações não serão salvar porque há campos vazios!");
            }
            else
            {
                alterar.nome = txtNome.Text;
                alterar.telefone = txtTelefone.Text.Replace('(', ' ').Replace('-', ' ').Replace(')', ' ');
                alterar.cpf = txtCpf.Text.Replace('.', ' ').Replace('-', ' ');
                alterar.cep = txtCep.Text.Replace('-', ' ');
                alterar.logradouro = txtLogradouro.Text;
                alterar.numero = txtNumero.Text;
                alterar.complemento = txtComplemento.Text;
                alterar.bairro = txtBairro.Text;
                alterar.uf = txtUf.Text;
                alterar.cidade = txtCidade.Text;
                alterar.imagem = caminhoFoto;
                bd.SaveChanges();
            }
            txtBairro.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtComplemento.Clear();
            txtLogradouro.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtUf.Clear();
            txtBairro.Clear();
            txtCpf.Clear();
            txtNumero.Clear();
            txtCep.Mask = "00000-999";
            txtCpf.Mask = "000,000,000-00";
        }

        private void alteracao(object sender, EventArgs e)
        {

            bool achou = false;
            idCliente = 0;


            bd.cliente.ToList().ForEach(u =>
            {
                if (u.telefone == txtTelefone.Text.Replace('(', ' ').Replace('-', ' ').Replace(')', ' '))
                {
                    achou = true;
                    idCliente = u.id;
                }
            });
            if (achou)
            {
                txtCpf.Mask = "";
                txtCep.Mask = "";
                cliente alterar = bd.cliente.Single(u => u.id.Equals(idCliente));
                txtNome.Text = alterar.nome;
                txtUf.Text = alterar.uf;
                txtLogradouro.Text = alterar.logradouro;
                txtBairro.Text = alterar.bairro;
                txtCep.Text = alterar.cep;
                txtCidade.Text = alterar.cidade;
                txtComplemento.Text = alterar.complemento;
                txtCpf.Text = alterar.cpf;
                btnSalvarAlteracao.Visible = true;
                txtNumero.Text = alterar.numero;
            }
            else
            {
                MessageBox.Show("Número não informado ou incorreto");
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

        private void salvarCliente(object sender, EventArgs e)
        {
            bool telefoneUsado = false;
            bd.cliente.ToList().ForEach(u =>
            {
                if (u.telefone == txtTelefone.Text.Replace('(', ' ').Replace('-', ' ').Replace(')', ' '))
                {
                    telefoneUsado = true;
                }
            });

            if (telefoneUsado == false)
            {

                if (String.IsNullOrWhiteSpace(txtNome.Text) || String.IsNullOrWhiteSpace(txtTelefone.Text.Replace('(', ' ').Replace('-', ' ').Replace(')', ' ')) || String.IsNullOrWhiteSpace(txtCpf.Text) || String.IsNullOrWhiteSpace(txtCep.Text) || String.IsNullOrWhiteSpace(txtLogradouro.Text) || String.IsNullOrWhiteSpace(txtNumero.Text) || String.IsNullOrEmpty(txtBairro.Text) || String.IsNullOrEmpty(txtUf.Text) || String.IsNullOrEmpty(txtCidade.Text))
                {
                    MessageBox.Show("Preencha os campos!");
                }
                else
                {
                    cliente novoCliente = new cliente()
                    {
                        nome = txtNome.Text,
                        telefone = txtTelefone.Text.Replace('(', ' ').Replace('-', ' ').Replace(')', ' '),
                        cpf = txtCpf.Text.Replace('.', ' ').Replace('-', ' '),
                        cep = txtCep.Text.Replace('-', ' '),
                        logradouro = txtLogradouro.Text,
                        numero = txtNumero.Text,
                        complemento = txtComplemento.Text,
                        bairro = txtBairro.Text,
                        uf = txtUf.Text,
                        cidade = txtCidade.Text,
                        imagem = caminhoFoto
                    };
                    bd.cliente.Add(novoCliente);
                    bd.SaveChanges();
                    MessageBox.Show("Salvo com sucesso!");
                    txtBairro.Clear();
                    txtCep.Clear();
                    txtCidade.Clear();
                    txtComplemento.Clear();
                    txtLogradouro.Clear();
                    txtNome.Clear();
                    txtTelefone.Clear();
                    txtUf.Clear();
                    txtBairro.Clear();
                    txtCpf.Clear();
                    txtNumero.Clear();

                }
            }
            else
            {
                MessageBox.Show("Telefone já usado");
            }
        }
        private void buscarCep(object sender, EventArgs e)
        {
            LocalizarCEP();
        }
        private void LocalizarCEP()
        {
            try
            {
                var webService = new WSCorreios.AtendeClienteClient();
                var resposta = webService.consultaCEP(txtCep.Text);
                txtLogradouro.Text = resposta.end;
                txtBairro.Text = resposta.bairro;
                txtCidade.Text = resposta.cidade;
                txtUf.Text = resposta.uf;
            }
            catch (Exception ex)
            {
                txtLogradouro.Text = ex.Message; ;
                txtBairro.Clear();
                txtCidade.Clear();
                txtUf.Clear();
            }
        }

        private void txtCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarCep(sender, e);
            }
        }
        private void voltar(object sender, EventArgs e)
        {
            Navegacao.voltarDashboard(this);
        }

        private void TelaCadastroCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.validarTexto(sender, e);
        }

        private void TxtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.validarNumero(sender, e);
        }

        private void TxtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.validarNumero(sender, e);
        }

        private void TxtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.validarNumero(sender, e);
        }

        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.validarNumero(sender, e);
        }

        private void TxtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.validarTexto(sender, e);
        }

        private void TxtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.validarTexto(sender, e);
        }

        private void TxtUf_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.validarTexto(sender, e);
        }

        private void txtComplemento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarTextbox.validarTexto(sender, e);
        }

    }
}
