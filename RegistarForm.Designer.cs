namespace GestorMK
{
    partial class RegistarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistarForm));
            menuStrip1 = new MenuStrip();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            novoClienteToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            novoProdutoToolStripMenuItem = new ToolStripMenuItem();
            ajustarInventárioToolStripMenuItem = new ToolStripMenuItem();
            listagensToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem1 = new ToolStripMenuItem();
            produtosToolStripMenuItem1 = new ToolStripMenuItem();
            empréstimosToolStripMenuItem = new ToolStripMenuItem();
            acercaToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            dgv_rgMovimentos = new DataGridView();
            TipoID = new DataGridViewTextBoxColumn();
            idMovimento = new DataGridViewTextBoxColumn();
            TipoDescricao = new DataGridViewTextBoxColumn();
            NomeProduto = new DataGridViewTextBoxColumn();
            Produto = new DataGridViewTextBoxColumn();
            idProduto = new DataGridViewTextBoxColumn();
            Preco = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            btn_regFecharFicha = new Button();
            txtBox_nCliente = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtBox_produto = new TextBox();
            txtBox_cliente = new TextBox();
            txtBox_nProduto = new TextBox();
            groupBox1 = new GroupBox();
            rdb_regOferta = new RadioButton();
            rdb_regEmprestimo = new RadioButton();
            rdb_regVenda = new RadioButton();
            btn_regAdicionar = new Button();
            txtBox_nFicha = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lbl_nLabel = new Label();
            lbl_valuePVP = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_rgMovimentos).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, produtosToolStripMenuItem, listagensToolStripMenuItem, acercaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(933, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoClienteToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(61, 20);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // novoClienteToolStripMenuItem
            // 
            novoClienteToolStripMenuItem.Name = "novoClienteToolStripMenuItem";
            novoClienteToolStripMenuItem.Size = new Size(143, 22);
            novoClienteToolStripMenuItem.Text = "Novo Cliente";
            novoClienteToolStripMenuItem.Click += novoClienteToolStripMenuItem_Click;
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoProdutoToolStripMenuItem, ajustarInventárioToolStripMenuItem });
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(67, 20);
            produtosToolStripMenuItem.Text = "Produtos";
            // 
            // novoProdutoToolStripMenuItem
            // 
            novoProdutoToolStripMenuItem.Name = "novoProdutoToolStripMenuItem";
            novoProdutoToolStripMenuItem.Size = new Size(167, 22);
            novoProdutoToolStripMenuItem.Text = "Novo Produto";
            novoProdutoToolStripMenuItem.Click += novoProdutoToolStripMenuItem_Click;
            // 
            // ajustarInventárioToolStripMenuItem
            // 
            ajustarInventárioToolStripMenuItem.Name = "ajustarInventárioToolStripMenuItem";
            ajustarInventárioToolStripMenuItem.Size = new Size(167, 22);
            ajustarInventárioToolStripMenuItem.Text = "Ajustar Inventário";
            ajustarInventárioToolStripMenuItem.Click += ajustarInventárioToolStripMenuItem_Click;
            // 
            // listagensToolStripMenuItem
            // 
            listagensToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem1, produtosToolStripMenuItem1, empréstimosToolStripMenuItem });
            listagensToolStripMenuItem.Name = "listagensToolStripMenuItem";
            listagensToolStripMenuItem.Size = new Size(68, 20);
            listagensToolStripMenuItem.Text = "Listagens";
            // 
            // clientesToolStripMenuItem1
            // 
            clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            clientesToolStripMenuItem1.Size = new Size(180, 22);
            clientesToolStripMenuItem1.Text = "Vendas";
            clientesToolStripMenuItem1.Click += clientesToolStripMenuItem1_Click;
            // 
            // produtosToolStripMenuItem1
            // 
            produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            produtosToolStripMenuItem1.Size = new Size(180, 22);
            produtosToolStripMenuItem1.Text = "Ofertas";
            produtosToolStripMenuItem1.Click += produtosToolStripMenuItem1_Click;
            // 
            // empréstimosToolStripMenuItem
            // 
            empréstimosToolStripMenuItem.Name = "empréstimosToolStripMenuItem";
            empréstimosToolStripMenuItem.Size = new Size(180, 22);
            empréstimosToolStripMenuItem.Text = "Empréstimos";
            empréstimosToolStripMenuItem.Click += empréstimosToolStripMenuItem_Click;
            // 
            // acercaToolStripMenuItem
            // 
            acercaToolStripMenuItem.Name = "acercaToolStripMenuItem";
            acercaToolStripMenuItem.Size = new Size(55, 20);
            acercaToolStripMenuItem.Text = "Acerca";
            acercaToolStripMenuItem.Click += acercaToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dgv_rgMovimentos);
            panel1.Location = new Point(14, 163);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(905, 270);
            panel1.TabIndex = 1;
            // 
            // dgv_rgMovimentos
            // 
            dgv_rgMovimentos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_rgMovimentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_rgMovimentos.Columns.AddRange(new DataGridViewColumn[] { TipoID, idMovimento, TipoDescricao, NomeProduto, Produto, idProduto, Preco, Quantidade });
            dgv_rgMovimentos.Location = new Point(0, 0);
            dgv_rgMovimentos.Margin = new Padding(4, 3, 4, 3);
            dgv_rgMovimentos.Name = "dgv_rgMovimentos";
            dgv_rgMovimentos.RowHeadersWidth = 51;
            dgv_rgMovimentos.Size = new Size(905, 270);
            dgv_rgMovimentos.TabIndex = 0;
            // 
            // TipoID
            // 
            TipoID.DataPropertyName = "TipoID";
            TipoID.HeaderText = "TipoID";
            TipoID.Name = "TipoID";
            TipoID.Visible = false;
            // 
            // idMovimento
            // 
            idMovimento.DataPropertyName = "idMovimento";
            idMovimento.HeaderText = "Ficha";
            idMovimento.Name = "idMovimento";
            idMovimento.ReadOnly = true;
            // 
            // TipoDescricao
            // 
            TipoDescricao.DataPropertyName = "TipoDescricao";
            TipoDescricao.HeaderText = "Tipo Descricao";
            TipoDescricao.Name = "TipoDescricao";
            // 
            // NomeProduto
            // 
            NomeProduto.DataPropertyName = "NomeProduto";
            NomeProduto.HeaderText = "NomeProduto";
            NomeProduto.Name = "NomeProduto";
            // 
            // Produto
            // 
            Produto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Produto.DataPropertyName = "Produto";
            Produto.HeaderText = "Produto";
            Produto.Name = "Produto";
            Produto.ReadOnly = true;
            Produto.Visible = false;
            // 
            // idProduto
            // 
            idProduto.DataPropertyName = "idProduto";
            idProduto.HeaderText = "idProduto";
            idProduto.Name = "idProduto";
            idProduto.Visible = false;
            // 
            // Preco
            // 
            Preco.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Preco.DataPropertyName = "Preco";
            Preco.HeaderText = "P.V.P";
            Preco.Name = "Preco";
            Preco.Width = 59;
            // 
            // Quantidade
            // 
            Quantidade.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Quantidade.DataPropertyName = "Quantidade";
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            // 
            // btn_regFecharFicha
            // 
            btn_regFecharFicha.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_regFecharFicha.Location = new Point(845, 466);
            btn_regFecharFicha.Margin = new Padding(4, 3, 4, 3);
            btn_regFecharFicha.Name = "btn_regFecharFicha";
            btn_regFecharFicha.Size = new Size(88, 50);
            btn_regFecharFicha.TabIndex = 2;
            btn_regFecharFicha.Text = "Fechar Ficha";
            btn_regFecharFicha.UseVisualStyleBackColor = true;
            btn_regFecharFicha.Click += btn_regFecharFicha_Click;
            // 
            // txtBox_nCliente
            // 
            txtBox_nCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBox_nCliente.Location = new Point(80, 3);
            txtBox_nCliente.Margin = new Padding(4, 3, 4, 3);
            txtBox_nCliente.Name = "txtBox_nCliente";
            txtBox_nCliente.Size = new Size(66, 23);
            txtBox_nCliente.TabIndex = 3;
            txtBox_nCliente.TextChanged += txtBox_nCliente_TextChanged;
            txtBox_nCliente.KeyPress += txtBox_nCliente_KeyPress;
            txtBox_nCliente.MouseDoubleClick += txtBox_nCliente_MouseDoubleClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(4, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 4;
            label1.Text = "N. Cliente";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(4, 41);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 5;
            label2.Text = "N.Produto";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.73529F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.26471F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 169F));
            tableLayoutPanel1.Controls.Add(txtBox_produto, 2, 1);
            tableLayoutPanel1.Controls.Add(txtBox_cliente, 2, 0);
            tableLayoutPanel1.Controls.Add(txtBox_nProduto, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtBox_nCliente, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Location = new Point(14, 38);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.Size = new Size(320, 65);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // txtBox_produto
            // 
            txtBox_produto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBox_produto.Location = new Point(154, 35);
            txtBox_produto.Margin = new Padding(4, 3, 4, 3);
            txtBox_produto.Name = "txtBox_produto";
            txtBox_produto.ReadOnly = true;
            txtBox_produto.Size = new Size(162, 23);
            txtBox_produto.TabIndex = 8;
            // 
            // txtBox_cliente
            // 
            txtBox_cliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBox_cliente.Location = new Point(154, 3);
            txtBox_cliente.Margin = new Padding(4, 3, 4, 3);
            txtBox_cliente.Name = "txtBox_cliente";
            txtBox_cliente.ReadOnly = true;
            txtBox_cliente.Size = new Size(162, 23);
            txtBox_cliente.TabIndex = 7;
            // 
            // txtBox_nProduto
            // 
            txtBox_nProduto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBox_nProduto.Location = new Point(80, 35);
            txtBox_nProduto.Margin = new Padding(4, 3, 4, 3);
            txtBox_nProduto.Name = "txtBox_nProduto";
            txtBox_nProduto.Size = new Size(66, 23);
            txtBox_nProduto.TabIndex = 7;
            txtBox_nProduto.TextChanged += txtBox_nProduto_TextChanged;
            txtBox_nProduto.KeyPress += txtBox_nProduto_KeyPress;
            txtBox_nProduto.MouseDoubleClick += txtBox_nProduto_MouseDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdb_regOferta);
            groupBox1.Controls.Add(rdb_regEmprestimo);
            groupBox1.Controls.Add(rdb_regVenda);
            groupBox1.Location = new Point(14, 107);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(252, 52);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo";
            // 
            // rdb_regOferta
            // 
            rdb_regOferta.AutoSize = true;
            rdb_regOferta.Location = new Point(190, 22);
            rdb_regOferta.Name = "rdb_regOferta";
            rdb_regOferta.Size = new Size(58, 19);
            rdb_regOferta.TabIndex = 10;
            rdb_regOferta.TabStop = true;
            rdb_regOferta.Text = "Oferta";
            rdb_regOferta.UseVisualStyleBackColor = true;
            // 
            // rdb_regEmprestimo
            // 
            rdb_regEmprestimo.AutoSize = true;
            rdb_regEmprestimo.Location = new Point(84, 22);
            rdb_regEmprestimo.Margin = new Padding(4, 3, 4, 3);
            rdb_regEmprestimo.Name = "rdb_regEmprestimo";
            rdb_regEmprestimo.Size = new Size(89, 19);
            rdb_regEmprestimo.TabIndex = 9;
            rdb_regEmprestimo.Text = "Emprestimo";
            rdb_regEmprestimo.UseVisualStyleBackColor = true;
            // 
            // rdb_regVenda
            // 
            rdb_regVenda.AutoSize = true;
            rdb_regVenda.Checked = true;
            rdb_regVenda.Location = new Point(7, 22);
            rdb_regVenda.Margin = new Padding(4, 3, 4, 3);
            rdb_regVenda.Name = "rdb_regVenda";
            rdb_regVenda.Size = new Size(57, 19);
            rdb_regVenda.TabIndex = 8;
            rdb_regVenda.TabStop = true;
            rdb_regVenda.Text = "Venda";
            rdb_regVenda.UseVisualStyleBackColor = true;
            // 
            // btn_regAdicionar
            // 
            btn_regAdicionar.Dock = DockStyle.Left;
            btn_regAdicionar.Location = new Point(0, 0);
            btn_regAdicionar.Margin = new Padding(4, 3, 4, 3);
            btn_regAdicionar.Name = "btn_regAdicionar";
            btn_regAdicionar.Size = new Size(72, 38);
            btn_regAdicionar.TabIndex = 8;
            btn_regAdicionar.Text = "Adicionar";
            btn_regAdicionar.UseVisualStyleBackColor = true;
            btn_regAdicionar.Click += btn_regAdicionar_Click;
            // 
            // txtBox_nFicha
            // 
            txtBox_nFicha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBox_nFicha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtBox_nFicha.Location = new Point(832, 97);
            txtBox_nFicha.Margin = new Padding(4, 3, 4, 3);
            txtBox_nFicha.Name = "txtBox_nFicha";
            txtBox_nFicha.ReadOnly = true;
            txtBox_nFicha.Size = new Size(82, 23);
            txtBox_nFicha.TabIndex = 10;
            txtBox_nFicha.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(774, 107);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 11;
            label3.Text = "N. Ficha";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(792, 36);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(121, 22);
            label4.TabIndex = 12;
            label4.Text = "GESTORMK";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(835, 61);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 13;
            label5.Text = "por: Ivo Xavier";
            // 
            // lbl_nLabel
            // 
            lbl_nLabel.AutoSize = true;
            lbl_nLabel.Dock = DockStyle.Left;
            lbl_nLabel.Location = new Point(0, 0);
            lbl_nLabel.Name = "lbl_nLabel";
            lbl_nLabel.Size = new Size(59, 15);
            lbl_nLabel.TabIndex = 14;
            lbl_nLabel.Text = "Total PVP:";
            // 
            // lbl_valuePVP
            // 
            lbl_valuePVP.Anchor = AnchorStyles.Left;
            lbl_valuePVP.AutoSize = true;
            lbl_valuePVP.Location = new Point(66, 0);
            lbl_valuePVP.Name = "lbl_valuePVP";
            lbl_valuePVP.Size = new Size(0, 15);
            lbl_valuePVP.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.Controls.Add(lbl_nLabel);
            panel2.Controls.Add(lbl_valuePVP);
            panel2.Location = new Point(14, 439);
            panel2.Name = "panel2";
            panel2.Size = new Size(209, 77);
            panel2.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_regAdicionar);
            panel3.Location = new Point(273, 119);
            panel3.Name = "panel3";
            panel3.Size = new Size(187, 38);
            panel3.TabIndex = 18;
            // 
            // RegistarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtBox_nFicha);
            Controls.Add(groupBox1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btn_regFecharFicha);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Disable;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "RegistarForm";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_rgMovimentos).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoClienteToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_regFecharFicha;
        private System.Windows.Forms.TextBox txtBox_nCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtBox_nProduto;
        private System.Windows.Forms.TextBox txtBox_cliente;
        private System.Windows.Forms.TextBox txtBox_produto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_regEmprestimo;
        private System.Windows.Forms.RadioButton rdb_regVenda;
        private System.Windows.Forms.Button btn_regAdicionar;
        private System.Windows.Forms.DataGridView dgv_rgMovimentos;
        private System.Windows.Forms.TextBox txtBox_nFicha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private ToolStripMenuItem listagensToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem1;
        private ToolStripMenuItem produtosToolStripMenuItem1;
        private ToolStripMenuItem novoProdutoToolStripMenuItem;
        private ToolStripMenuItem ajustarInventárioToolStripMenuItem;
        private DataGridViewTextBoxColumn TipoID;
        private DataGridViewTextBoxColumn idMovimento;
        private DataGridViewTextBoxColumn TipoDescricao;
        private DataGridViewTextBoxColumn NomeProduto;
        private DataGridViewTextBoxColumn Produto;
        private DataGridViewTextBoxColumn idProduto;
        private DataGridViewTextBoxColumn Preco;
        private DataGridViewTextBoxColumn Quantidade;
        private RadioButton rdb_regOferta;
        private Label lbl_nLabel;
        private Label lbl_valuePVP;
        private ToolStripMenuItem empréstimosToolStripMenuItem;
        private Panel panel2;
        private Panel panel3;
        private ToolStripMenuItem acercaToolStripMenuItem;
    }
}

