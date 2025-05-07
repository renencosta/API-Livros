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

        /*[HttpGet]
        public async Task<IActionResult> ListarTodos()
        {
            return await Ok(_repository.ListarTodosAsync());
        }*/

        [HttpPost]
        public IActionResult Cadastrar(Categoria categoria)
        {
            _repository.Cadastrar(categoria);
            return Created();
        }

        [HttpPut]
        public IActionResult Atualizat(int id, Categoria categoria)
        {
            _repository.Atualizar(id, categoria);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _repository.Deletar(id);
            return Ok();
        }
    }
}
