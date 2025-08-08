using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorMK.Model
{
    public class Produto
    {
        [StringLength(45,ErrorMessage ="O nome não pode ter mais do que 45 caracteres", MinimumLength = 1)]
        [Required]
        public required string Nome { get; set; }

        [StringLength(10, ErrorMessage = "O nome não pode ter mais do que 10 caracteres", MinimumLength = 1)]
        [Required]
        public required string Categoria { get; set; }

        [Required]
        public required decimal Preco {  get; set; }
    }
}
