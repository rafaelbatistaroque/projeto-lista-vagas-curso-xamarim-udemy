using appVagas.Modelos;
using appVagas.Repositorios.Interfaces;
using appVagas.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appVagas.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MinhasVagasPage : ContentPage
    {
        private readonly IRepositorioBase<Vaga> _repositorio;
        private readonly INavegacaoService _navegacao;

        public ObservableCollection<Vaga> Vagas { get; set; }

        public MinhasVagasPage()
        {
            _navegacao = DependencyService.Get<INavegacaoService>();
            _repositorio = DependencyService.Get<IRepositorioBase<Vaga>>();
            InitializeComponent();

            Vagas = new ObservableCollection<Vaga>(_repositorio.Obter());
            ListaVagas.ItemsSource = Vagas;
        }

        private void Editar(object o, EventArgs e)
        {
            var editarVaga = ((o as Label).GestureRecognizers.First() as TapGestureRecognizer).CommandParameter as Vaga;
            _navegacao.NavegarPara(new EditarVagaPage(editarVaga));
        }

        private void Excluir(object o, EventArgs e)
        {
            var excluirVaga = ((o as Label).GestureRecognizers.First() as TapGestureRecognizer).CommandParameter as Vaga;
            _repositorio.Deletar(excluirVaga);
            Vagas.Remove(excluirVaga);
        }
        
        private void IrCadastro(object o, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void IrMinhasVagas(object o, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}