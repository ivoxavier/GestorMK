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
using GestorMK.Model;
using GestorMK.Repository;

namespace GestorMK
{
    public partial class NovoClienteForm : Form
    {
        public NovoClienteForm()
        {
            InitializeComponent();

            ProximoNumeroCliente();

        }

        private void btn_Gravar_Click(object sender, EventArgs e)
        {
            var novoCliente = new Cliente
            {
                Nome = txtBox_nvClienteNome.Text.Trim(),
                Morada = txtBox_nvClienteMorada.Text.Trim(),
                Email = txtBox_nvClienteEmail.Text.Trim(),  
                Telemovel = txtBox_nvClienteTelemovel.Text.Trim()

            };


            

            if(string.IsNullOrWhiteSpace(novoCliente.Nome) || string.IsNullOrWhiteSpace(novoCliente.Morada)) 
            {
                MessageBox.Show("O nome e a morada são campos obrigatórios.",
                                "Erro de Validação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }



            var context = new ValidationContext(novoCliente, null, null);
            var validationResults = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(novoCliente, context, validationResults, true);



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
                var repository = new ClienteRepository();
                repository.Adicionar(novoCliente);

                MessageBox.Show("Cliente gravado com sucesso!",
                                "Sucesso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                
                LimpaCampos();
                ProximoNumeroCliente();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao gravar o cliente: {ex.Message}",
                                "Erro de Base de Dados",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    
    
        private void ProximoNumeroCliente() 
        {
            var repository = new ClienteRepository();

            lbl_nCliente.Text = repository.ObterProximoNumeroCliente().ToString();
        }

        private void LimpaCampos()
        {
            txtBox_nvClienteNome.Text = "";
            txtBox_nvClienteMorada.Text = "";
            txtBox_nvClienteEmail.Text = "";
            txtBox_nvClienteTelemovel.Text = "";

        }    
    }
}
