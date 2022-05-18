using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class filmecategoria:
0   {
    public int Id { get; set; }
    public DateTime DataCadastro { get; set; }
    public DateTime DataAlteracao { get; set; }
    public Filme Filme { get; set; }
    public Filme Filmeid { get; set; }
    public int CategoriaId { get; set; }
    public Categoria Categoria { get; set; }

    }

}
