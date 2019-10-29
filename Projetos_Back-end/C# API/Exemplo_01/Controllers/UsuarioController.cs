using System.Collections.Generic;
using System.Linq;
using Exemplo_01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exemplo_01.Controllers
{
    [ApiController]
    [Route("v1/[Controller]")]
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {

        List<UsuarioModel> listaUsuarios = new List<UsuarioModel>();

        [HttpGet("listar")]
        public IActionResult Usuarios(){

            UsuarioModel usuario1 = new UsuarioModel();
            usuario1.UsuarioId = 1;
            usuario1.Nome = "Lucas Silveira Portal";
            usuario1.Email = "lucas@silveira.portal";
            usuario1.Senha = "Lucas123";

            UsuarioModel usuario2 = new UsuarioModel();
            usuario2.UsuarioId = 2;
            usuario2.Nome = "TIAGUEIRAA";
            usuario2.Email = "Ti@gueiraaaa.com";
            usuario2.Senha = "tiagueira123";

            listaUsuarios.Add(usuario1);
            listaUsuarios.Add(usuario2);

            return Ok(listaUsuarios);
        }

        [HttpGet("listar/{id}")]
        public IActionResult BuscarUsuairo( int id){
            
            return Ok(listaUsuarios.FirstOrDefault(usuario => usuario.UsuarioId == id));
        }

        [HttpPost("cadastro")]
        public IActionResult Cadastro(UsuarioModel usuario){
            listaUsuarios.Add(usuario);
            return Ok(listaUsuarios);
        }
    }
}