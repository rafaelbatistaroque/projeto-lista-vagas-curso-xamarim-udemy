using appVagas.BD.Interfaces;
using SQLite;
using Xamarin.Forms;

namespace appVagas.BD
{
    public class ConexaoSQLite : IConexaoSQLite
    {
        public SQLiteConnection Iniciar(string nomeBanco)
        {
            string caminhoCompleto = DependencyService.Get<IDiretorioDispositivo>().ObterDiretorioSalvamento(nomeBanco);

            return new SQLiteConnection(caminhoCompleto);
        }
    }
}
