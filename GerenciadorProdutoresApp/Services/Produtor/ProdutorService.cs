using GerenciadorProdutoresApp.Models.Produtor;
using SQLite;

namespace GerenciadorProdutoresApp.Services.Produtor;

public class ProdutorService : ICadastroProdutorService
{
    private SQLiteAsyncConnection _dbConnection;
    public async Task InitializeAsync()
    {
        await SetUpDb();
    }

    private async Task SetUpDb() 
    {
        if (_dbConnection == null)
        {
            string dbPath = Path.Combine(Environment.
            GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ProdutoresDB.db3"); 

            _dbConnection = new SQLiteAsyncConnection(dbPath);
            await _dbConnection.CreateTableAsync<ProdutorModel>(); 
        }
    }

    public async Task<int> AdicionarProdutor(ProdutorModel produtor)
    {
        return await _dbConnection.InsertAsync(produtor);
    }

    public async Task<int> DeletarProdutor(ProdutorModel produtor)
    {
        return await _dbConnection.DeleteAsync(produtor);
    }

    public async Task<List<ProdutorModel>> BuscarTodosProdutores()
    {
        return await _dbConnection.Table<ProdutorModel>().ToListAsync();
    }     
}
