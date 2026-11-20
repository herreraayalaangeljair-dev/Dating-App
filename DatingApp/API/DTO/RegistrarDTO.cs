using System.ComponentModel.DataAnnotations;

namespace API.DTO;

public class RegistrarDTO
{

    [Required] [EmailAddress] public string Email { get; set; } = "";
    [Required] [MinLength(8)]public string Password { get; set; } = "";
    [Required] public string Nombre { get; set; } = "";
}