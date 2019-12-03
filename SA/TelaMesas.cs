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
    public partial class TelaMesas : Form
    {
        pro_chefeEntities3 bd = new pro_chefeEntities3();
        public static mesa statusMesa;
        public static mesa usando;
        List<mesa> mesas = new List<mesa>();
        public TelaMesas()
        {
            InitializeComponent();
            btnSalvar.Click += cadastrarMesa;
            btnExcluir.Click += excluirMesa;
            btnAlterar.Click += alterar;
            btnSalvarAlteracao.Visible = false;
            btnSalvarAlteracao.Click += salvarAlteracao;
            mesas = bd.mesa.ToList();
            btnVoltar.Click += voltar;
            montarTabela();
        }

        private void salvarAlteracao(object sender, EventArgs e)
        {
            int idMesa = Convert.ToInt32(dgMesa.SelectedRows[0].Cells[0].Value);
            mesa altera = bd.mesa.Single(u => u.id.Equals(idMesa));
            altera.capacidade = Convert.ToInt32(nUP.Value);
            altera.observacao = txtObservacao.Text;
            bd.SaveChanges();
            montarTabela();
            MessageBox.Show("Alterado com sucesso");
            btnSalvarAlteracao.Visible = false;
            nUP.Value = 0;
        }

        private void alterar(object sender, EventArgs e)
        {
            btnSalvarAlteracao.Visible = true;
            int idMesa = Convert.ToInt32(dgMesa.SelectedRows[0].Cells[0].Value);
            mesa altera = bd.mesa.Single(u => u.id.Equals(idMesa));
            nUP.Value = Convert.ToInt32(dgMesa.SelectedRows[0].Cells[1].Value);
            txtObservacao.Text = Convert.ToString(dgMesa.SelectedRows[0].Cells[2].Value);
        }

        private void excluirMesa(object sender, EventArgs e)
        {
            nUP.ResetText();
            int excluirEscolhida = Convert.ToInt32(dgMesa.SelectedRows[0].Cells[0].Value);
            //bool statusMesa = Convert.ToBoolean(dgMesa.SelectedRows[0].Cells[3].Value);
            //statusMesa = bd.pedido.Where(u => u.id_mesa.Equals(excluirEscolhida)).FirstOrDefault();
            usando = bd.mesa.Where(u => u.id.Equals(excluirEscolhida) && u.disponibilidade == true).FirstOrDefault();

            produto excluir = new produto();
            if (usando == null)
            {
                MessageBox.Show("Mesa está sendo usada!");
            }
            else
            {
                var db = bd.mesa.Where(u => u.id.Equals(excluirEscolhida)).FirstOrDefault();
                bd.mesa.Remove(db);
                bd.SaveChanges();
            }
            montarTabela();
            nUP.Value = 0;
        }

        private void cadastrarMesa(object sender, EventArgs e)
        {
            nUP.ResetText();
            if (nUP.Value != 0)
            {
                mesa mesa = new mesa()
                {
                    capacidade = Convert.ToInt32(nUP.Value),
                    disponibilidade = true,
                    observacao = txtObservacao.Text
                };
                txtObservacao.Clear();
                bd.mesa.Add(mesa);
                bd.SaveChanges();
                montarTabela();
            }
            else
            {
                MessageBox.Show("Informe a capacidade!");
            }
            nUP.Value = 0;
        }

        private void montarTabela()
        {
            dgMesa.DataSource = bd.mesa.Select(u => new { u.id, u.capacidade, u.observacao, u.disponibilidade }).ToList();
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            nUP.Maximum = 10;
            nUP.Minimum = 0;
        }

        private void voltar(object sender, EventArgs e)
        {
            Navegacao.voltarDashboard(this);
        }

        private void TelaMesas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TxtObservacao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
