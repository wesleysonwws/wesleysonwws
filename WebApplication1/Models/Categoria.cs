using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Categoria: IEntidade
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        #region

        #endregion

    }
}
