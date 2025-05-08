using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoLivros.Interfaces;
using ProjetoLivros.Models;

namespace ProjetoLivros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        //Injetar o Repository
        private readonly ICategoriaRepository _repository;

        public CategoriaController(ICategoriaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(_repository.ListarTodos());
        }

        [HttpPost]
        public IActionResult Cadastrar(Categoria categoria)
        {
            _repository.Cadastrar(categoria);
            return Created();
        }

        [HttpPut("{id}")]
        public IActionResult Atualizat(int id, Categoria categoria)
        {
            _repository.Atualizar(id, categoria);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Deletar(id);
            return Ok();
        }
    }
}
