using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MtecDevs.Models;

namespace MtecDevs.Data;

public class AppDbSeed
{
   public AppDbSeed(ModelBuilder builder)
   {
    #region Popular dos dados de TipoDev
    List<TipoDev> tipoDevs = new() {
        new TipoDev() {
            Id = 1,
            Nome = "FullStack"
    },
        new TipoDev() {
            Id = 2,
            Nome = "FroontEnd"
    },
            new TipoDev() {
            Id = 3,
            Nome = "BackEnd"
    },
            new TipoDev() {
            Id = 4,
            Nome = "Desing"     
    },
            new TipoDev() {
            Id = 5,
            Nome = "Jogos"
            
    }
 };
    builder.Entity<TipoDev>().HasData(tipoDevs);
    #endregion 

    #region Popular dos dados Perfis de Usuário 
    List<IdentityRole> roles = new() {
        new IdentityRole() {
            Id = Guid.NewGuid().ToString(),
            Name = "Administrador",
            NormalizedName = "ADMINISTRADOR"
        },
         new IdentityRole() {
            Id = Guid.NewGuid().ToString(),
            Name = "Moderador",
            NormalizedName = "MODERADOR"
        },
         new IdentityRole() {
            Id = Guid.NewGuid().ToString(),
            Name = "Usuário",
            NormalizedName = "USUÁRIO"
        }

    };
    builder.Entity<IdentityRole>().HasData(roles);
    #endregion

    #region  Popular dos dados Usuários
    //Cria a lista de contas
    List<IdentityUser> users = new() {
        new IdentityUser() {
            Id = Guid.NewGuid().ToString(),
            Email = "janainajapa05@gmail.com",
            NormalizedEmail = "JANAINAJAPA055@GMAIL.COM",
            UserName = "Janaina",
            NormalizedUserName = "JANAINA",
            LockoutEnabled = false,
            PhoneNumber = "14997490751",
            PhoneNumberConfirmed = true ,
            EmailConfirmed = true 
        }
    };
    //Criptografar as senhas
    foreach (var user in users) {
        PasswordHasher<IdentityUser> pass = new();
        user.PasswordHash = pass.HashPassword(user, "@Etec123");
    }
    //Adiociona a conta no banco
    builder.Entity<IdentityUser>().HasData(users);


    #endregion

   } 
}