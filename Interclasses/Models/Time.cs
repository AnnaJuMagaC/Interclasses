using System.ComponentModel.DataAnnotations;

namespace Interclasses.Models
{
    public class Time
    {
        public int TimeId { get; set; }

        [Required(ErrorMessage = "O campo Nome do Time é Obrigatório")]
        [MaxLength(50, ErrorMessage = "O Nome do Time pode ter no máximo 50 caracteres.")]
        [Display(Name = "Nome do Time")]
        public string? Nome { get; set; }

        //Relacionamento entre Models (Tabelas no Banco de Dados)
        [Display(Name = "Esporte")]
        public int EsporteId { get; set; } // Vicular o campo de Id da tabela
        public Esporte? Esporte { get; set; } // Vincular o objeto relacionado ao Id acima.
    }
}
