using GestorMK.Model;
using GestorMK.Properties;
using GestorMK.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastReport.Data;
using FastReport;
namespace GestorMK
{
    public partial class RegistarForm : Form
    {

        private BindingList<MovimentosItens> itensDaFicha;

        public RegistarForm()
        {
            InitializeComponent();


            itensDaFicha = new BindingList<MovimentosItens>();
            itensDaFicha.ListChanged += ItensDaFicha_ListChanged;
            dgv_rgMovimentos.DataSource = itensDaFicha;


            if (Settings.Default.isFirstUsage)
            {

                var bd = new CriaBaseDados();
                bd.InicializaBD();

                Settings.Default.isFirstUsage = false;
                Settings.Default.Save();
            }

            PrepararNovaFicha();

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


            if (string.IsNullOrWhiteSpace(txtBox_nCliente.Text) || string.IsNullOrWhiteSpace(txtBox_nProduto.Text))
            {
                MessageBox.Show("Adicionar cliente e produto");
                return;
            }


            //bloqueia o cliente ate a ficha ser fechada
            txtBox_nCliente.Enabled = false;


            var repository = new MovimentosRepository();
            var productRepository = new ProdutoRepository();


            int clientID = Convert.ToInt32(txtBox_nCliente.Text);
            int produtcID = Convert.ToInt32(txtBox_nProduto.Text);
            int fichaID = Convert.ToInt32(txtBox_nFicha.Text);

            // 0 Venda  1 Emprestimo 2 Oferta
            int tipoSelected = rdb_regVenda.Checked ? 0 : rdb_regEmprestimo.Checked ? 1 : 2;



            var novoItem = new MovimentosItens
            {
                IdProduto = produtcID,
                IdMovimento = fichaID,
                TipoID = tipoSelected,
                Preco = productRepository.ObterPrecoProduto(produtcID),
                Quantidade = 1,
                NomeProduto = productRepository.ObterNomeProduto(produtcID),
                TipoDescricao = tipoSelected == 0 ? "Venda" : tipoSelected == 1 ? "Empréstimo" : "Oferta"
            };

            itensDaFicha.Add(novoItem);



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

        private void btn_regFecharFicha_Click(object sender, EventArgs e)
        {
            int clientID = Convert.ToInt32(txtBox_nCliente.Text);
            int tipoSelected = rdb_regVenda.Checked ? 0 : 1;
            int produtcID = Convert.ToInt32(txtBox_nProduto.Text);


            if (itensDaFicha.Count == 0)
            {
                MessageBox.Show("É necessário adicionar pelo menos um item antes de fechar a ficha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var produtoRepository = new ProdutoRepository();

            foreach (MovimentosItens item in itensDaFicha)
            {

                int stockDisponivel = produtoRepository.ObterStockProduto(item.IdProduto);


                if (item.Quantidade > stockDisponivel)
                {

                    MessageBox.Show(
                        $"Stock insuficiente para o produto '{item.NomeProduto}'.\n\n" +
                        $"Quantidade Pedida: {item.Quantidade}\n" +
                        $"Stock Disponível: {stockDisponivel}",
                        "Stock Insuficiente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }
            }


            var movimentosRepository = new MovimentosRepository();



            var movimentoCab = new Movimentos
            {
                Tipo = tipoSelected,
                ClientID = clientID,
                ProdutoID = produtcID

            };

            long novoFichaID = movimentosRepository.AdicionarMovimento(movimentoCab);

            if (novoFichaID <= 0)
            {
                MessageBox.Show("Ocorreu um erro ao criar o registo principal da ficha.", "Erro de Base de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (MovimentosItens item in itensDaFicha)
            {
                item.IdMovimento = Convert.ToInt32(novoFichaID);
                movimentosRepository.AdicionarMovimentoItem(item);

                int stockAtual = produtoRepository.ObterStockProduto(item.IdProduto);
                int novoStock = stockAtual - item.Quantidade;
                produtoRepository.AtualizarStockProduto(item.IdProduto, novoStock);
            }


            DialogResult querGuardarPdf = MessageBox.Show("Ficha gravada com sucesso.\nDeseja guardar o relatório em PDF?",
                                                        "Gravar Relatório", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (querGuardarPdf == DialogResult.Yes)
            {

                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "Ficheiro PDF (*.pdf)|*.pdf";
                    saveDialog.Title = "Gravar Ficha como PDF";
                    saveDialog.FileName = $"Ficha_{novoFichaID}.pdf";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {

                        var servicoDeRelatorios = new GestorMK.Services.RelatorioService();
                        string minhaConnectionString = MovimentosRepository.ConnectionString;
                        string nomeDoFicheiroRelatorio = "Ficha.frx";
                        string caminhoParaGravar = saveDialog.FileName;

                        bool sucesso = servicoDeRelatorios.ExportarFichaParaPdf(novoFichaID, minhaConnectionString, nomeDoFicheiroRelatorio, caminhoParaGravar);

                        if (sucesso)
                        {
                            MessageBox.Show("Relatório guardado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }


            PrepararNovaFicha();
        }


        private void PrepararNovaFicha()
        {
            var repository = new MovimentosRepository();
            txtBox_nFicha.Text = repository.ObterProximoNumeroFicha().ToString();


            LimpaCampos();
            itensDaFicha.Clear();
            txtBox_nCliente.Enabled = true;
        }

        private void ajustarInventárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjustarInventarioForm ajustarInventario = new AjustarInventarioForm();

            ajustarInventario.ShowDialog();
        }

        private void AtualizarTotais()
        {

            
            decimal totalPVP = itensDaFicha.Sum(item => item.Preco * item.Quantidade);

       
            int totalUnidades = itensDaFicha.Sum(item => item.Quantidade);

           
            lbl_valuePVP.Text = totalPVP.ToString("C");

          

        }

        private void ItensDaFicha_ListChanged(object sender, ListChangedEventArgs e)
        {

            AtualizarTotais();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult querGuardarPdf = MessageBox.Show("Deseja gerar o relatório em PDF?",
                                                        "Gerar Relatório", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (querGuardarPdf == DialogResult.Yes)
            {

                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    string carimboDoTempo = DateTime.Now.ToString("yyyy_MM_dd_HHmm");
                    saveDialog.Filter = "Ficheiro PDF (*.pdf)|*.pdf";
                    saveDialog.Title = "Gravar como PDF";
                    saveDialog.FileName = $"ListagemVendas_{carimboDoTempo}.pdf";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {

                        var servicoDeRelatorios = new GestorMK.Services.RelatorioService();
                        string minhaConnectionString = MovimentosRepository.ConnectionString;
                        string nomeDoFicheiroRelatorio = "ListagemVendas.frx";
                        string caminhoParaGravar = saveDialog.FileName;

                        bool sucesso = servicoDeRelatorios.ExportarListagemParaPDF(minhaConnectionString, nomeDoFicheiroRelatorio, caminhoParaGravar);

                        if (sucesso)
                        {
                            MessageBox.Show("Relatório guardado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void acercaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaForm acerca = new AcercaForm();

            acerca.ShowDialog();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult querGuardarPdf = MessageBox.Show("Deseja gerar o relatório em PDF?",
                                                       "Gerar Relatório", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (querGuardarPdf == DialogResult.Yes)
            {

                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    string carimboDoTempo = DateTime.Now.ToString("yyyy_MM_dd_HHmm");
                    saveDialog.Filter = "Ficheiro PDF (*.pdf)|*.pdf";
                    saveDialog.Title = "Gravar como PDF";
                    saveDialog.FileName = $"ListagemOfertas_{carimboDoTempo}.pdf";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {

                        var servicoDeRelatorios = new GestorMK.Services.RelatorioService();
                        string minhaConnectionString = MovimentosRepository.ConnectionString;
                        string nomeDoFicheiroRelatorio = "ListagemOfertas.frx";
                        string caminhoParaGravar = saveDialog.FileName;

                        bool sucesso = servicoDeRelatorios.ExportarListagemParaPDF(minhaConnectionString, nomeDoFicheiroRelatorio, caminhoParaGravar);

                        if (sucesso)
                        {
                            MessageBox.Show("Relatório guardado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void empréstimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult querGuardarPdf = MessageBox.Show("Deseja gerar o relatório em PDF?",
                                                       "Gerar Relatório", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (querGuardarPdf == DialogResult.Yes)
            {

                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    string carimboDoTempo = DateTime.Now.ToString("yyyy_MM_dd_HHmm");
                    saveDialog.Filter = "Ficheiro PDF (*.pdf)|*.pdf";
                    saveDialog.Title = "Gravar como PDF";
                    saveDialog.FileName = $"ListagemEmprestimos_{carimboDoTempo}.pdf";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {

                        var servicoDeRelatorios = new GestorMK.Services.RelatorioService();
                        string minhaConnectionString = MovimentosRepository.ConnectionString;
                        string nomeDoFicheiroRelatorio = "ListagemEmprestimos.frx";
                        string caminhoParaGravar = saveDialog.FileName;

                        bool sucesso = servicoDeRelatorios.ExportarListagemParaPDF(minhaConnectionString, nomeDoFicheiroRelatorio, caminhoParaGravar);

                        if (sucesso)
                        {
                            MessageBox.Show("Relatório guardado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
    }


}
