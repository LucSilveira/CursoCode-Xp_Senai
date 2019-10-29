using System.Linq;
using Tarefa.Context;
using Tarefa.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Tarefa.Controller
{
    [Route("v1/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class TarefaController : ControllerBase
    {

        TarefaContext context = new TarefaContext();

        [HttpGet]
        public IActionResult Listar(){

            List<TarefaModel> listaTarefas = context.tbl_tarefa.ToList();
            return Ok(listaTarefas);
        }

        [HttpPost("cadastro")]
        public IActionResult Cadastro(TarefaModel tarefa){
            context.tbl_tarefa.Add(tarefa);
            context.SaveChanges();
            return Ok();
        }
        
    }
}