namespace GestorMK
{
    partial class NovoProdutoForm
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
            lbl_nvProdutoNome = new Label();
            lbl_nvProdutoCategoria = new Label();
            lbl_nvPreco = new Label();
            lbl_nvProdutoQuantidade = new Label();
            txtBox_nvProdutoNome = new TextBox();
            txtBox_nvProdutoPreco = new TextBox();
            txtBox_nvProdutoQuantidade = new TextBox();
            cmb_nvProdutoCategoria = new ComboBox();
            btn_nvProdutoCategoria = new Button();
            btn_nvProdutoAdicionar = new Button();
            SuspendLayout();
            // 
            // lbl_nvProdutoNome
            // 
            lbl_nvProdutoNome.AutoSize = true;
            lbl_nvProdutoNome.Location = new Point(10, 18);
            lbl_nvProdutoNome.Name = "lbl_nvProdutoNome";
            lbl_nvProdutoNome.Size = new Size(40, 15);
            lbl_nvProdutoNome.TabIndex = 0;
            lbl_nvProdutoNome.Text = "Nome";
            // 
            // lbl_nvProdutoCategoria
            // 
            lbl_nvProdutoCategoria.AutoSize = true;
            lbl_nvProdutoCategoria.Location = new Point(10, 52);
            lbl_nvProdutoCategoria.Name = "lbl_nvProdutoCategoria";
            lbl_nvProdutoCategoria.Size = new Size(58, 15);
            lbl_nvProdutoCategoria.TabIndex = 1;
            lbl_nvProdutoCategoria.Text = "Categoria";
            // 
            // lbl_nvPreco
            // 
            lbl_nvPreco.AutoSize = true;
            lbl_nvPreco.Location = new Point(10, 86);
            lbl_nvPreco.Name = "lbl_nvPreco";
            lbl_nvPreco.Size = new Size(51, 15);
            lbl_nvPreco.TabIndex = 2;
            lbl_nvPreco.Text = "Preço(€)";
            // 
            // lbl_nvProdutoQuantidade
            // 
            lbl_nvProdutoQuantidade.AutoSize = true;
            lbl_nvProdutoQuantidade.Location = new Point(10, 127);
            lbl_nvProdutoQuantidade.Name = "lbl_nvProdutoQuantidade";
            lbl_nvProdutoQuantidade.Size = new Size(69, 15);
            lbl_nvProdutoQuantidade.TabIndex = 3;
            lbl_nvProdutoQuantidade.Text = "Quantidade";
            // 
            // txtBox_nvProdutoNome
            // 
            txtBox_nvProdutoNome.Location = new Point(92, 16);
            txtBox_nvProdutoNome.Margin = new Padding(3, 2, 3, 2);
            txtBox_nvProdutoNome.Name = "txtBox_nvProdutoNome";
            txtBox_nvProdutoNome.Size = new Size(308, 23);
            txtBox_nvProdutoNome.TabIndex = 4;
            // 
            // txtBox_nvProdutoPreco
            // 
            txtBox_nvProdutoPreco.Location = new Point(92, 84);
            txtBox_nvProdutoPreco.Margin = new Padding(3, 2, 3, 2);
            txtBox_nvProdutoPreco.Name = "txtBox_nvProdutoPreco";
            txtBox_nvProdutoPreco.Size = new Size(66, 23);
            txtBox_nvProdutoPreco.TabIndex = 5;
            txtBox_nvProdutoPreco.Enter += txtBox_nvProdutoPreco_Enter;
            txtBox_nvProdutoPreco.KeyPress += txtBox_nvProdutoPreco_KeyPress;
            txtBox_nvProdutoPreco.Leave += txtBox_nvProdutoPreco_Leave;
            // 
            // txtBox_nvProdutoQuantidade
            // 
            txtBox_nvProdutoQuantidade.Location = new Point(92, 122);
            txtBox_nvProdutoQuantidade.Margin = new Padding(3, 2, 3, 2);
            txtBox_nvProdutoQuantidade.Name = "txtBox_nvProdutoQuantidade";
            txtBox_nvProdutoQuantidade.Size = new Size(66, 23);
            txtBox_nvProdutoQuantidade.TabIndex = 6;
            txtBox_nvProdutoQuantidade.KeyPress += txtBox_nvProdutoQuantidade_KeyPress;
            // 
            // cmb_nvProdutoCategoria
            // 
            cmb_nvProdutoCategoria.FormattingEnabled = true;
            cmb_nvProdutoCategoria.Location = new Point(92, 49);
            cmb_nvProdutoCategoria.Margin = new Padding(3, 2, 3, 2);
            cmb_nvProdutoCategoria.Name = "cmb_nvProdutoCategoria";
            cmb_nvProdutoCategoria.Size = new Size(166, 23);
            cmb_nvProdutoCategoria.TabIndex = 7;
            // 
            // btn_nvProdutoCategoria
            // 
            btn_nvProdutoCategoria.Location = new Point(272, 49);
            btn_nvProdutoCategoria.Name = "btn_nvProdutoCategoria";
            btn_nvProdutoCategoria.Size = new Size(107, 23);
            btn_nvProdutoCategoria.TabIndex = 8;
            btn_nvProdutoCategoria.Text = "Nova Categoria";
            btn_nvProdutoCategoria.UseVisualStyleBackColor = true;
            btn_nvProdutoCategoria.Click += btn_nvProdutoCategoria_Click;
            // 
            // btn_nvProdutoAdicionar
            // 
            btn_nvProdutoAdicionar.Location = new Point(293, 173);
            btn_nvProdutoAdicionar.Name = "btn_nvProdutoAdicionar";
            btn_nvProdutoAdicionar.Size = new Size(107, 23);
            btn_nvProdutoAdicionar.TabIndex = 9;
            btn_nvProdutoAdicionar.Text = "Adicionar";
            btn_nvProdutoAdicionar.UseVisualStyleBackColor = true;
            btn_nvProdutoAdicionar.Click += btn_nvProdutoAdicionar_Click;
            // 
            // NovoProdutoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 208);
            Controls.Add(btn_nvProdutoAdicionar);
            Controls.Add(btn_nvProdutoCategoria);
            Controls.Add(cmb_nvProdutoCategoria);
            Controls.Add(txtBox_nvProdutoQuantidade);
            Controls.Add(txtBox_nvProdutoPreco);
            Controls.Add(txtBox_nvProdutoNome);
            Controls.Add(lbl_nvProdutoQuantidade);
            Controls.Add(lbl_nvPreco);
            Controls.Add(lbl_nvProdutoCategoria);
            Controls.Add(lbl_nvProdutoNome);
            Margin = new Padding(3, 2, 3, 2);
            Name = "NovoProdutoForm";
            Text = "Novo Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nvProdutoNome;
        private Label lbl_nvProdutoCategoria;
        private Label lbl_nvPreco;
        private Label lbl_nvProdutoQuantidade;
        private TextBox txtBox_nvProdutoNome;
        private TextBox txtBox_nvProdutoPreco;
        private TextBox txtBox_nvProdutoQuantidade;
        private ComboBox cmb_nvProdutoCategoria;
        private Button btn_nvProdutoCategoria;
        private Button btn_nvProdutoAdicionar;
    }
}