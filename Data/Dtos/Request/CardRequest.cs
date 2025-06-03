using System.ComponentModel.DataAnnotations;

namespace KanbanApi.Data.Dtos.Request
{
    public class CardRequest
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome Obrigatorio")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Tipo Obrigatorio")]
        public string Tipo { get; set; }


        public DateTime DataCriacao { get; set; } = DateTime.Now;

        public DateTime? DataEntrega { get; set; }
    }
}
