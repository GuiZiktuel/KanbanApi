using System.ComponentModel.DataAnnotations;

namespace KanbanApi.Models;

public class Card
{
    [Key]
    [Required]
    
    public int Id { get; set; }

    [Required (ErrorMessage = "Nome Obrigatorio")]
    [MaxLength(50, ErrorMessage = "Tamanho Invalido")]
    public string Nome { get; set; }
    [Required(ErrorMessage = "Tipo Obrigatorio")]
    public string Tipo { get; set; }

    [Required]
    public DateTime DataCriacao { get; set; } 

    public DateTime? DataEntrega { get; set; }

}
