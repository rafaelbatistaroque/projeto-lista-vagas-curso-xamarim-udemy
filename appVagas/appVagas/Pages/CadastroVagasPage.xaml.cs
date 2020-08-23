using appVagas.Modelos;
using appVagas.Modelos.ValuesObject;
using appVagas.Repositorios;
using appVagas.Repositorios.Interfaces;
using appVagas.Servicos.Interfaces;
using appVagas.Utils.Enums;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appVagas.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroVagasPage : ContentPage
    {
        private readonly IRepositorioBase<Vaga> _repositorio;
        private readonly INavegacaoService _navegacao;
        public CadastroVagasPage(Vaga vaga = null)
        {
            _repositorio = DependencyService.Get<IRepositorioBase<Vaga>>();
            _navegacao = DependencyService.Get<INavegacaoService>();
            InitializeComponent();
        }

        private void SalvarVaga(object o, EventArgs e)
        {
            Telefone telefone = new Telefone(67, Telefone.Text);
            Email email = new Email(Email.Text);

            Vaga vaga = new Vaga
            {
                NomeVaga = NomeVaga.Text,
                QuantidadeVaga = short.Parse(Quantidade.Text),
                Salario = double.Parse(Salario.Text),
                Empresa = Empresa.Text,
                Cidade = Cidade.Text,
                Descricao = Descricao.Text,
                TipoContratacao = TipoContratacao.IsToggled ? ETipoContratacao.PJ : ETipoContratacao.CLT,
                Telefone = telefone.ToString(),
                Email = email.ToString()
            };

            _repositorio.Cadastrar(vaga);
            _navegacao.VotarPaginaRaizAtualizada();
        }
    }
}