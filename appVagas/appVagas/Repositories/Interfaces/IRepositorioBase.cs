using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace appVagas.Repositories.Interfaces
{
    public interface IRepositorioBase<T> where T : class
    {
        int Cadastrar(T entidade);
        int Deletar(T entidade);
        int Atualizar(T entidade);
        T Obter(int id);
        IEnumerable<T> Obter(Expression<Func<T, bool>> expressao);
        IEnumerable<T> Obter();
    }
}
