using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

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

                    cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Clientes (
                    ""id""   INTEGER PRIMARY KEY AUTOINCREMENT,
                    ""Nome""   TEXT NOT NULL,
                    ""Morada"" TEXT NOT NULL,
                    ""Email""   TEXT,
                    ""Telemovel"" TEXT);";

                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"
                            CREATE TABLE IF NOT EXISTS Produtos (
                            ""id""    INTEGER PRIMARY KEY AUTOINCREMENT,
                            ""Nome""  TEXT NOT NULL,
                            ""Categoria""   TEXT NOT NULL,
                            ""Preco""       NUMERIC NOT NULL,
                            ""Quantidade""  INTEGER NOT NULL);";

                    cmd.ExecuteNonQuery();


                    cmd.CommandText = @"
                            CREATE TABLE IF NOT EXISTS CategoriasProdutos (
                            ""id""  INTEGER PRIMARY KEY AUTOINCREMENT,
                            ""Categoria"" TEXT NOT NULL UNIQUE);

   
                         INSERT OR IGNORE INTO CategoriasProdutos (Categoria)
                         VALUES
                         ('Cuidados do Rosto'),
                         ('Maquilhagem'),
                         ('Corpo e Sol'),
                         ('Fragâncias'),
                        ('Desconhecido');";

                    cmd.ExecuteNonQuery();



                    cmd.CommandText = @"
                         CREATE TABLE IF NOT EXISTS Movimentos (
                        ""id"" INTEGER PRIMARY KEY AUTOINCREMENT,
                        ""ClienteID"" INTEGER NOT NULL,
                        ""DataCriacao"" TEXT NOT NULL DEFAULT CURRENT_DATE);";

                    cmd.ExecuteNonQuery();



                    cmd.CommandText = @"
                        CREATE TABLE IF NOT EXISTS MovimentosItens (
                        ""id"" INTEGER PRIMARY KEY AUTOINCREMENT,
                        ""idMovimento"" INTEGER NOT NULL,
                        ""idProduto"" INTEGER NOT NULL,
                        ""Preco"" NUMERIC NOT NULL,
                        ""Quantidade"" INTEGER NOT NULL,
                        ""Tipo"" INTEGER NOT NULL);";

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
