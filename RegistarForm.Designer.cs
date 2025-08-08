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
            menuStrip1 = new MenuStrip();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            novoClienteToolStripMenuItem = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            listagensToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem1 = new ToolStripMenuItem();
            produtosToolStripMenuItem1 = new ToolStripMenuItem();
            manutençaoToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            txtBox_nCliente = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtBox_produto = new TextBox();
            txtBox_cliente = new TextBox();
            txtBox_nProduto = new TextBox();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button2 = new Button();
            txtBox_nFicha = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            novoProdutoToolStripMenuItem = new ToolStripMenuItem();
            ajustarInventárioToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, produtosToolStripMenuItem, listagensToolStripMenuItem, manutençaoToolStripMenuItem });
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
            // listagensToolStripMenuItem
            // 
            listagensToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem1, produtosToolStripMenuItem1 });
            listagensToolStripMenuItem.Name = "listagensToolStripMenuItem";
            listagensToolStripMenuItem.Size = new Size(68, 20);
            listagensToolStripMenuItem.Text = "Listagens";
            // 
            // clientesToolStripMenuItem1
            // 
            clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            clientesToolStripMenuItem1.Size = new Size(122, 22);
            clientesToolStripMenuItem1.Text = "Clientes";
            // 
            // produtosToolStripMenuItem1
            // 
            produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            produtosToolStripMenuItem1.Size = new Size(122, 22);
            produtosToolStripMenuItem1.Text = "Produtos";
            // 
            // manutençaoToolStripMenuItem
            // 
            manutençaoToolStripMenuItem.Name = "manutençaoToolStripMenuItem";
            manutençaoToolStripMenuItem.Size = new Size(86, 20);
            manutençaoToolStripMenuItem.Text = "Manutenção";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(14, 163);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(905, 270);
            panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(7, 3);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(895, 263);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(832, 456);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(88, 50);
            button1.TabIndex = 2;
            button1.Text = "Fechar Ficha";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtBox_nCliente
            // 
            txtBox_nCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBox_nCliente.Location = new Point(81, 3);
            txtBox_nCliente.Margin = new Padding(4, 3, 4, 3);
            txtBox_nCliente.Name = "txtBox_nCliente";
            txtBox_nCliente.Size = new Size(67, 23);
            txtBox_nCliente.TabIndex = 3;
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 167F));
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
            txtBox_produto.Location = new Point(156, 35);
            txtBox_produto.Margin = new Padding(4, 3, 4, 3);
            txtBox_produto.Name = "txtBox_produto";
            txtBox_produto.ReadOnly = true;
            txtBox_produto.Size = new Size(160, 23);
            txtBox_produto.TabIndex = 8;
            // 
            // txtBox_cliente
            // 
            txtBox_cliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBox_cliente.Location = new Point(156, 3);
            txtBox_cliente.Margin = new Padding(4, 3, 4, 3);
            txtBox_cliente.Name = "txtBox_cliente";
            txtBox_cliente.ReadOnly = true;
            txtBox_cliente.Size = new Size(160, 23);
            txtBox_cliente.TabIndex = 7;
            // 
            // txtBox_nProduto
            // 
            txtBox_nProduto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBox_nProduto.Location = new Point(81, 35);
            txtBox_nProduto.Margin = new Padding(4, 3, 4, 3);
            txtBox_nProduto.Name = "txtBox_nProduto";
            txtBox_nProduto.Size = new Size(67, 23);
            txtBox_nProduto.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(14, 107);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(316, 52);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(84, 22);
            radioButton2.Margin = new Padding(4, 3, 4, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(89, 19);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Emprestimo";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(7, 22);
            radioButton1.Margin = new Padding(4, 3, 4, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(57, 19);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Venda";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(337, 129);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(88, 27);
            button2.TabIndex = 8;
            button2.Text = "Adicionar";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtBox_nFicha
            // 
            txtBox_nFicha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBox_nFicha.Location = new Point(798, 97);
            txtBox_nFicha.Margin = new Padding(4, 3, 4, 3);
            txtBox_nFicha.Name = "txtBox_nFicha";
            txtBox_nFicha.ReadOnly = true;
            txtBox_nFicha.Size = new Size(116, 23);
            txtBox_nFicha.TabIndex = 10;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(736, 100);
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
            // novoProdutoToolStripMenuItem
            // 
            novoProdutoToolStripMenuItem.Name = "novoProdutoToolStripMenuItem";
            novoProdutoToolStripMenuItem.Size = new Size(180, 22);
            novoProdutoToolStripMenuItem.Text = "Novo Produto";
            // 
            // ajustarInventárioToolStripMenuItem
            // 
            ajustarInventárioToolStripMenuItem.Name = "ajustarInventárioToolStripMenuItem";
            ajustarInventárioToolStripMenuItem.Size = new Size(180, 22);
            ajustarInventárioToolStripMenuItem.Text = "Ajustar Inventário";
            // 
            // RegistarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtBox_nFicha);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            ImeMode = ImeMode.Disable;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "RegistarForm";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoClienteToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBox_nCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtBox_nProduto;
        private System.Windows.Forms.TextBox txtBox_cliente;
        private System.Windows.Forms.TextBox txtBox_produto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBox_nFicha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private ToolStripMenuItem listagensToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem1;
        private ToolStripMenuItem produtosToolStripMenuItem1;
        private ToolStripMenuItem novoProdutoToolStripMenuItem;
        private ToolStripMenuItem ajustarInventárioToolStripMenuItem;
    }
}

