using System;
using System.Collections.Generic;
using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private static List<Filme> Filmes = new();

        [HttpPost]
        public void AdicionaFilme([FromBody] Filme filme)
        {
            Filmes.Add(filme);
        }

        [HttpGet]
        public List<Filme> BuscaTodos()
        {
            return Filmes;
        }
    }
}
