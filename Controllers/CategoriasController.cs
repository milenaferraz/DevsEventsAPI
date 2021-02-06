using DevEventsAPI.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevEventsAPI.Controllers
{
    [Route("api/categorias")]
    public class CategoriasController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObterCategoria()
        {
            var categorias = new List<Categoria>
            {
                new Categoria { Id = 1, Descricao = ".NET"},
                new Categoria { Id = 2, Descricao = "Desenvolvimento Mobile"},
                new Categoria { Id = 3, Descricao = "Javascript"},
            };

            return Ok(categorias);
        }
    }
}
