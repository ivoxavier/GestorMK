namespace GestorMK
{
    partial class NovoClienteForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            txtBox_nvClienteNome = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtBox_nvClienteMorada = new TextBox();
            txtBox_nvClienteEmail = new TextBox();
            txtBox_nvClienteTelemovel = new TextBox();
            btn_Gravar = new Button();
            label5 = new Label();
            lbl_nCliente = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.92391F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.07609F));
            tableLayoutPanel1.Controls.Add(txtBox_nvClienteNome, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtBox_nvClienteMorada, 1, 1);
            tableLayoutPanel1.Controls.Add(txtBox_nvClienteEmail, 1, 2);
            tableLayoutPanel1.Controls.Add(txtBox_nvClienteTelemovel, 1, 3);
            tableLayoutPanel1.Location = new Point(14, 14);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 39.13044F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60.86956F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new Size(429, 165);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtBox_nvClienteNome
            // 
            txtBox_nvClienteNome.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBox_nvClienteNome.Location = new Point(93, 4);
            txtBox_nvClienteNome.Margin = new Padding(4, 3, 4, 3);
            txtBox_nvClienteNome.Name = "txtBox_nvClienteNome";
            txtBox_nvClienteNome.Size = new Size(332, 23);
            txtBox_nvClienteNome.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(4, 139);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 1;
            label4.Text = "Telemovel";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(4, 97);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 1;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(4, 49);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Morada";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(4, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // txtBox_nvClienteMorada
            // 
            txtBox_nvClienteMorada.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBox_nvClienteMorada.Location = new Point(93, 45);
            txtBox_nvClienteMorada.Margin = new Padding(4, 3, 4, 3);
            txtBox_nvClienteMorada.Name = "txtBox_nvClienteMorada";
            txtBox_nvClienteMorada.Size = new Size(332, 23);
            txtBox_nvClienteMorada.TabIndex = 2;
            // 
            // txtBox_nvClienteEmail
            // 
            txtBox_nvClienteEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBox_nvClienteEmail.Location = new Point(93, 93);
            txtBox_nvClienteEmail.Margin = new Padding(4, 3, 4, 3);
            txtBox_nvClienteEmail.Name = "txtBox_nvClienteEmail";
            txtBox_nvClienteEmail.Size = new Size(332, 23);
            txtBox_nvClienteEmail.TabIndex = 3;
            // 
            // txtBox_nvClienteTelemovel
            // 
            txtBox_nvClienteTelemovel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBox_nvClienteTelemovel.Location = new Point(93, 135);
            txtBox_nvClienteTelemovel.Margin = new Padding(4, 3, 4, 3);
            txtBox_nvClienteTelemovel.Name = "txtBox_nvClienteTelemovel";
            txtBox_nvClienteTelemovel.Size = new Size(332, 23);
            txtBox_nvClienteTelemovel.TabIndex = 4;
            // 
            // btn_Gravar
            // 
            btn_Gravar.Location = new Point(356, 267);
            btn_Gravar.Margin = new Padding(4, 3, 4, 3);
            btn_Gravar.Name = "btn_Gravar";
            btn_Gravar.Size = new Size(88, 45);
            btn_Gravar.TabIndex = 1;
            btn_Gravar.Text = "Gravar";
            btn_Gravar.UseVisualStyleBackColor = true;
            btn_Gravar.Click += btn_Gravar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 182);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 2;
            label5.Text = "N. Cliente:";
            // 
            // lbl_nCliente
            // 
            lbl_nCliente.AutoSize = true;
            lbl_nCliente.Location = new Point(86, 182);
            lbl_nCliente.Margin = new Padding(4, 0, 4, 0);
            lbl_nCliente.Name = "lbl_nCliente";
            lbl_nCliente.Size = new Size(19, 15);
            lbl_nCliente.TabIndex = 3;
            lbl_nCliente.Text = "33";
            // 
            // NovoClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 325);
            Controls.Add(lbl_nCliente);
            Controls.Add(label5);
            Controls.Add(btn_Gravar);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "NovoClienteForm";
            Text = "NovoCliente";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_nvClienteNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_nvClienteMorada;
        private System.Windows.Forms.TextBox txtBox_nvClienteEmail;
        private System.Windows.Forms.TextBox txtBox_nvClienteTelemovel;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_nCliente;
    }
}