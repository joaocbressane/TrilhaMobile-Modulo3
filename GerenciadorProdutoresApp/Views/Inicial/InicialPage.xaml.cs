namespace GerenciadorProdutoresApp.Views.Inicial;

public partial class InicialPage : ContentPage
{
	public InicialPage()
	{
		InitializeComponent();
		BindingContext = new InicialViewModel();            
    }    
    
}