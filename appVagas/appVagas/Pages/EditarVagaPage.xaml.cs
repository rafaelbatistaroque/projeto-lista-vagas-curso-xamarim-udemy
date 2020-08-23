using appVagas.Modelos;
using appVagas.Repositorios.Interfaces;
using appVagas.Servicos.Interfaces;
using appVagas.Utils.Enums;
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
    public partial class EditarVagaPage : ContentPage
    {
        private readonly IRepositorioBase<Vaga> _repositorio;
        private readonly INavegacaoService _navegacao;
        private readonly Vaga _vaga;

        public EditarVagaPage(Vaga vaga)
        {
            _navegacao = DependencyService.Get<INavegacaoService>();
            _repositorio = DependencyService.Get<IRepositorioBase<Vaga>>();
            InitializeComponent();
            _vaga = vaga;

            NomeVaga.Text = _vaga.NomeVaga;
            Empresa.Text = _vaga.Empresa;
            Quantidade.Text = _vaga.QuantidadeVaga.ToString();
            Cidade.Text = _vaga.Cidade;
            Salario.Text = _vaga.Salario.ToString();
            TipoContratacao.IsToggled = _vaga.TipoContratacao == ETipoContratacao.CLT;
            Telefone.Text = _vaga.Telefone;
            Email.Text = _vaga.Email;
        }

        public void SalvarVaga(object s, EventArgs e)
        {
            _vaga.NomeVaga = NomeVaga.Text;
            _vaga.QuantidadeVaga = short.Parse(Quantidade.Text);
            _vaga.Salario = double.Parse(Salario.Text);
            _vaga.Empresa = Empresa.Text;
            _vaga.Cidade = Cidade.Text;
            _vaga.Descricao = Descricao.Text;
            _vaga.TipoContratacao = TipoContratacao.IsToggled ? ETipoContratacao.PJ : ETipoContratacao.CLT;
            _vaga.Telefone = Telefone.Text;
            _vaga.Email = Email.Text;

            _repositorio.Atualizar(_vaga);

            _navegacao.NavegarPara(new MinhasVagasPage());
        }
    }
}