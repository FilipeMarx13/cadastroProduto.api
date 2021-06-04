using cadastroProdutos.Application.DTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cadastroProdutos.Application.Interfaces
{
    public interface IProdutosService
    {
        Task<Guid> Cadastrar(CadastrarProdutoDTO cadastrarProdutoDTO);

        Task<Guid> Delete(Guid id);

        Task<Guid> Atualizar(AtualizarProdutoDTO atualizarProdutoDTO);        

    }
}
