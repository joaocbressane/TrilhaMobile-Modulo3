using GerenciadorProdutoresApp.Models.Produtor;

namespace GerenciadorProdutoresApp.Services.Produtor;

public interface ICadastroProdutorService
{
    Task InitializeAsync();    
    Task<List<ProdutorModel>> BuscarTodosProdutores();    
    Task<int> AdicionarProdutor(ProdutorModel produtor);    
    Task<int> DeletarProdutor(ProdutorModel produtor);
}
