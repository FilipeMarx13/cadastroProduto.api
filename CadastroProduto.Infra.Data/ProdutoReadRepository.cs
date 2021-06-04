using CadastroProduto.Infra.Data.Context;
using CadastroProdutos.Application.Read.DTOS;
using CadastroProdutos.Application.Read.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroProduto.Infra.Data
{
    public class ProdutoReadRepository : IProdutoReadRepository
    {
        public Task<ProdutoDTO> ObterPorId(Guid id)
        {
            var produto = (from p in Database.Produtos
                          where p.Id == id
                          select new ProdutoDTO()
                          {
                              Id = p.Id,
                              Descricao = p.Descricao,
                              Valor = p.Valor
                          }).FirstOrDefault();
            return Task.FromResult(produto);
        }

        public Task<List<ProdutoDTO>> ObterTudo()
        {
            var produtos = (from p in Database.Produtos                           
                           select new ProdutoDTO()
                           {
                               Id = p.Id,
                               Descricao = p.Descricao,
                               Valor = p.Valor
                           }).ToList();
            return Task.FromResult(produtos);
        }
    }
}
