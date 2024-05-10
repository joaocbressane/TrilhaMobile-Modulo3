namespace GerenciadorProdutoresApp.Views.Produtor.Cadastro;

public partial class ProdutorPage : ContentPage
{  
    
    public ProdutorPage() 
    {
        InitializeComponent();
        BindingContext = new ProdutorViewModel();
        telefoneEntry.TextChanged += FormatacaoTelefone_TextChanged;
    }   
    private void FormatacaoTelefone_TextChanged(object sender, TextChangedEventArgs e)
    {
        var entry = (Entry)sender;
        var texto = e.NewTextValue;

        if (!string.IsNullOrEmpty(texto))
        {
            texto = new string(texto.Where(char.IsDigit).ToArray());
                        
            if (texto.Length >= 2)
                texto = $"({texto.Substring(0, 2)}) {texto.Substring(2)}";
            if (texto.Length >= 10)
                texto = $"{texto.Substring(0, 10)}-{texto.Substring(10)}";
                        
            entry.Text = texto;
                        
            entry.CursorPosition = texto.Length;
        }

    }

}