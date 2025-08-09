using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestorMK.Model;
using GestorMK.Properties;
using GestorMK.Repository;

namespace GestorMK
{
    public partial class RegistarForm : Form
    {

        private BindingList<MovimentosItens> itensDaFicha;

        public RegistarForm()
        {
            InitializeComponent();

            var bdd = new CriaBaseDados();
            bdd.InicializaBD();

            itensDaFicha = new BindingList<MovimentosItens>();
            dgv_rgMovimentos.DataSource = itensDaFicha;

          


            var repository = new MovimentosRepository();
            txtBox_nFicha.Text = repository.ObterProximoNumeroFicha().ToString();

            if (Settings.Default.isFirstUsage)
            {
                var bd = new CriaBaseDados();
                bd.InicializaBD();

                Settings.Default.isFirstUsage = false;

            }

            

        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoClienteForm novoCliente = new NovoClienteForm();

            novoCliente.ShowDialog();

        }

        private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoProdutoForm novoProduto = new NovoProdutoForm();

            novoProduto.ShowDialog();
        }

        private void txtBox_nCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
        }


        private void txtBox_nProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
        }

        private void txtBox_nCliente_TextChanged(object sender, EventArgs e)
        {
            var clienteRepository = new ClienteRepository();

            int clientID = 0;


            if (!string.IsNullOrWhiteSpace(txtBox_nCliente.Text))
            {
                clientID = Convert.ToInt32(txtBox_nCliente.Text);
                txtBox_cliente.Text = clienteRepository.ObterNomeCliente(clientID);
            }
            else
            {
                txtBox_cliente.Text = "";
            }

        }

        private void txtBox_nProduto_TextChanged(object sender, EventArgs e)
        {
            var produtoRepository = new ProdutoRepository();

            int productID = 0;


            if (!string.IsNullOrWhiteSpace(txtBox_nProduto.Text))
            {
                productID = Convert.ToInt32(txtBox_nProduto.Text);
                txtBox_produto.Text = produtoRepository.ObterNomeProduto(productID);
            }
            else
            {
                txtBox_produto.Text = "";
            }
        }

        private void txtBox_nCliente_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            using (ListaClientesForm listaClientes = new ListaClientesForm())
            {

                DialogResult resultado = listaClientes.ShowDialog();


                if (resultado == DialogResult.OK)
                {

                    txtBox_nCliente.Text = listaClientes.SelectedClientId.ToString();
                }
            }
        }

        private void txtBox_nProduto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (ListaProdutosForm listaProdutosForm = new ListaProdutosForm())
            {
                DialogResult resultado = listaProdutosForm.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    txtBox_nProduto.Text = listaProdutosForm.SelectedProductId.ToString();
                }

            }
        }

        private void btn_regAdicionar_Click(object sender, EventArgs e)
        {

            var repository = new MovimentosRepository();
            var productRepository = new ProdutoRepository();


            int clientID = Convert.ToInt32(txtBox_nCliente.Text);
            int produtcID = Convert.ToInt32(txtBox_nProduto.Text);
            int fichaID = Convert.ToInt32(txtBox_nFicha.Text);

            // 0 Venda  1 Emprestimo
            int tipoSelected = rdb_regVenda.Checked ? 0 : 1;



            var movimentoCab = new Movimentos
            { 
                Tipo = tipoSelected,
                ClientID = clientID,
                ProdutoID = produtcID
            };

            var novoItem = new MovimentosItens
            {
                IdMovimento = fichaID,
                Tipo = tipoSelected,
                Preco = productRepository.ObterPrecoProduto(produtcID),
                Quantidade = 1,
                NomeProduto = productRepository.ObterNomeProduto(produtcID)
            };

            itensDaFicha.Add(novoItem);


            


            repository.AdicionarMovimento(movimentoCab, novoItem, fichaID);

            LimpaCampos();

        }


        private void LimpaCampos()
        {
            txtBox_nCliente.Text = "";
            txtBox_cliente.Text = "";
            txtBox_nProduto.Text = "";
            txtBox_produto.Text = "";
            rdb_regVenda.Checked = true;
            rdb_regEmprestimo.Checked = false;


        }

    }
}
