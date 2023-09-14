using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MtecDevs.Models;

[Table("TipoDev")]
    public class TipoDev

    {
        [Key]
        public byte Id  { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        [StringLength(30, ErrorMessage = "O nome deve possuir no máximo 30 caracteres")]
        public string Nome { get; set; }

    }




