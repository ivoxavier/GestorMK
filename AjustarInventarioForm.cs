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
    public partial class AjustarInventarioForm : Form
    {
        public AjustarInventarioForm()
        {
            InitializeComponent();

            var repository = new ProdutoRepository();

            dgv_ajInvProdutos.DataSource = repository.ListaProdutosInventario();
        }

        private void btn_ajInvGravar_Click(object sender, EventArgs e)
        {
            var repository = new ProdutoRepository();
            try
            {
                foreach (DataGridViewRow row in dgv_ajInvProdutos.Rows)
                {
                    if (row.IsNewRow) continue;


                    string precoString = Convert.ToString(row.Cells["Preco"].Value);


                    if (string.IsNullOrWhiteSpace(precoString))
                    {
                        MessageBox.Show($"O produto com ID {row.Cells["id"].Value} tem um preço em branco.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    string precoCorrigido = precoString.Replace('.', ',');

                    decimal novoPreco;

                    if (!decimal.TryParse(precoCorrigido, out novoPreco))
                    {

                        MessageBox.Show($"O preço '{precoString}' para o produto com ID {row.Cells["id"].Value} não é um número válido.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }



                    int productID = Convert.ToInt32(row.Cells["id"].Value);
                    int novoStock = Convert.ToInt32(row.Cells["Quantidade"].Value);


                    repository.AjustarStockProduto(productID, novoStock, novoPreco);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            MessageBox.Show("Tabela de produtos atualizada");
        }

        private void dgv_ajInvProdutos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Context.HasFlag(DataGridViewDataErrorContexts.Parsing) ||
        e.Context.HasFlag(DataGridViewDataErrorContexts.Commit))
            {
                
                if (dgv_ajInvProdutos.Columns[e.ColumnIndex].Name == "Preco")
                {
                   
                    MessageBox.Show(
                        "O formato do preço é inválido. Por favor, use a vírgula (,) como separador decimal.",
                        "Erro de Formato",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                   
                    e.ThrowException = false;

                }
            }
        }
    }
}
