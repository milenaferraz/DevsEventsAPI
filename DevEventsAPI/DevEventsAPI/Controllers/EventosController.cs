using DevEventsAPI.Entity;
using DevEventsAPI.Persistencia;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DevEventsAPI.Controllers
{
    [Route("api/eventos")]
    public class EventosController : ControllerBase
    {
        private readonly DevEventsDbContext _dbContext;

        public EventosController(DevEventsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult ObterEventos()
        {
            var evento = _dbContext.Eventos.ToList();
            return Ok(evento);
        }

        [HttpGet("{id}")]
        public IActionResult ObterEvento(int id) 
        {
            var evento = _dbContext.Eventos.SingleOrDefault(e => e.Id == id);

            if (evento == null)
            {
                return NotFound();
            }

            return Ok(evento);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody] Evento evento)
        {
            return NoContent();
        }

        [HttpPost]
        public IActionResult Cadastrar([FromBody] Evento evento)
        {
            _dbContext.Eventos.Add(evento);
            _dbContext.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Cancelar(int id)
        {
            return NoContent();
        }

        // api/eventos/1/usuarios/3/inscrever
        [HttpPost("{id}/usuarios/{idUsuario}/inscrever")]
        public IActionResult Inscrever(int id, int idUsuario, [FromBody] Inscricao inscricao)
        {
            return NoContent();
        }

    }
}
