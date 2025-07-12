using System.ComponentModel.DataAnnotations;

namespace MinhaListadeTarefas.Models
{
    public class Responsavel
    {
        [Key]
        [Required(ErrorMessage = "ID is mandatory")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is mandatory")]
        [MaxLength(200)]
        public string Nome { get; set; }
    }
}
