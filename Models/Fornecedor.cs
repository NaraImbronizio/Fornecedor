namespace Fornecedor.Models;

public class Fornecedor
{
    public int Id { get; set; }
    public required string Nome { get; set; }
    public required string Endereco { get; set; }
    public required string Telefone { get; set; }
}
