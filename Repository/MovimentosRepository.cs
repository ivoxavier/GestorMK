using GestorMK.Model;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorMK.Repository
{
    public class MovimentosRepository
    {
        public static string caminhoCompletoBD = Path.Combine(Constantes.BdPasta, Constantes.BdNome);
        public static string ConnectionString = $"Data Source={caminhoCompletoBD}";

        public MovimentosRepository()
        {
            
            string? directoryPath = Path.GetDirectoryName(ConnectionString.Split('=')[1]);
            if (!string.IsNullOrEmpty(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }

        
        public long AdicionarMovimento(Movimentos movimentoCab)
        {
            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
              
                command.CommandText = @"
                    INSERT INTO Movimentos (ClienteID)
                    VALUES ($clientid);
                    SELECT last_insert_rowid();";

                command.Parameters.AddWithValue("$clientid", movimentoCab.ClientID);

                
                long novoId = (long)command.ExecuteScalar();

                return novoId;
            }
        }

        
        public void AdicionarMovimentoItem(MovimentosItens item)
        {
            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"
                    INSERT INTO MovimentosItens (idMovimento, idProduto, Preco, Quantidade, Tipo)
                    VALUES ($idmovimento, $idproduto, $preco, $quantidade,$tipo);";

               
                command.Parameters.AddWithValue("$idmovimento", item.IdMovimento);
                command.Parameters.AddWithValue("$idproduto", item.IdProduto);
                command.Parameters.AddWithValue("$preco", item.Preco);
                command.Parameters.AddWithValue("$quantidade", item.Quantidade);
                command.Parameters.AddWithValue("$tipo", item.TipoID);

                command.ExecuteNonQuery();
            }
        }

        
        public long ObterProximoNumeroFicha()
        {
            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"SELECT coalesce(MAX(id),0) + 1 as id FROM Movimentos";

                var proximoId = Convert.ToInt64(command.ExecuteScalar());

                return proximoId;
            }
        }

    }
}