using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Filme : IEntidade
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Preco { get; set; }
        public string ImagemURL { get; set; }
        public int Cinemaid { get; set; }
        public Cinema Cinema { get; set; } // RELACIONAMENTO
        public int ProdutorId { get; set; }
        public Produtor Produtor { get; set; }

        public List<Atorfilme> AtoresFilmes { get; set; }
        public List<filmecategoria> FilmesCategorias { get; set; }


    }
}
