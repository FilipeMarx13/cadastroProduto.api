using System;
using System.Collections.Generic;
using System.Text;

namespace cadastroProdutos.Application.DTOS
{
    public class AtualizarProdutoDTO
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        public Guid Id { get; private set; }

        public void AtualizarId(Guid id) 
        {
            Id = id;
        }
    }
}
