namespace ProjetoLivros.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        public string NomeCategoria { get; set; }

        List<Livro> Livros { get; set; } = new List<Livro>();
    }
}
