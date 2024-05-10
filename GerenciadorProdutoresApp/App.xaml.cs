using GerenciadorProdutoresApp.Services.Produtor;
using GerenciadorProdutoresApp.Views;
using GerenciadorProdutoresApp.Views.Inicial;
using GerenciadorProdutoresApp.Views.Produtor;
using GerenciadorProdutoresApp.Views.Sobre;

namespace GerenciadorProdutoresApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }

}
