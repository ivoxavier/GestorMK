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
        
        private const string ConnectionString = "Data Source=databases/GestorMK.sqlite";

        public ClienteRepository()
        {
            
            string? directoryPath = Path.GetDirectoryName(ConnectionString.Split('=')[1]);
            if (!string.IsNullOrEmpty(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
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
    }
}
