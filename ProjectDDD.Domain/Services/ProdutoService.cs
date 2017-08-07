using ProjectDDD.Domain.Entities;
using ProjectDDD.Domain.Interface.Services;
using System.Collections.Generic;
using ProjectDDD.Domain.Interface;

namespace ProjectDDD.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {

        private readonly IProdutoRepository _produtoRepository;
        public ProdutoService(IProdutoRepository produtoRepository) : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoRepository.BuscarPorNome(nome);
        }
    }
}
