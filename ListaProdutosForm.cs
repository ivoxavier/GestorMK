using GestorMK.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorMK
{
    public partial class ListaProdutosForm : Form
    {

        public int SelectedProductId { get; private set; }

        public ListaProdutosForm()
        {
            InitializeComponent();

            var repository = new ProdutoRepository();

            dgv_regListaProdutos.DataSource = repository.ObterListaProdutos();
        }

        private void dgv_regListaProdutos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow linhaSelecionada = dgv_regListaProdutos.Rows[e.RowIndex];


                object valorId = linhaSelecionada.Cells["Id"].Value;


                this.SelectedProductId = Convert.ToInt32(valorId);


                this.DialogResult = DialogResult.OK;


                this.Close();
            }
        }
    }
}
