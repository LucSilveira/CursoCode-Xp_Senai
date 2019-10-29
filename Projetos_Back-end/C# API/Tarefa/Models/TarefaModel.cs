using System.ComponentModel.DataAnnotations;
using System;

namespace Tarefa.Models
{
    public class TarefaModel
    {
        [Key]
        public int id_tarefa { get; set; }

        public string nome { get; set; }

        public string descricao { get; set; }

        public DateTime dataTarefa { get; set; }
    }
}