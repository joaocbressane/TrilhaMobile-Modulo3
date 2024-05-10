namespace GerenciadorProdutoresApp.Views.Produtor.Lista;

public partial class ListaProdutoresPage : ContentPage
{
	public ListaProdutoresPage()
	{
		InitializeComponent();
        BindingContext = new ListaProdutorPageViewModel();
    }
}