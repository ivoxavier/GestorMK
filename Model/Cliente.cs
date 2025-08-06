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
        public required string Nome { get; set; }

        [Required]
        public required string Morada { get; set; }

        public string Email { get; set; }
        public string Telemovel { get; set; }
    }
}
