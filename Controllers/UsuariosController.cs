using DevEventsAPI.Entity;
using Microsoft.AspNetCore.Mvc;

namespace DevEventsAPI.Controllers
{
    [Route("api/usuarios")]
    public class UsuariosController : ControllerBase 
    {
        [HttpPost]
        public IActionResult CadastrarUsuario([FromBody] Usuario usuario)
        {
            return Ok(usuario);
        }
    }
}
