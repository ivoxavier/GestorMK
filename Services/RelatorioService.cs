// --- Adicione TODAS estas diretivas 'using' no topo do seu ficheiro ---
using FastReport;
using FastReport.Data;
using FastReport.Export.PdfSimple; 
using System;
using System.IO;
using System.Linq; 
using System.Text; 
using System.Windows.Forms;


namespace GestorMK.Services // (ou o namespace que estiver a usar)
{
 
    public class RelatorioService
    {
       
        public bool ExportarFichaParaPdf(long movimentoId, string connectionString, string nomeFicheiroRelatorio, string caminhoDestinoPdf)
        {
            try
            {
                
                string pastaDaAplicacao = AppDomain.CurrentDomain.BaseDirectory;
                string caminhoCompletoRelatorio = Path.Combine(pastaDaAplicacao, "reports", nomeFicheiroRelatorio);

                if (!File.Exists(caminhoCompletoRelatorio))
                {
                    MessageBox.Show($"O ficheiro do relatório não foi encontrado no caminho esperado:\n{caminhoCompletoRelatorio}", "Ficheiro Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

           
                Report report = new Report();
                report.Load(caminhoCompletoRelatorio);

              
                SQLiteDataConnection connection = null;

               
                foreach (DataConnectionBase conn_base in report.Dictionary.Connections)
                {
                    
                    if (conn_base.Name.Equals("Connection", StringComparison.OrdinalIgnoreCase))
                    {
                        connection = conn_base as SQLiteDataConnection;
                        break; // Sai do loop assim que encontrar
                    }
                }

                if (connection != null)
                {
                    // Se encontrou, define a connection string
                    connection.ConnectionString = connectionString;
                }
                else
                {
                    // Se não encontrou, avisa o utilizador e pára a execução
                    MessageBox.Show("A conexão de dados com o nome 'Connection' não foi encontrada no relatório ou não é do tipo SQLite.", "Erro de Configuração", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // 4. DEFINIR PARÂMETROS DO RELATÓRIO
                report.SetParameterValue("MovimentoID", movimentoId);

                // 5. PREPARAR O RELATÓRIO E EXPORTAR PARA PDF
                report.Prepare();

                PDFSimpleExport pdfExport = new PDFSimpleExport();
                pdfExport.ShowProgress = false; // Não mostrar a pequena janela de "Exporting..."

                report.Export(pdfExport, caminhoDestinoPdf);

                // 6. SUCESSO
                return true;
            }
            catch (Exception ex)
            {
                // 7. TRATAMENTO DE ERROS
                // Constrói uma mensagem de erro detalhada, incluindo exceções internas
                StringBuilder errorMessage = new StringBuilder();
                errorMessage.AppendLine("Ocorreu um erro inesperado ao exportar o relatório para PDF:");
                errorMessage.AppendLine(ex.Message);

                if (ex.InnerException != null)
                {
                    errorMessage.AppendLine("\nDetalhes Internos (InnerException):");
                    errorMessage.AppendLine(ex.InnerException.Message);
                }

                MessageBox.Show(errorMessage.ToString(), "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    } // Fim da classe RelatorioService
}