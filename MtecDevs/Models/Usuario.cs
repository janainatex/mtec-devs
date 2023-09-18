using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;


namespace MtecDevs.Models

{
   
 [Table("Usuario")] 

public class Usuario
{
    [Key]
    public string UserId {get; set; }
    [ForeignKey("UserId")]
    public IdentityUser AccountUser {get; set; }

    [Required(ErrorMessage ="Informe o Nome")]
    [StringLength(60, ErrorMessage = "O Nome deve possuir no maximo 60 caracteres")]
    public string Nome { get; set;}

    [DataType(DataType.Date)]
    [Display(Name = "Data de Nascimento ")]
    [Required(ErrorMessage = "Informe a Data de Nascimento")]

    public DateTime DataNascimento { get; set;}

    [StringLength(300)]

    public string Foto {get; set; }
    [Display(Name = "Tipo de desenvolvedor")]
    [Required(ErrorMessage = "Informe o tipo de desenvolvedor")]

    public byte TipoDevId { get; set;}
    [ForeignKey("TipoDevId")]
    public byte TipoDev {get;  set;}

}   

}