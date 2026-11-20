using API.Data;
using API.DTO;
using API.Entidades;
using Microsoft.AspNetCore.Mvc;
using MyApp.Namespace;
using System.Security.Cryptography;
using System.Text;

namespace API.Controllers;

public class AccountController(AppDbContext context): BaseApiController
{
    [HttpPost("registrar")]
    public async Task<ActionResult<Appuser>> Registrar(RegistrarDTO registrarDTO)
    {
        using var hmac = new HMACSHA512();

        var user = new Appuser
        {
            UserEmail = registrarDTO.Email,
            UserName = registrarDTO.Nombre,
            PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registrarDTO.Password)),
            PasswordSalt = hmac.Key
        };

        context.Users.Add(user);
        await context.SaveChangesAsync();
        return user;
    }
}

