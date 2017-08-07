using ProjectDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDDD.Domain.Interface.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {

        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
