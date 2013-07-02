using System;
using System.ComponentModel.DataAnnotations;

namespace SGC.Comum.Entities
{
    [Table("Contato")]
    public class Contato
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string Nome { get; set; }

        [StringLength(20)]
        public String Email { get; set; }

        [StringLength(8)]
        [Display(Name = "Data Nascimento")]
        public string DataNascimento { get; set; }

        [StringLength(15)]
        public string Celular { get; set; }

        [StringLength(15)]
        [Display(Name = "Telefone Residencial")]
        public string TelefoneResidencial { get; set; }

        public bool DataValida()
        {
            return Validacao.DataYYYYMMDDValida(DataNascimento);
        }

        public bool EmailValido()
        {
            return Validacao.EmailValido(Email);
        }
    }
}
