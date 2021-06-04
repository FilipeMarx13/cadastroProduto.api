using cadastroProdutos.Application.DTOS;
using cadastroProdutos.Application.Interfaces;
using CadastroProdutos.Application.Read.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace cadastroProduto.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutosService _produtosService;
        private readonly IProdutoReadRepository _produtoReadRepository;

        public ProdutosController(IProdutosService produtosService, IProdutoReadRepository produtoReadRepository)
        {
            _produtosService = produtosService;
            _produtoReadRepository = produtoReadRepository;
        }

        [HttpGet]
        public async Task <IActionResult> GetAll()
        {
            var produtos = await _produtoReadRepository.ObterTudo();
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public async Task <IActionResult> Get(Guid id)
        {
            var produto = await _produtoReadRepository.ObterPorId(id);
            return Ok(produto);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(CadastrarProdutoDTO cadastrarProdutoDTO)
        {
            var produtoId = await _produtosService.Cadastrar(cadastrarProdutoDTO);
            return Ok(produtoId);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var produto = await _produtosService.Delete(id);
            return Ok(produto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Atualizar(AtualizarProdutoDTO atualizarProdutoDTO, Guid id)
        {
            atualizarProdutoDTO.AtualizarId(id);
            var produto = await _produtosService.Atualizar(atualizarProdutoDTO);
            return Ok(produto);
        }     


    }
}
