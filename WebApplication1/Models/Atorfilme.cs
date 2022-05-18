using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Atorfilme
    {
        public Ator Ator { get; set; }
        public Ator Atorid { get; set; }
        public Filme Filme { get; set; }
        public int FilmeId { get; set; }
        public List<Filme> Filmes { get; set; }
      
    }
}
