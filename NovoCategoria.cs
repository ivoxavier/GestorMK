using GestorMK.Model;
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

namespace GestorMK
{
    public partial class NovoCategoria : Form
    {
        public NovoCategoria()
        {
            InitializeComponent();
        }

        private void btn_nvCategoriasProdutosAdicionar_Click(object sender, EventArgs e)
        {
            var categoriaProduto = new CategoriaProduto
            {
                Categoria = txtBox_nvCategoriasProdutos.Text.Trim()
            };

            if (string.IsNullOrWhiteSpace(txtBox_nvCategoriasProdutos.Text))
            {
                MessageBox.Show("A categoria é um campo obrigatório.",
                                "Erro de Validação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            var context = new ValidationContext(categoriaProduto, null, null);
            var validationResults = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(categoriaProduto, context, validationResults, true);

            if (!isValid)
            {
                var errorBuilder = new StringBuilder();
                foreach (var validationResult in validationResults)
                {
                    errorBuilder.AppendLine(validationResult.ErrorMessage);
                }

                MessageBox.Show(errorBuilder.ToString(),
                                "Erro de Validação",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            try
            {
                var repository = new ProdutoRepository();
                repository.AdicionarNovaCategoriaProduto(categoriaProduto);

                MessageBox.Show("Categoria gravada com sucesso!",
                                "Sucesso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                LimpaCampos();

               this.DialogResult = DialogResult.OK;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao gravar a categoria: {ex.Message}",
                               "Erro de Base de Dados",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        private void LimpaCampos()
        {
            txtBox_nvCategoriasProdutos.Text = "";
        }
    }
}
