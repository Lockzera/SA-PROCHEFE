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
    public partial class produtos : Form
    {
        public produtos()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(@"C:\Users\Aluno\Downloads\semloginpng.png");
            btnCarregarArquivo.Click += carregaFoto;
        }

        private void carregaFoto(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Selecione uma imagem...";
            openFileDialog1.Filter = "png|*.png| jpg|*.jpg| jpeg|*.jpeg";
            openFileDialog1.Title = "Open image file";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }

        }
    }
}
