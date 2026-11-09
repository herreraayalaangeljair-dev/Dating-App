namespace API.Entidades;

public class Appuser
{

    public string Id { get; set; } = Guid.NewGuid().ToString();

    public required string UserName { get; set; }
    public required string UserEmail { get; set; }
    
}