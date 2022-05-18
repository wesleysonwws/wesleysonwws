﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Cinema : IEntidade
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get ; set; }
        public DateTime DataAlteracao { get ; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string LogoUrl { get; set; }

    }
}
