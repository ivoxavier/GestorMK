namespace GestorMK
{
    partial class AjustarInventarioForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dgv_ajInvProdutos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Preco = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            btn_ajInvGravar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ajInvProdutos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dgv_ajInvProdutos);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(797, 395);
            panel1.TabIndex = 0;
            // 
            // dgv_ajInvProdutos
            // 
            dgv_ajInvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ajInvProdutos.Columns.AddRange(new DataGridViewColumn[] { id, Nome, Categoria, Preco, Quantidade });
            dgv_ajInvProdutos.Dock = DockStyle.Fill;
            dgv_ajInvProdutos.Location = new Point(0, 0);
            dgv_ajInvProdutos.Name = "dgv_ajInvProdutos";
            dgv_ajInvProdutos.Size = new Size(797, 395);
            dgv_ajInvProdutos.TabIndex = 0;
            dgv_ajInvProdutos.DataError += dgv_ajInvProdutos_DataError;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Categoria
            // 
            Categoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Categoria.DataPropertyName = "Categoria";
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // Preco
            // 
            Preco.DataPropertyName = "Preco";
            Preco.HeaderText = "P.V.P";
            Preco.Name = "Preco";
            // 
            // Quantidade
            // 
            Quantidade.DataPropertyName = "Quantidade";
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            // 
            // btn_ajInvGravar
            // 
            btn_ajInvGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_ajInvGravar.Location = new Point(723, 404);
            btn_ajInvGravar.Name = "btn_ajInvGravar";
            btn_ajInvGravar.Size = new Size(77, 46);
            btn_ajInvGravar.TabIndex = 1;
            btn_ajInvGravar.Text = "Gravar";
            btn_ajInvGravar.UseVisualStyleBackColor = true;
            btn_ajInvGravar.Click += btn_ajInvGravar_Click;
            // 
            // AjustarInventarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_ajInvGravar);
            Controls.Add(panel1);
            Name = "AjustarInventarioForm";
            Text = "Ajustar Inventário";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_ajInvProdutos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgv_ajInvProdutos;
        private Button btn_ajInvGravar;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Preco;
        private DataGridViewTextBoxColumn Quantidade;
    }
}