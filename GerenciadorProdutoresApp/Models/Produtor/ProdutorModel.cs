using SQLite;

namespace GerenciadorProdutoresApp.Models.Produtor;

[Table("Produtor")]
public record ProdutorModel
{
    [PrimaryKey, AutoIncrement] public int ProdutorId { get; set; }    
    [NotNull, MaxLength(100)] public string Nome { get; set; }    
    [MaxLength(12)] public string Telefone { get; set; }    
    [NotNull, MaxLength(100)] public string Fazenda { get; set; }
}
