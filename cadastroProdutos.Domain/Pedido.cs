using cadastroProdutos.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace cadastroProdutos.Domain
{
    public class Pedido: BaseEntity
    {
        private List<ItemPedido> _itens = new List<ItemPedido>();
        public IReadOnlyCollection<ItemPedido> Items => _itens;

        public Pedido()
        {
            Id = Guid.NewGuid();
            Status = StatusPedido.EmAndamento;
        }

        public decimal ValorTotal { get; set; }

        public StatusPedido Status { get; set; }

        public Guid UsuarioId { get; set; }

        public void AdicionarItemPedido(Guid produtoId, decimal valorUnitario, int quantidade)
        {
            var item = new ItemPedido(this, produtoId, valorUnitario, quantidade);
        }

    }
}
