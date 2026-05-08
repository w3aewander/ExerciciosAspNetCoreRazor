namespace MinhaAppSqlite.Models;

public class Cliente
{

    //_id => atributo privado, Id => propriedade pública
    public int Id { get; set; } //
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public Endereco Endereco { get; set; } = new Endereco(); // Inicializa o endereço com um novo objeto

}