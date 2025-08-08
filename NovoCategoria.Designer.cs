namespace GestorMK
{
    partial class NovoCategoria
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
            lbl_nvCategoriasProdutos = new Label();
            txtBox_nvCategoriasProdutos = new TextBox();
            btn_nvCategoriasProdutosAdicionar = new Button();
            SuspendLayout();
            // 
            // lbl_nvCategoriasProdutos
            // 
            lbl_nvCategoriasProdutos.AutoSize = true;
            lbl_nvCategoriasProdutos.Location = new Point(12, 26);
            lbl_nvCategoriasProdutos.Name = "lbl_nvCategoriasProdutos";
            lbl_nvCategoriasProdutos.Size = new Size(58, 15);
            lbl_nvCategoriasProdutos.TabIndex = 0;
            lbl_nvCategoriasProdutos.Text = "Categoria";
            // 
            // txtBox_nvCategoriasProdutos
            // 
            txtBox_nvCategoriasProdutos.Location = new Point(95, 23);
            txtBox_nvCategoriasProdutos.Name = "txtBox_nvCategoriasProdutos";
            txtBox_nvCategoriasProdutos.Size = new Size(157, 23);
            txtBox_nvCategoriasProdutos.TabIndex = 1;
            // 
            // btn_nvCategoriasProdutosAdicionar
            // 
            btn_nvCategoriasProdutosAdicionar.Location = new Point(95, 71);
            btn_nvCategoriasProdutosAdicionar.Name = "btn_nvCategoriasProdutosAdicionar";
            btn_nvCategoriasProdutosAdicionar.Size = new Size(75, 23);
            btn_nvCategoriasProdutosAdicionar.TabIndex = 2;
            btn_nvCategoriasProdutosAdicionar.Text = "Adicionar";
            btn_nvCategoriasProdutosAdicionar.UseVisualStyleBackColor = true;
            btn_nvCategoriasProdutosAdicionar.Click += btn_nvCategoriasProdutosAdicionar_Click;
            // 
            // NovoCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 131);
            Controls.Add(btn_nvCategoriasProdutosAdicionar);
            Controls.Add(txtBox_nvCategoriasProdutos);
            Controls.Add(lbl_nvCategoriasProdutos);
            Name = "NovoCategoria";
            Text = "Nova Categoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nvCategoriasProdutos;
        private TextBox txtBox_nvCategoriasProdutos;
        private Button btn_nvCategoriasProdutosAdicionar;
    }
}