namespace GestorMK
{
    partial class ListaClientesForm
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
            dgv_regListaClientes = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Morada = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Telemovel = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_regListaClientes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgv_regListaClientes);
            panel1.Location = new Point(4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(530, 220);
            panel1.TabIndex = 0;
            // 
            // dgv_regListaClientes
            // 
            dgv_regListaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_regListaClientes.Columns.AddRange(new DataGridViewColumn[] { id, Nome, Morada, Email, Telemovel });
            dgv_regListaClientes.Dock = DockStyle.Fill;
            dgv_regListaClientes.Location = new Point(0, 0);
            dgv_regListaClientes.Name = "dgv_regListaClientes";
            dgv_regListaClientes.Size = new Size(530, 220);
            dgv_regListaClientes.TabIndex = 0;
           
            dgv_regListaClientes.CellMouseDoubleClick += dgv_regListaClientes_CellMouseDoubleClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "Número Cliente";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 244;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome Cliente";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Morada
            // 
            Morada.DataPropertyName = "Morada";
            Morada.HeaderText = "Morada";
            Morada.Name = "Morada";
            Morada.Visible = false;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.Visible = false;
            // 
            // Telemovel
            // 
            Telemovel.DataPropertyName = "Telemovel";
            Telemovel.HeaderText = "Telemovel";
            Telemovel.Name = "Telemovel";
            Telemovel.Visible = false;
            // 
            // ListaClientesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 224);
            Controls.Add(panel1);
            Name = "ListaClientesForm";
            Text = "Lista de Clientes";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_regListaClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgv_regListaClientes;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Morada;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Telemovel;
    }
}