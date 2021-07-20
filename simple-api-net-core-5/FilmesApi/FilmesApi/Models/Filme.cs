using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Filme
    {
        [Required(ErrorMessage ="O campo Titulo é Obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo Diretor é Obrigatório")]
        public string Diretor { get; set; }
        [Required(ErrorMessage = "O campo Genero é Obrigatório")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "Min 1 max 600")]
        public int Duracao { get; set; }
    }
}
