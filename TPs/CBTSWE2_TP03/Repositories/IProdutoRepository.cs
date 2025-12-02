using CBTSWE2_TP03.Models;

//Feito por Eduardo Barbosa Rodrigues e Vinicius Pontes Oliva

namespace CBTSWE2_TP03.Repositories
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> GetProdutos();
        Task<Produto> GetProdutoById(int id);
        Task AddProduto(Produto produto);
        Task UpdateProduto(Produto produto);
        Task DeleteProduto(int id);
    }
}
