using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GerenciadorProdutoresApp.Models.Produtor;
using GerenciadorProdutoresApp.Services.Produtor;

namespace GerenciadorProdutoresApp.Views.Produtor.Cadastro;

public partial class ProdutorViewModel : ObservableObject
{
    private readonly ICadastroProdutorService _produtorRepository;

    [ObservableProperty] private ProdutorModel _produtor;
    [ObservableProperty] private bool _validacaoNome;        
    [ObservableProperty] private bool _validacaoFazenda;
    [ObservableProperty] private bool _date;
    [ObservableProperty] List<ProdutorModel> _produtorList;

    public ProdutorViewModel()
    {
        Produtor = new ProdutorModel();
        _produtorRepository = new ProdutorService();       
    }

    [RelayCommand]
    private async void AddProdutor()
    {
        if (ValidarCamposVazios())
        {
            await _produtorRepository.InitializeAsync();
            await _produtorRepository.AdicionarProdutor(Produtor);
            await Refresh();
            await App.Current.MainPage.DisplayAlert("","Produtor cadastrado com sucesso!","Ok");
            await Shell.Current.GoToAsync("..");
        }
    }           

    private bool ValidarCamposVazios()
    {            
        ValidacaoNome    = string.IsNullOrEmpty(Produtor.Nome);            
        ValidacaoFazenda = string.IsNullOrEmpty(Produtor.Fazenda);
        
        return (!ValidacaoNome && !ValidacaoFazenda);
    }

    private async Task Refresh()
    {
        ProdutorList = await _produtorRepository.BuscarTodosProdutores();
    }
}
