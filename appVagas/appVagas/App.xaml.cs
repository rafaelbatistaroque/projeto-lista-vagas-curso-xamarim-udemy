using appVagas.BD;
using appVagas.BD.Interfaces;
using appVagas.Modelos;
using appVagas.Paginas;
using appVagas.Repositories;
using appVagas.Repositories.Interfaces;
using appVagas.Services.Interfaces;
using appVagas.Services.Mensagem;
using appVagas.Services.Navegacao;
using Xamarin.Forms;

namespace appVagas
{
    public partial class App : Application
    {
        public App()
        {
            DependencyService.Register<IConexaoSQLite, ConexaoSQLite>();
            DependencyService.Register<IRepositorioBase<Vaga>, VagaRepositorio>();
            DependencyService.RegisterSingleton(new MensagemService());
            DependencyService.RegisterSingleton(new NavegacaoService());

            InitializeComponent();

            MainPage = new NavigationPage(new ConsultasVagasPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
