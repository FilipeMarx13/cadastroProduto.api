using System;
using System.Collections.Generic;
using System.Text;

namespace cadastroProdutos.Domain
{
    public class ItemPedido: BaseEntity
    {
        public ItemPedido(Pedido pedido, Guid produtoId, decimal valorUnitario, int quantidade)
        {
            Pedido = pedido;
            ProdutoId = produtoId;            
            ValorUnitario = valorUnitario;
            Quantidade = quantidade;
            CalcularValorTotal();
        }
        
        protected ItemPedido()
        {

        }
        
        public Guid PedidoId { get; set; }
        public Pedido Pedido { get; set; }
        public Guid ProdutoId { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorUnitario { get; set; }
        public int Quantidade { get; set; }

        public void CalcularValorTotal()
        {
            ValorTotal = Quantidade * ValorUnitario;
        }

    }

}
