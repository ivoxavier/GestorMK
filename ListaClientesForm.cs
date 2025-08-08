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
    public partial class ListaClientesForm : Form
    {

        public int SelectedClientId { get; private set; }

        public ListaClientesForm()
        {
            InitializeComponent();


            var repository = new ClienteRepository();

            dgv_regListaClientes.DataSource = repository.ObterListaCliente();

        }

       
        private void dgv_regListaClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow linhaSelecionada = dgv_regListaClientes.Rows[e.RowIndex];


                object valorId = linhaSelecionada.Cells["Id"].Value;


                this.SelectedClientId = Convert.ToInt32(valorId);


                this.DialogResult = DialogResult.OK;


                this.Close();
            }
        }
    }
}
