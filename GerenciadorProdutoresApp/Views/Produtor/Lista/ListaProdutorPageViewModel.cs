using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GerenciadorProdutoresApp.Models.Produtor;
using GerenciadorProdutoresApp.Services.Produtor;

namespace GerenciadorProdutoresApp.Views.Produtor.Lista;

public partial class ListaProdutorPageViewModel : ObservableObject
{
    private readonly ICadastroProdutorService _produtorRepository;

    [ObservableProperty] List<ProdutorModel> _produtorList;  
    [ObservableProperty] private ProdutorModel _produtor;

    public ListaProdutorPageViewModel()
    {
        _produtorRepository = new ProdutorService();
        Produtor = new ProdutorModel();
        ListarProdutores();
    }

    [RelayCommand]
    private async Task DeletarProdutor(object sender)
    {
        Produtor = (ProdutorModel)sender;

        await _produtorRepository.InitializeAsync();

        var resposta = await App.Current.MainPage.DisplayAlert("Atenção", "Confirma exclusão ?", "Sim", "Não");
        if (resposta)
            await _produtorRepository.DeletarProdutor(Produtor);

        await Refresh();

    }
    private async void ListarProdutores()
    {
        await _produtorRepository.InitializeAsync();
        await Refresh();
    }

    private async Task Refresh()
    {
        ProdutorList = await _produtorRepository.BuscarTodosProdutores();
    }   
}
