using FastReport;
using FastReport.Data;
using FastReport.Export.PdfSimple;
using GestorMK.Model; 
using System;
using System.Collections.Generic; 
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GestorMK.Services
{
    public class RelatorioService
    {
        
        public bool ExportarFichaParaPdf(long movimentoId, string connectionString, string nomeFicheiroRelatorio, string caminhoDestinoPdf)
        {
            try
            {
                
                string pastaDaAplicacao = AppDomain.CurrentDomain.BaseDirectory;
                string caminhoCompletoRelatorio = Path.Combine(pastaDaAplicacao, "reports", nomeFicheiroRelatorio);
                if (!File.Exists(caminhoCompletoRelatorio)) { /* ... */ return false; }

                Report report = new Report();
                report.Load(caminhoCompletoRelatorio);

                
                
                report.SetParameterValue("MovimentoID", movimentoId);
                report.SetParameterValue("Conn", connectionString);

                report.Prepare();

                PDFSimpleExport pdfExport = new PDFSimpleExport();
                pdfExport.ShowProgress = false;
                report.Export(pdfExport, caminhoDestinoPdf);

                return true;
            }
            catch (Exception ex)
            {
                
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
    }
}