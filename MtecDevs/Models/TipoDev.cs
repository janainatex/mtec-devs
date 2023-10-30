using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MtecDevs.Models;

[Table("TipoDev")]

public class TipoDev
{
    [Key]
    public byte Id { get; set; }

    [Required(ErrorMessage = "Informe o Nome")]
    [StringLength(30, ErrorMessage = "O Nome deve possuir no máximo 30")]
    public string Nome { get; set; }
}
