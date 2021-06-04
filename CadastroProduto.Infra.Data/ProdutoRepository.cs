using CadastroProduto.Infra.Data.Context;
using cadastroProdutos.Domain;
using cadastroProdutos.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProduto.Infra.Data
{
    public class ProdutoRepository : IProdutoRepository
    {
        public Task Cadastrar(Produto produto)
        {
            Database.Produtos.Add(produto);
            return Task.CompletedTask;
        }

        public Task Editar(Produto produto)
        {
            var resultado = Database.Produtos.FirstOrDefault(x => x == produto);
            resultado.AtualizarDescricao(produto.Descricao);
            resultado.AtualizarValor(produto.Valor);                   
            return Task.CompletedTask;
        }


        public Task Excluir(Produto produto)
        {
            Database.Produtos.Remove(produto);
            return Task.CompletedTask;
        }

        public Task <Produto> ObterPorId(Guid Id)
        {
            return Task.FromResult(Database.Produtos.FirstOrDefault(x => x.Id == Id));
        }
    }
}
