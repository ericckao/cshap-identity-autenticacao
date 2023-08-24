using Microsoft.AspNetCore.Mvc;
using UsuarioAPI.Database.Dtos;

namespace UsuarioAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        public IActionResult CadastraUsuario(CreateUsuariosDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
