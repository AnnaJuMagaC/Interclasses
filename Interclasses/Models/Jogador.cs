using System.ComponentModel.DataAnnotations;

namespace Interclasses.Models
{
    public class Jogador
    {
        public int JogadorId { get; set; }

        [Required(ErrorMessage = "O campo Nome do Jogador é Obrigatório")]
        [MaxLength(50, ErrorMessage = "O Nome do Jogador pode ter no máximo 50 caracteres.")]
        [Display(Name = "Nome do Jogador")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo Número do Jogador é Obrigatório")]
        [Range(1, 999, ErrorMessage = "O Número do Jogador deve estar entre 1 e 999.")]
        [Display(Name = "Número do Jogador")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "O campo Posição é Obrigatório")]
        [MaxLength(20, ErrorMessage = "A Posição pode ter no máximo 20 caracteres.")]
        [Display(Name = "Posição do Jogador")]
        public string? Posicao { get; set; }

        // Relacionamento com Time
        [Display(Name = "Time")]
        public int TimeId { get; set; }
        public Time? Time { get; set; }
    }
}
