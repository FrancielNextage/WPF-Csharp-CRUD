using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.MVVM.Model
{
    class Pessoa
    {
        Pessoa() { }

        [Key]
        private long Id { get; }

        [Required]
        private string Nome { get; set; }

        [Required]
        private string Cpf { get; set; }

        private string Endereco { get; set; }
    }
}
