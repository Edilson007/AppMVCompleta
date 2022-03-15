﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Business.Models
{
    class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedo { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }

        /*EF Relation*/
        public IEnumerable<Produto> Produtos { get; set; }
    }
}
    