using System;

namespace cadastroProdutos.Domain
{
    public class Produto: BaseEntity
    {
        public Produto(string descricao, decimal valor)
        {
            Descricao = descricao;
            Valor = valor;            
        }

        protected Produto()
        {

        }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }

        public void AtualizarValor(decimal valor) {

            Valor = valor;
        }

        public void AtualizarDescricao(string descricao) 
        {
            Descricao = descricao;
        }
    }
    
}
