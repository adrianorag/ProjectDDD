using ProjectDDD.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDDD.Domain.Entities;
using ProjectDDD.Domain.Interface.Services;

namespace ProjectDDD.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {

        private readonly IProdutoService _produtoService;


        public ProdutoAppService(IProdutoService produtoService) : base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscarPorNome(string Nome)
        {
            return _produtoService.BuscarPorNome(Nome);
        }
    }
}
