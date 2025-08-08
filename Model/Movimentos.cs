using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestorMK.Model
{
    public class Movimentos
    {
        [Required]
        public required int Tipo {  get; set; }

        [Required]
        public required int ClientID { get; set; }

        [Required]
        public required int ProdutoID { get; set; }
    }


    public class MovimentosItens
    {
        [Required]
        public required int Tipo { get; set; }

        [Required]
        public required int IdMovimento { get; set; }

       
        public int IdProduto { get; set; }

        [Required]
        public required decimal Preco { get; set; }


        [Required]
        public required int Quantidade { get; set; }


        public string NomeProduto { get; set; } 

    }
}
