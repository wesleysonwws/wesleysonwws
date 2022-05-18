using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Ator: Artista
    {
        #region Relacionamentos
        public  List<Atorfilme> AtoresFilmes { get; set; }
        #endregion

    }
}

