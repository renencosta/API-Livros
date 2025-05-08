using Microsoft.EntityFrameworkCore;
using ProjetoLivros.Context;
using ProjetoLivros.Interfaces;
using ProjetoLivros.Models;

namespace ProjetoLivros.Repositories
{
    //Herdar e implementar a interface
    //Injetar o Contexto
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly LivrosContext _context;
        public CategoriaRepository(LivrosContext context)
        {
            _context = context;
        }

        public Categoria? Atualizar(int id, Categoria categoria)
        {
            var categoriaEncontrada = _context.Categorias.FirstOrDefault(c => c.CategoriaId == id);

            if (categoriaEncontrada == null)
            {
                return null;
            }

            categoriaEncontrada.NomeCategoria = categoria.NomeCategoria;
            _context.SaveChanges();

            return categoriaEncontrada;
        }

        public void Cadastrar(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
        }

        public Categoria? Deletar(int id)
        {
            var categoria = _context.Categorias.Find(id);

            if (categoria == null)
            {
                return null;
            }

            _context.Categorias.Remove(categoria);
            _context.SaveChanges();

            return categoria;
        }

        public  List<Categoria> ListarTodos()
        {
            return _context.Categorias.ToList();
        }
    }
}
