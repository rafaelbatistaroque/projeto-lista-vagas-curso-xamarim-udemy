using appVagas.Modelos;
using appVagas.Servicos.Interfaces;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appVagas.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalhesVagaPage : ContentPage
    {
        private readonly IMensagemService _mensagem;
        public DetalhesVagaPage(Vaga vaga)
        {
            _mensagem = DependencyService.Get<IMensagemService>();
            InitializeComponent();
            BindingContext = vaga;
        }
    }
}