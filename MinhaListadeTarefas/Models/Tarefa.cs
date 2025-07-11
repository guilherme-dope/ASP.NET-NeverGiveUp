using System.ComponentModel.DataAnnotations;

namespace MinhaListadeTarefas.Models
{
    public class Tarefa
    {
        [Required(ErrorMessage = "ID is mandatory")]
        [Display(Name = "ID da Tarefa")]
        public int? Id { get; set; }

        [Required(ErrorMessage = "Description is mandatory")]
        [Display(Name = "Descricao da Tarefa")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Start date is mandatory")]
        [Display(Name = "Data de Inicio da Tarefa")]
        public DateTime? DataInicio { get; set; }

        [Display(Name = "Data de Fim da Tarefa")]
        public DateTime? DataFim { get; set; }
    }
}
