using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;

namespace GestorMK
{
    public class CriaBaseDados
    {

        public void InicializaBD() 
        {

            string caminhoCompletoBD = Path.Combine(Constantes.BdPasta, Constantes.BdNome);

            string ConnectionString = $"Data Source={caminhoCompletoBD}";

            if (!Directory.Exists(Constantes.BdPasta))
            {
                Directory.CreateDirectory(Constantes.BdPasta);
            }
            

            using (var connection = new SqliteConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    var cmd = connection.CreateCommand();

                    cmd.CommandText = @" CREATE TABLE IF NOT EXISTS Clientes (
                    ""id""	INTEGER NOT NULL UNIQUE,
	                ""Nome""	TEXT NOT NULL,
	                ""Morada""	TEXT NOT NULL,
	                ""Email""	TEXT,
	                ""Telemovel""	TEXT,
	                PRIMARY KEY(""id"" AUTOINCREMENT)); 

                    
";

                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"
                            CREATE TABLE IF NOT EXISTS Produtos (
	                                ""id""	INTEGER NOT NULL UNIQUE,
	                                ""Nome""	TEXT NOT NULL,
	                                ""Categoria""	TEXT NOT NULL,
	                                ""Preco""	NUMERIC NOT NULL,
	                                ""MargemLucro""	NUMERIC NOT NULL,
	                                ""Quantidade""	INTEGER NOT NULL,
	                                PRIMARY KEY(""id"" AUTOINCREMENT));

";
                    cmd.ExecuteNonQuery();
                }

                catch (Exception ex) 
                {
                    MessageBox.Show("Erro ao inicializar Base de Dados: " + ex.Message);
                }
            }
        }
    }
}
