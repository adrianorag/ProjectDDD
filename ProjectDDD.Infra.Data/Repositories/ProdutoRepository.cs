using ProjectDDD.Domain.Entities;
using ProjectDDD.Domain.Interface;
using System.Collections.Generic;
using System.Linq;

namespace ProjectDDD.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}
