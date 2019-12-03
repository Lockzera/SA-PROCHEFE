namespace SA
{
    partial class TelaCadastroProdutos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroProdutos));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPagePordutos = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCarregarArquivo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.clbIngredientes = new System.Windows.Forms.CheckedListBox();
            this.btnCadastrarCategoria = new System.Windows.Forms.Button();
            this.btnVoltarProdutos = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnExcluirProdutos = new System.Windows.Forms.Button();
            this.btnSalvarProdutos = new System.Windows.Forms.Button();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnSalvarAlteracao = new System.Windows.Forms.Button();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAlterarIngrediente = new System.Windows.Forms.Button();
            this.btnVoltarIngrediente = new System.Windows.Forms.Button();
            this.btnExcluirIngrediente = new System.Windows.Forms.Button();
            this.btnSalvarIngrediente = new System.Windows.Forms.Button();
            this.btnSalvarAlteracao2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.dgIngrediente = new System.Windows.Forms.DataGridView();
            this.txtNomeIngrediente = new System.Windows.Forms.TextBox();
            this.nUpQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl.SuspendLayout();
            this.tabPagePordutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIngrediente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPagePordutos);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(-3, -1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1022, 535);
            this.tabControl.TabIndex = 0;
            // 
            // tabPagePordutos
            // 
            this.tabPagePordutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.tabPagePordutos.Controls.Add(this.label1);
            this.tabPagePordutos.Controls.Add(this.btnCarregarArquivo);
            this.tabPagePordutos.Controls.Add(this.label3);
            this.tabPagePordutos.Controls.Add(this.label10);
            this.tabPagePordutos.Controls.Add(this.label9);
            this.tabPagePordutos.Controls.Add(this.label7);
            this.tabPagePordutos.Controls.Add(this.label6);
            this.tabPagePordutos.Controls.Add(this.btnAlterar);
            this.tabPagePordutos.Controls.Add(this.label12);
            this.tabPagePordutos.Controls.Add(this.clbIngredientes);
            this.tabPagePordutos.Controls.Add(this.btnCadastrarCategoria);
            this.tabPagePordutos.Controls.Add(this.btnVoltarProdutos);
            this.tabPagePordutos.Controls.Add(this.label17);
            this.tabPagePordutos.Controls.Add(this.txtValor);
            this.tabPagePordutos.Controls.Add(this.btnExcluirProdutos);
            this.tabPagePordutos.Controls.Add(this.btnSalvarProdutos);
            this.tabPagePordutos.Controls.Add(this.cbxCategoria);
            this.tabPagePordutos.Controls.Add(this.label18);
            this.tabPagePordutos.Controls.Add(this.txtDescricao);
            this.tabPagePordutos.Controls.Add(this.label19);
            this.tabPagePordutos.Controls.Add(this.txtNome);
            this.tabPagePordutos.Controls.Add(this.label20);
            this.tabPagePordutos.Controls.Add(this.btnSalvarAlteracao);
            this.tabPagePordutos.Controls.Add(this.dgProdutos);
            this.tabPagePordutos.Controls.Add(this.pbImagem);
            this.tabPagePordutos.Location = new System.Drawing.Point(4, 22);
            this.tabPagePordutos.Name = "tabPagePordutos";
            this.tabPagePordutos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePordutos.Size = new System.Drawing.Size(1014, 509);
            this.tabPagePordutos.TabIndex = 0;
            this.tabPagePordutos.Text = "Produtos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "Carregar Arquivo";
            // 
            // btnCarregarArquivo
            // 
            this.btnCarregarArquivo.BackColor = System.Drawing.Color.Transparent;
            this.btnCarregarArquivo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCarregarArquivo.BackgroundImage")));
            this.btnCarregarArquivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarregarArquivo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnCarregarArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregarArquivo.Location = new System.Drawing.Point(51, 164);
            this.btnCarregarArquivo.Name = "btnCarregarArquivo";
            this.btnCarregarArquivo.Size = new System.Drawing.Size(79, 54);
            this.btnCarregarArquivo.TabIndex = 63;
            this.btnCarregarArquivo.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(522, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 35);
            this.label3.TabIndex = 62;
            this.label3.Text = "Produtos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(780, 488);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 61;
            this.label10.Text = "Excluir";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(861, 488);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 60;
            this.label9.Text = "Salvar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(944, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 59;
            this.label7.Text = "Voltar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(693, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 58;
            this.label6.Text = "Alterar";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterar.BackgroundImage")));
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Location = new System.Drawing.Point(690, 431);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 54);
            this.btnAlterar.TabIndex = 56;
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(199, 358);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 16);
            this.label12.TabIndex = 55;
            this.label12.Text = "Ingredientes";
            // 
            // clbIngredientes
            // 
            this.clbIngredientes.BackColor = System.Drawing.Color.LightSlateGray;
            this.clbIngredientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbIngredientes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.clbIngredientes.FormattingEnabled = true;
            this.clbIngredientes.Location = new System.Drawing.Point(202, 383);
            this.clbIngredientes.Name = "clbIngredientes";
            this.clbIngredientes.Size = new System.Drawing.Size(156, 92);
            this.clbIngredientes.TabIndex = 54;
            this.clbIngredientes.Click += new System.EventHandler(this.clbIngredientes_Click);
            // 
            // btnCadastrarCategoria
            // 
            this.btnCadastrarCategoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastrarCategoria.BackgroundImage")));
            this.btnCadastrarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrarCategoria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnCadastrarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCategoria.Location = new System.Drawing.Point(383, 222);
            this.btnCadastrarCategoria.Name = "btnCadastrarCategoria";
            this.btnCadastrarCategoria.Size = new System.Drawing.Size(44, 43);
            this.btnCadastrarCategoria.TabIndex = 46;
            this.btnCadastrarCategoria.UseVisualStyleBackColor = true;
            // 
            // btnVoltarProdutos
            // 
            this.btnVoltarProdutos.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltarProdutos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltarProdutos.BackgroundImage")));
            this.btnVoltarProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltarProdutos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnVoltarProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarProdutos.Location = new System.Drawing.Point(933, 430);
            this.btnVoltarProdutos.Name = "btnVoltarProdutos";
            this.btnVoltarProdutos.Size = new System.Drawing.Size(75, 54);
            this.btnVoltarProdutos.TabIndex = 47;
            this.btnVoltarProdutos.UseVisualStyleBackColor = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(199, 290);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 16);
            this.label17.TabIndex = 51;
            this.label17.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtValor.Location = new System.Drawing.Point(202, 312);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(156, 23);
            this.txtValor.TabIndex = 45;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // btnExcluirProdutos
            // 
            this.btnExcluirProdutos.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirProdutos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluirProdutos.BackgroundImage")));
            this.btnExcluirProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluirProdutos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnExcluirProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirProdutos.Location = new System.Drawing.Point(771, 431);
            this.btnExcluirProdutos.Name = "btnExcluirProdutos";
            this.btnExcluirProdutos.Size = new System.Drawing.Size(75, 54);
            this.btnExcluirProdutos.TabIndex = 50;
            this.btnExcluirProdutos.UseVisualStyleBackColor = false;
            // 
            // btnSalvarProdutos
            // 
            this.btnSalvarProdutos.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarProdutos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvarProdutos.BackgroundImage")));
            this.btnSalvarProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvarProdutos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnSalvarProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarProdutos.Location = new System.Drawing.Point(852, 431);
            this.btnSalvarProdutos.Name = "btnSalvarProdutos";
            this.btnSalvarProdutos.Size = new System.Drawing.Size(75, 54);
            this.btnSalvarProdutos.TabIndex = 49;
            this.btnSalvarProdutos.UseVisualStyleBackColor = false;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.BackColor = System.Drawing.Color.LightSlateGray;
            this.cbxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(202, 240);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(153, 25);
            this.cbxCategoria.TabIndex = 43;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(199, 215);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(164, 16);
            this.label18.TabIndex = 52;
            this.label18.Text = "Categoria do cardápio";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDescricao.Location = new System.Drawing.Point(202, 116);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(242, 77);
            this.txtDescricao.TabIndex = 42;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(199, 91);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(166, 16);
            this.label19.TabIndex = 48;
            this.label19.Text = "Descrição do cardápio";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNome.Location = new System.Drawing.Point(202, 48);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(153, 23);
            this.txtNome.TabIndex = 41;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(199, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 16);
            this.label20.TabIndex = 44;
            this.label20.Text = "Nome";
            // 
            // btnSalvarAlteracao
            // 
            this.btnSalvarAlteracao.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvarAlteracao.FlatAppearance.BorderSize = 2;
            this.btnSalvarAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarAlteracao.ForeColor = System.Drawing.Color.White;
            this.btnSalvarAlteracao.Location = new System.Drawing.Point(690, 381);
            this.btnSalvarAlteracao.Name = "btnSalvarAlteracao";
            this.btnSalvarAlteracao.Size = new System.Drawing.Size(75, 44);
            this.btnSalvarAlteracao.TabIndex = 37;
            this.btnSalvarAlteracao.Text = "Salvar alteração";
            this.btnSalvarAlteracao.UseVisualStyleBackColor = true;
            // 
            // dgProdutos
            // 
            this.dgProdutos.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.categoria,
            this.preco,
            this.descricao});
            this.dgProdutos.Location = new System.Drawing.Point(504, 50);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProdutos.Size = new System.Drawing.Size(504, 309);
            this.dgProdutos.TabIndex = 36;
            // 
            // id
            // 
            this.id.FillWeight = 60F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 60;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            // 
            // preco
            // 
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            // 
            // pbImagem
            // 
            this.pbImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagem.Image = ((System.Drawing.Image)(resources.GetObject("pbImagem.Image")));
            this.pbImagem.Location = new System.Drawing.Point(29, 25);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(132, 115);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagem.TabIndex = 0;
            this.pbImagem.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.btnAlterarIngrediente);
            this.tabPage1.Controls.Add(this.btnVoltarIngrediente);
            this.tabPage1.Controls.Add(this.btnExcluirIngrediente);
            this.tabPage1.Controls.Add(this.btnSalvarIngrediente);
            this.tabPage1.Controls.Add(this.btnSalvarAlteracao2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cbxUnidadeMedida);
            this.tabPage1.Controls.Add(this.dgIngrediente);
            this.tabPage1.Controls.Add(this.txtNomeIngrediente);
            this.tabPage1.Controls.Add(this.nUpQuantidade);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1014, 509);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Ingredientes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(784, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 72;
            this.label4.Text = "Excluir";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(865, 482);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 71;
            this.label8.Text = "Salvar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(948, 482);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 70;
            this.label11.Text = "Voltar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(697, 482);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 16);
            this.label13.TabIndex = 69;
            this.label13.Text = "Alterar";
            // 
            // btnAlterarIngrediente
            // 
            this.btnAlterarIngrediente.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterarIngrediente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterarIngrediente.BackgroundImage")));
            this.btnAlterarIngrediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterarIngrediente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnAlterarIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarIngrediente.Location = new System.Drawing.Point(694, 425);
            this.btnAlterarIngrediente.Name = "btnAlterarIngrediente";
            this.btnAlterarIngrediente.Size = new System.Drawing.Size(75, 54);
            this.btnAlterarIngrediente.TabIndex = 68;
            this.btnAlterarIngrediente.UseVisualStyleBackColor = false;
            // 
            // btnVoltarIngrediente
            // 
            this.btnVoltarIngrediente.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltarIngrediente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltarIngrediente.BackgroundImage")));
            this.btnVoltarIngrediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltarIngrediente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnVoltarIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarIngrediente.Location = new System.Drawing.Point(937, 424);
            this.btnVoltarIngrediente.Name = "btnVoltarIngrediente";
            this.btnVoltarIngrediente.Size = new System.Drawing.Size(75, 54);
            this.btnVoltarIngrediente.TabIndex = 65;
            this.btnVoltarIngrediente.UseVisualStyleBackColor = false;
            // 
            // btnExcluirIngrediente
            // 
            this.btnExcluirIngrediente.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirIngrediente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluirIngrediente.BackgroundImage")));
            this.btnExcluirIngrediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluirIngrediente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnExcluirIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirIngrediente.Location = new System.Drawing.Point(775, 425);
            this.btnExcluirIngrediente.Name = "btnExcluirIngrediente";
            this.btnExcluirIngrediente.Size = new System.Drawing.Size(75, 54);
            this.btnExcluirIngrediente.TabIndex = 67;
            this.btnExcluirIngrediente.UseVisualStyleBackColor = false;
            // 
            // btnSalvarIngrediente
            // 
            this.btnSalvarIngrediente.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarIngrediente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvarIngrediente.BackgroundImage")));
            this.btnSalvarIngrediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvarIngrediente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.btnSalvarIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarIngrediente.Location = new System.Drawing.Point(856, 425);
            this.btnSalvarIngrediente.Name = "btnSalvarIngrediente";
            this.btnSalvarIngrediente.Size = new System.Drawing.Size(75, 54);
            this.btnSalvarIngrediente.TabIndex = 66;
            this.btnSalvarIngrediente.UseVisualStyleBackColor = false;
            // 
            // btnSalvarAlteracao2
            // 
            this.btnSalvarAlteracao2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvarAlteracao2.FlatAppearance.BorderSize = 2;
            this.btnSalvarAlteracao2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarAlteracao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarAlteracao2.ForeColor = System.Drawing.Color.White;
            this.btnSalvarAlteracao2.Location = new System.Drawing.Point(694, 375);
            this.btnSalvarAlteracao2.Name = "btnSalvarAlteracao2";
            this.btnSalvarAlteracao2.Size = new System.Drawing.Size(75, 44);
            this.btnSalvarAlteracao2.TabIndex = 64;
            this.btnSalvarAlteracao2.Text = "Salvar alteração";
            this.btnSalvarAlteracao2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 35);
            this.label2.TabIndex = 63;
            this.label2.Text = "Detalhes do Ingrediente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(78, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 16);
            this.label5.TabIndex = 47;
            this.label5.Text = "Unidade de medida";
            // 
            // cbxUnidadeMedida
            // 
            this.cbxUnidadeMedida.BackColor = System.Drawing.Color.LightSlateGray;
            this.cbxUnidadeMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxUnidadeMedida.FormattingEnabled = true;
            this.cbxUnidadeMedida.Location = new System.Drawing.Point(233, 240);
            this.cbxUnidadeMedida.Name = "cbxUnidadeMedida";
            this.cbxUnidadeMedida.Size = new System.Drawing.Size(121, 21);
            this.cbxUnidadeMedida.TabIndex = 46;
            // 
            // dgIngrediente
            // 
            this.dgIngrediente.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgIngrediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIngrediente.Location = new System.Drawing.Point(410, 48);
            this.dgIngrediente.Name = "dgIngrediente";
            this.dgIngrediente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgIngrediente.Size = new System.Drawing.Size(540, 277);
            this.dgIngrediente.TabIndex = 45;
            // 
            // txtNomeIngrediente
            // 
            this.txtNomeIngrediente.BackColor = System.Drawing.Color.LightSlateGray;
            this.txtNomeIngrediente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeIngrediente.Location = new System.Drawing.Point(233, 133);
            this.txtNomeIngrediente.Name = "txtNomeIngrediente";
            this.txtNomeIngrediente.Size = new System.Drawing.Size(120, 20);
            this.txtNomeIngrediente.TabIndex = 43;
            // 
            // nUpQuantidade
            // 
            this.nUpQuantidade.BackColor = System.Drawing.Color.LightSlateGray;
            this.nUpQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nUpQuantidade.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpQuantidade.Location = new System.Drawing.Point(233, 186);
            this.nUpQuantidade.Name = "nUpQuantidade";
            this.nUpQuantidade.Size = new System.Drawing.Size(120, 22);
            this.nUpQuantidade.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(129, 188);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 16);
            this.label16.TabIndex = 38;
            this.label16.Text = "Quantidade";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(130, 135);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 16);
            this.label15.TabIndex = 37;
            this.label15.Text = "Ingrediente";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TelaCadastroProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1015, 527);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCadastroProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cadastro Produto e Ingrediente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaCadastroProdutos_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabPagePordutos.ResumeLayout(false);
            this.tabPagePordutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIngrediente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpQuantidade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPagePordutos;
        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgIngrediente;
        private System.Windows.Forms.TextBox txtNomeIngrediente;
        private System.Windows.Forms.NumericUpDown nUpQuantidade;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.Button btnSalvarAlteracao;
        private System.Windows.Forms.ComboBox cbxUnidadeMedida;
        private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		protected internal System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnAlterar;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.CheckedListBox clbIngredientes;
		private System.Windows.Forms.Button btnCadastrarCategoria;
		private System.Windows.Forms.Button btnVoltarProdutos;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtValor;
		private System.Windows.Forms.Button btnExcluirProdutos;
		private System.Windows.Forms.Button btnSalvarProdutos;
		private System.Windows.Forms.ComboBox cbxCategoria;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox txtDescricao;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCarregarArquivo;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        protected internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAlterarIngrediente;
        private System.Windows.Forms.Button btnVoltarIngrediente;
        private System.Windows.Forms.Button btnExcluirIngrediente;
        private System.Windows.Forms.Button btnSalvarIngrediente;
        private System.Windows.Forms.Button btnSalvarAlteracao2;
    }
}

