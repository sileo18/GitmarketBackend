using Microsoft.AspNetCore.Mvc;
using MusicsAPI.Models;

namespace MusicsAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class MarketController : ControllerBase
{
    private static List<Usuario> Usuarios = new List<Usuario>();

    [HttpPost("/")]    
    public IActionResult CreateUser([FromBody] Usuario usuario)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }
        
        Usuarios.Add(usuario);

        return Ok();
    }

    
}
