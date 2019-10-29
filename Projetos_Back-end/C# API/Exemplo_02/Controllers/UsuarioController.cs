using System.Linq;
using Exemplo_02.Context;
using Exemplo_02.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Exemplo_02.Controllers
{

    [ApiController]
    [Route("v1/[controller]")]
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {

        Exemplo_02Context context = new Exemplo_02Context();

        [HttpGet]
        public IActionResult Listar(){

            List<UsuarioModel> listaUsuario = context.tbl_usuario.ToList();

            return Ok(listaUsuario);
        }


        [HttpPost("cadastro")]
        public IActionResult Cadastrar(UsuarioModel usuario){
            context.tbl_usuario.Add(usuario);
            context.SaveChanges();
            return Ok();
        }


        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id){

            UsuarioModel user = context.tbl_usuario.FirstOrDefault(usuario => usuario.usr_id == id);
            return Ok(user);
        }


        [HttpPut]
        public IActionResult Atualizar(UsuarioModel user){

            UsuarioModel userRetornado = context.tbl_usuario.FirstOrDefault(tbl => tbl.usr_id == user.usr_id);
            if(userRetornado == null){

                return NotFound();
            }

            userRetornado.nome = user.nome;
            userRetornado.email = user.email;
            userRetornado.senha = user.senha;

            context.tbl_usuario.Update(userRetornado);
            context.SaveChanges();

            return Ok();

        }


        [HttpDelete("{id}")]
        public IActionResult Deletar(int id){

            UsuarioModel userRetornado = context.tbl_usuario.FirstOrDefault(tbl_usr => tbl_usr.usr_id == id);

            if(userRetornado == null){
                return NotFound();
            }

            context.tbl_usuario.Remove(userRetornado);
            context.SaveChanges();

            return Ok();

        }
        
    }
}