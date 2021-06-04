using cadastroProdutos.Application.DTOS;
using cadastroProdutos.Application.Interfaces;
using cadastroProdutos.Domain;
using cadastroProdutos.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cadastroProdutos.Application
{
    public class ProdutoService : IProdutosService
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        //Create
        public async Task<Guid> Cadastrar(CadastrarProdutoDTO cadastrarProdutoDTO)
        {
            var produto = new Produto(cadastrarProdutoDTO.Descricao, cadastrarProdutoDTO.Valor);
            await _produtoRepository.Cadastrar(produto);
            return produto.Id;
        }

        //Upadate        

        public async Task<Guid> Atualizar(AtualizarProdutoDTO atualizarProdutoDTO)
        {
            var produto = await _produtoRepository.ObterPorId(atualizarProdutoDTO.Id);
            //Dominio de exceção
            produto?.AtualizarDescricao(atualizarProdutoDTO.Descricao);
            produto?.AtualizarValor(atualizarProdutoDTO.Valor);
            if (produto == null)
            {
                throw new Exception("Produto não encontrado");
            }
            await _produtoRepository.Editar(produto);

            return produto.Id;
        }

        //Delete

        public async Task<Guid> Delete(Guid id)
        {
            var produto = await _produtoRepository.ObterPorId(id);
            await _produtoRepository.Excluir(produto);
            return produto.Id;
        }

   
    }
}
