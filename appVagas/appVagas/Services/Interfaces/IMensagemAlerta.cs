using System.Threading.Tasks;

namespace appVagas.Services.Interfaces
{
    public interface IMensagemAlerta
    {
        Task<bool> Alerta(string titulo, string mensagem, string botaoOk, string botaoSair);
        Task Alerta(string titulo, string mensagem, string botaoCancelar);
    }
}
