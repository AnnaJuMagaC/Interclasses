using System.ComponentModel.DataAnnotations;

namespace Interclasses.Models
{
    public class Esporte
    {
        public int EsporteId { get; set; }

        //Torna o campo nome obrigatório
        [Required(ErrorMessage = "O Nome do do Esporte é Obrigatório.")]
        [MaxLength(50, ErrorMessage = "O Nome do Esporte pode ter no máximo, 50 caracteres.")]
        [Display(Name = "Nome do Esporte")]

        public string? Nome { get; set; }

        [Required(ErrorMessage = "Informe a quantidade máxima de Jogadores por Time")]
        [Range(1, 25, ErrorMessage = "O número de Jogadores deve estar entre 1 e 25.")]
        [Display(Name = "Quantidade de Jogadores")]
        public int QtdJogadores { get; set; }
    }
}
