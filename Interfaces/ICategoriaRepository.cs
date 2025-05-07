using ProjetoLivros.Models;

namespace ProjetoLivros.Interfaces
{
    public interface ICategoriaRepository
    {
        // Metodo Assincrono - Task (Tarefa)
        Task<List<Categoria>> ListarTodosAsync();

        void Cadastrar(Categoria categoria);

        Categoria? Atualizar(int id, Categoria categoria);  

        Categoria? Deletar(int id);
    }
}
