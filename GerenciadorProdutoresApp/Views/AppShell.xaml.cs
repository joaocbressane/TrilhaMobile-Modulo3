using GerenciadorProdutoresApp.Views.Produtor.Cadastro;
using GerenciadorProdutoresApp.Views.Produtor.Lista;
using GerenciadorProdutoresApp.Views.Sobre;

namespace GerenciadorProdutoresApp.Views;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();        
        Routing.RegisterRoute(nameof(ProdutorPage), typeof(ProdutorPage));
        Routing.RegisterRoute(nameof(ListaProdutoresPage), typeof(ListaProdutoresPage));
        Routing.RegisterRoute(nameof(SobrePage), typeof(SobrePage));        
    }    
}