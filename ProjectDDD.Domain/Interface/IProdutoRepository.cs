using ProjectDDD.Domain.Entities;
using System.Collections;
using System.Collections.Generic;

namespace ProjectDDD.Domain.Interface
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
