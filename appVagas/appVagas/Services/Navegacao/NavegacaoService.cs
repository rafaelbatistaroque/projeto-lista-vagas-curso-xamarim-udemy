using appVagas.Paginas;
using appVagas.Services.Interfaces;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace appVagas.Services.Navegacao
{
    public class NavegacaoService : INavegacaoService
    {
        public async Task NavegarPara(Page paginaDestino)
        {
            await App.Current.MainPage.Navigation.PushAsync(paginaDestino);
        }

        public async Task VoltarUmaPagina()
        {
            await App.Current.MainPage.Navigation.PopAsync();
        }

        public void VotarPaginaRaizAtualizada()
        {
            App.Current.MainPage = new NavigationPage(new ConsultasVagasPage());
        }
    }
}
