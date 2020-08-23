using SQLite;

namespace appVagas.BD.Interfaces
{
    public interface IConexaoSQLite
    {
        SQLiteConnection Iniciar(string nomeBanco);
    }
}
