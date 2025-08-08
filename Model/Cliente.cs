using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorMK.Model
{
    public class Cliente
    {
       
        [Required]
        [StringLength(45,ErrorMessage ="O nome não pode ter mais do que 45 caracteres",MinimumLength = 1)]
        public required string Nome { get; set; }

        [Required]
        [StringLength(45, ErrorMessage = "A morada não pode ter mais do que 45 caracteres", MinimumLength = 1)]
        public required string Morada { get; set; }

        [StringLength(45, ErrorMessage = "O email não pode ter mais do que 45 caracteres", MinimumLength = 1)]
        public string Email { get; set; }

        [StringLength(11, ErrorMessage = "O Telemovel não pode ter mais do que 11 caracteres", MinimumLength = 1)]
        public string Telemovel { get; set; }
    }
}
