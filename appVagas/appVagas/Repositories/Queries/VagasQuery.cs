using appVagas.Modelos;
using System;
using System.Linq.Expressions;

namespace appVagas.Repositories.Queries
{
    public static class VagasQuery
    {
        public static Expression<Func<Vaga, bool>> ObterVagaPorCidade(string cidade)
        {
            return v => v.Cidade == cidade;
        }

        public static Expression<Func<Vaga, bool>> ObterVagasConformePesquisa(string novoTexto)
        {
            return v => v.NomeVaga.Contains(novoTexto) || v.Cidade.Contains(novoTexto) || v.Empresa.Contains(novoTexto);
        }
    }
}
