using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroProdutos.Application.Read.DTOS
{
    public class ProdutoDTO
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}
