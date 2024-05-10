using GerenciadorProdutoresApp.Views.Produtor.Cadastro;
using GerenciadorProdutoresApp.Views.Produtor.Lista;
using GerenciadorProdutoresApp.Views.Sobre;

namespace GerenciadorProdutoresApp.Views.Inicial;

public class InicialViewModel 
{    
    public Command MostraTelaProdutorCommand { get; set; } = new(() => Shell.Current.GoToAsync(nameof(ProdutorPage)));
    public Command MostraListaProdutoresCommand { get; set; } = new(() => Shell.Current.GoToAsync(nameof(ListaProdutoresPage)));
    public Command MostraTelaSobreCommand { get; set; } = new(() => Shell.Current.GoToAsync(nameof(SobrePage)));
    
}

