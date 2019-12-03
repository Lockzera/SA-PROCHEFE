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
    public partial class TelaEntregador : Form
    {
        pro_chefeEntities3 bd = new pro_chefeEntities3();
        List<usuario> entregadores = new List<usuario>();
        List<delivery> deliverys = new List<delivery>();
        public static bool entregas = false;
        public static delivery usado;
        public static usuario entregador;
        public static string telaEntregador;
        public TelaEntregador()
        {
            InitializeComponent();
            btnVoltar.Click += voltar;
            entregadores = bd.usuario.ToList();
            btnCadastrar.Click += cadastrar;
            btnDetalhes.Click += detalhes;
            deliverys = bd.delivery.ToList();
            cbxEntregador.Text = "-Selecione ou digite-";
            carregaTbl();
            carregaCbx();
        }

        private void cadastrar(object sender, EventArgs e)
        {
            if (TelaLogin.logado.tipo_usuario == 1)
            {
                new TelaCadastroUsuario(telaEntregador, carregaTbl,carregaCbx).Show();
            }
            else
            {
                MessageBox.Show("Somente admins podem cadastrar!");
            }
        }

        private void detalhes(object sender, EventArgs e)
        {
            int idEntregador = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            bool trabalhando = false;
            deliverys.ForEach(f =>
            {
                if (f.id_entregador == idEntregador && f.processamento == false)
                {
                    trabalhando = true;
                }
            });
            if (trabalhando)
            {
                MessageBox.Show($"Entregador ocupado, está fazendo a(s) entrega(s)");
            }
            else
            {
                MessageBox.Show("Entregador desocupado!");
            }
        }

        private void carregaTbl()
        {
            bd.usuario.ToList().ForEach(u =>
            {
                if (u.tipo_usuario.Equals(3))
                {
                    dataGridView1.Rows.Add(u.id, u.nome);
                }
            });
        }


        private void carregaCbx()
        {
            bd.usuario.ToList().ForEach(u =>
            {
                if (u.tipo_usuario.Equals(3))
                {
                    cbxEntregador.Items.Add(u.nome);
                }
            });
        }

        //private void cbxEntregador_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    bd.usuario.ToList().ForEach(u =>
        //    {
        //        if (cbxEntregador.Text == u.nome && u.tipo_usuario.Equals(3))
        //        {
        //            dataGridView1.Rows.Add(u.id, u.nome);
        //        }
        //    });
        //}
        private void voltar(object sender, EventArgs e)
        {
            Navegacao.voltarDashboard(this);
        }

    }
}
