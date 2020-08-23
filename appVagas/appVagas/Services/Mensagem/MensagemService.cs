using appVagas.Services.Interfaces;
using System.Threading.Tasks;

namespace appVagas.Services.Mensagem
{
    public class MensagemService : IMensagemService
    {
        public async Task<bool> Alerta(string titulo, string mensagem, string botaoOk, string botaoSair)
        {
            return await App.Current.MainPage.DisplayAlert(titulo, mensagem, botaoOk, botaoSair);
        }

        public async Task Alerta(string titulo, string mensagem, string botaoCancelar)
        {
            await App.Current.MainPage.DisplayAlert(titulo, mensagem, botaoCancelar);
        }
    }
}
