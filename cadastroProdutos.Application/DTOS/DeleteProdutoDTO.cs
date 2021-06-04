using System;
using System.Collections.Generic;
using System.Text;

namespace cadastroProdutos.Application.DTOS
{
    public class DeleteProdutoDTO
    {
        //public Guid Id{get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}
