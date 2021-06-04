using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace cadastroProdutos.Domain.Repositories
{
    public interface IProdutoRepository
    {
        Task Cadastrar(Produto produto);
        Task Excluir(Produto produto);
        Task Editar(Produto produto);
        Task <Produto> ObterPorId(Guid Id);
    }
}
