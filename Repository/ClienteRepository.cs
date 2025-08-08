using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestorMK.Model;
using Microsoft.Data.Sqlite;

namespace GestorMK.Repository
{
    public class ClienteRepository
    {


       public static string caminhoCompletoBD = Path.Combine(Constantes.BdPasta, Constantes.BdNome);

       public static string ConnectionString = $"Data Source={caminhoCompletoBD}";

        

        public ClienteRepository()
        {
            
            string? directoryPath = Path.GetDirectoryName(ConnectionString.Split('=')[1]);
            if (!string.IsNullOrEmpty(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }

        

        public Int64 ObterProximoNumeroCliente() 
        {
            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"SELECT coalesce(MAX(id),0) + 1 as id FROM Clientes";

                var proximoId = Convert.ToInt64(command.ExecuteScalar());

                return proximoId;
            }
        }



        public string ObterNomeCliente(Int32 clienteID)
        {

            string nomeCliente = string.Empty;

            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();

                
                command.CommandText = @"SELECT Nome FROM Clientes WHERE id = @id";

                
                command.Parameters.AddWithValue("@id", clienteID);

                var resultado = command.ExecuteScalar();

                if (resultado != null)
                {
                    nomeCliente = resultado.ToString();
                }
            }

            return nomeCliente;
        }





        public void Adicionar(Cliente cliente)
        {
            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"
                    INSERT INTO Clientes (Nome, Morada, Email, Telemovel)
                    VALUES ($nome, $morada, $email, $telemovel);
                ";

              
                command.Parameters.AddWithValue("$nome", cliente.Nome);
                command.Parameters.AddWithValue("$morada", cliente.Morada);

                
                command.Parameters.AddWithValue("$email", string.IsNullOrEmpty(cliente.Email) ? DBNull.Value : cliente.Email);
                command.Parameters.AddWithValue("$telemovel", string.IsNullOrEmpty(cliente.Telemovel) ? DBNull.Value : cliente.Telemovel);

                command.ExecuteNonQuery();
            }
        }


        public List<Cliente> ObterListaCliente()
        {

            var clientes = new List<Cliente>();

            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"
                    SELECT id, Nome FROM Clientes;";



                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var cliente = new Cliente
                        {
                            ID = reader.GetInt32(0),
                            Nome = reader.GetString(1),
                            Morada = "",
                            Email = "",
                            Telemovel = ""
                        };
                        clientes.Add(cliente);
                    }

                }


            }
            return clientes;
        }

    }
}
