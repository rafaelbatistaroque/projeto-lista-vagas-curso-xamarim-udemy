using appVagas.Modelos;
using appVagas.Repositorios;
using appVagas.Repositorios.Interfaces;
using appVagas.Repositorios.Queries;
using appVagas.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appVagas.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsultasVagasPage : ContentPage
    {
        private readonly INavegacaoService _navegacao;
        private readonly IRepositorioBase<Vaga> _repositorio;

        public IEnumerable<Vaga> Vagas { get; set; }

        public ConsultasVagasPage()
        {
            _navegacao = DependencyService.Get<INavegacaoService>();
            _repositorio = DependencyService.Get<IRepositorioBase<Vaga>>();
            InitializeComponent();

            Vagas = _repositorio.Obter();
            ListaVagas.ItemsSource = Vagas;
        }

        private void IrCadastro(object o, EventArgs e)
        {
            _navegacao.NavegarPara(new CadastroVagasPage());
        }

        private void IrMinhasVagas(object o, EventArgs e)
        {
            _navegacao.NavegarPara(new MinhasVagasPage());
        }

        private void IrMostrarMais(object o, EventArgs e)
        {
            var vaga = ((o as Label).GestureRecognizers.First() as TapGestureRecognizer).CommandParameter as Vaga;
            _navegacao.NavegarPara(new DetalhesVagaPage(vaga));
        }

        private void PerquisarVagas(object sender, TextChangedEventArgs e)
        {
            ListaVagas.ItemsSource = Vagas.Where(VagasQuery.ObterVagasConformePesquisa(e.NewTextValue).Compile()).ToList();
        }
    }
}