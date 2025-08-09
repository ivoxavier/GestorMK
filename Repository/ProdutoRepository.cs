using GestorMK.Model;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorMK.Repository
{
    public class ProdutoRepository
    {
        public static string caminhoCompletoBD = Path.Combine(Constantes.BdPasta, Constantes.BdNome);

        public static string ConnectionString = $"Data Source={caminhoCompletoBD}";



        public ProdutoRepository()
        {

            string? directoryPath = Path.GetDirectoryName(ConnectionString.Split('=')[1]);
            if (!string.IsNullOrEmpty(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }




        public void AdicionarProduto(Produto produto)
        {
            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"
                    INSERT INTO Produtos (Nome,Categoria,Preco,Quantidade)
                    VALUES ($nome,$categoria,$preco,$quantidade);";

                command.Parameters.AddWithValue("$nome", produto.Nome);
                command.Parameters.AddWithValue("$categoria", produto.Categoria);
                command.Parameters.AddWithValue("$preco", produto.Preco);
                command.Parameters.AddWithValue("$quantidade", produto.Quantidade);


                command.ExecuteNonQuery();
            }
        }





        public void AdicionarNovaCategoriaProduto(CategoriaProduto categoria)
        {
            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"
                    INSERT INTO CategoriasProdutos (Categoria)
                    VALUES ($categoria);";


                command.Parameters.AddWithValue("$categoria", categoria.Categoria);
              

                command.ExecuteNonQuery();
            }
        }


        public List<CategoriaProduto> ObterCategorias() 
        {

           var categorias = new List<CategoriaProduto>();

            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"
                    SELECT Categoria FROM CategoriasProdutos;";



                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoria = new CategoriaProduto
                        {
                            Categoria = reader.GetString(0)
                        };
                        categorias.Add(categoria);
                    }
                   
                }

               
            }
            return categorias;
        }


        public List<Produto> ObterListaProdutos()
        {

            var produtos = new List<Produto>();

            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"
                    SELECT id, Nome, Categoria, Preco FROM Produtos;";



                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var produto = new Produto
                        {
                            Id = reader.GetInt32(0),
                            Nome = reader.GetString(1),
                            Categoria = reader.GetString(2),
                            Preco = reader.GetInt32(3),
                            Quantidade = 0

                        };
                        produtos.Add(produto);
                    }

                }


            }
            return produtos;
        }



        public decimal ObterPrecoProduto(Int32 produtoID)
        {

            decimal precoProduto = 0;

            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();


                command.CommandText = @"SELECT Preco FROM Produtos WHERE id = @id";


                command.Parameters.AddWithValue("@id", produtoID);

                var resultado = command.ExecuteScalar();

                if (resultado != null)
                {
                    precoProduto = Convert.ToDecimal(resultado);
                }
            }

            return precoProduto;
        }









        public string ObterNomeProduto(Int32 produtoID)
        {

            string nomeProduto = string.Empty;

            using (var connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();


                command.CommandText = @"SELECT Nome FROM Produtos WHERE id = @id";


                command.Parameters.AddWithValue("@id", produtoID);

                var resultado = command.ExecuteScalar();

                if (resultado != null)
                {
                    nomeProduto = resultado.ToString();
                }
            }

            return nomeProduto;
        }


    }
}
