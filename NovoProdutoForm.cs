using GestorMK.Model;
using GestorMK.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorMK
{
    public partial class NovoProdutoForm : Form
    {
        public NovoProdutoForm()
        {
            InitializeComponent();
            CarregaCategoriasProdutos();
        }




        private void btn_nvProdutoAdicionar_Click(object sender, EventArgs e)
        {

            var repository = new ProdutoRepository();


            bool precoValido = decimal.TryParse(txtBox_nvProdutoPreco.Text, NumberStyles.Currency, new CultureInfo("pt-PT"), out decimal preco);


            if (string.IsNullOrWhiteSpace(txtBox_nvProdutoNome.Text))
            {
                MessageBox.Show("O nome do produto não pode estar vazio.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!precoValido || preco < 0)
            {
                MessageBox.Show("O preço inserido não é válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var novoProduto = new Produto
            {
                Nome = txtBox_nvProdutoNome.Text.Trim(),
                Categoria = cmb_nvProdutoCategoria.Text.Trim(),
                Preco = preco,
                Quantidade = Convert.ToInt32(txtBox_nvProdutoQuantidade.Text.Trim())
            };


            repository.AdicionarProduto(novoProduto);


            MessageBox.Show("Produto adicionado com sucesso!");

            LimpaCampos();
        }



        private void btn_nvProdutoCategoria_Click(object sender, EventArgs e)
        {

            using (NovoCategoria novoCategoria = new NovoCategoria())
            {

                DialogResult resultado = novoCategoria.ShowDialog();

                if (resultado == DialogResult.OK)
                {

                    CarregaCategoriasProdutos();
                }
            }
        }



        private void CarregaCategoriasProdutos()
        {
            var repository = new ProdutoRepository();

            var listaCategorias = repository.ObterCategorias();

            cmb_nvProdutoCategoria.DataSource = listaCategorias;


            //mostar
            cmb_nvProdutoCategoria.DisplayMember = "Categoria";
        }

        private void txtBox_nvProdutoPreco_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtBox_nvProdutoPreco_Leave(object sender, EventArgs e)
        {

            if (decimal.TryParse(txtBox_nvProdutoPreco.Text, out decimal valor))
            {

                txtBox_nvProdutoPreco.Text = valor.ToString("C", new CultureInfo("pt-PT"));
            }
            else
            {

                txtBox_nvProdutoPreco.Text = 0m.ToString("C", new CultureInfo("pt-PT"));
            }
        }

        private void txtBox_nvProdutoPreco_Enter(object sender, EventArgs e)
        {

            if (decimal.TryParse(txtBox_nvProdutoPreco.Text, NumberStyles.Currency, new CultureInfo("pt-PT"), out decimal valor))
            {
                txtBox_nvProdutoPreco.Text = valor.ToString();
            }
        }

        private void txtBox_nvProdutoQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
               
                e.Handled = true;
            }
        }


        private void LimpaCampos()
        {
            txtBox_nvProdutoNome.Text = "";
            txtBox_nvProdutoPreco.Text = "";
            txtBox_nvProdutoQuantidade.Text = "";
        }
    }
}
