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


        public void AdicionarMovimento(Movimentos movimento, MovimentosItens movimentosItens, Int64 movimentoID) 
        {
            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"
                    INSERT INTO Movimentos (Tipo,ClienteID)
                    VALUES ($tipo,$clientid);";

                command.Parameters.AddWithValue("$tipo", movimento.Tipo);
                command.Parameters.AddWithValue("$clientid", movimento.ClientID);
                command.ExecuteNonQuery();

                command.CommandText = @"
                    INSERT INTO MovimentosItens (idMovimento,idProduto,Preco,Quantidade)
                    VALUES ($idmovimento,$idproduto,$preco,$quantidade);";

                command.Parameters.AddWithValue("$idmovimento", movimentoID);
                command.Parameters.AddWithValue("$idproduto", movimento.ProdutoID);
                command.Parameters.AddWithValue("$preco", movimentosItens.Preco);
                command.Parameters.AddWithValue("$quantidade", movimentosItens.Quantidade);
                command.ExecuteNonQuery();

            }

        }

        public Int64 ObterProximoNumeroFicha()
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
