using System.Threading.Tasks;
using Xamarin.Forms;

namespace appVagas.Services.Interfaces
{
    public interface INavegacaoService
    {
        Task NavegarPara(Page paginaDestino);
        Task VoltarUmaPagina();
        void VotarPaginaRaizAtualizada();
    }
}
