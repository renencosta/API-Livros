using ProjetoLivros.Models;

namespace ProjetoLivros.Interfaces
{
    public interface ICategoriaRepository
    {
        // Metodo Assincrono - Task (Tarefa)
        List<Categoria> ListarTodos();

        void Cadastrar(Categoria categoria);

        Categoria? Atualizar(int id, Categoria categoria);  

        Categoria? Deletar(int id);
    }
}
