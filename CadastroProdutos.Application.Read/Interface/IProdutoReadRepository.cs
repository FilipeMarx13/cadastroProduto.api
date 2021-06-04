using CadastroProdutos.Application.Read.DTOS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProdutos.Application.Read.Interface
{
    public interface IProdutoReadRepository
    {
        Task <ProdutoDTO> ObterPorId(Guid id);

        Task<List<ProdutoDTO>> ObterTudo();

    }
}
