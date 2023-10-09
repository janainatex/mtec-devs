using System.ComponentModel.DataAnnotations;
namespace MtecDevs.ViewModels;

public class LoginVM
{
    [Display(Name = "Email ou Nome de Usuário ", Prompt =" Informe seu Email ou Nome de Usuário ")]
    [Required(ErrorMessage = "Por favor , informe seu Email ou nome de Usário")]

    public string Email {get; set;}
    [Display(Name ="senha de acesso", Prompt = "informe sua Senha de acesso")]
    [Required(ErrorMessage = "Por favor, informe sua senha de acesso")]
    [DataType(DataType.Password)]

    public string Senha {get; set;}
    [Display(Name = "Manter Conectado?")]

    public bool Lembrar {get; set;}

    public string  UrlRetorno {get; set;}
}
