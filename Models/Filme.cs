using System.ComponentModel.DataAnnotations;

namespace FilmeApi.Models;

public class Filme
{
    [Key]
    [Required]
    public int id { get; set; }

    [Required(ErrorMessage ="O titulo do filme é Obrigatório")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O Gênero do filme é Obrigatório")]
    [MaxLength(50,ErrorMessage ="O tamanho do gênero não pode exceder 50 caracteres")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "A duração do filme é Obrigatoria")]
    [Range(70,600,ErrorMessage ="A duracao deve ser entre 70 e 600 minutos ")]
    public int Duracao { get; set; }
}
