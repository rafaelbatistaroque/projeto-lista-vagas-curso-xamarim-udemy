using appVagas.BD.Interfaces;
using appVagas.Modelos;
using appVagas.Repositories.Interfaces;
using appVagas.Utils.Recursos;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Xamarin.Forms;

namespace appVagas.Repositories
{
    public class VagaRepositorio : IRepositorioBase<Vaga>
    {
        private readonly SQLiteConnection _conexao;

        public VagaRepositorio()
        {
            _conexao = DependencyService.Get<IConexaoSQLite>().Iniciar(BDNome.Vagas);
            _conexao.CreateTable<Vaga>();
        }
        public int Atualizar(Vaga entidade)
        {
            return _conexao.Update(entidade);
        }

        public int Cadastrar(Vaga entidade)
        {
            return _conexao.Insert(entidade);
        }

        public int Deletar(Vaga entidade)
        {
            return _conexao.Delete(entidade);
        }

        public Vaga Obter(int id)
        {
            return _conexao.Get<Vaga>(id);
        }

        public IEnumerable<Vaga> Obter(Expression<Func<Vaga, bool>> expressao)
        {
            return _conexao.Table<Vaga>().Where(expressao).AsEnumerable();
        }

        public IEnumerable<Vaga> Obter()
        {
            return _conexao.Table<Vaga>().AsEnumerable();
        }
    }
}
