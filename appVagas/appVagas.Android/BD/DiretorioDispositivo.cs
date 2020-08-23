using appVagas.Android.BD;
using appVagas.BD;
using appVagas.BD.Interfaces;
using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(DiretorioDispositivo))]
namespace appVagas.Android.BD
{
    public class DiretorioDispositivo : IDiretorioDispositivo
    {
        public string ObterDiretorioSalvamento(string nomeBanco)
        {
            string diretorioRaiz = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string diretorioDeSalvamento = Path.Combine(diretorioRaiz, nomeBanco);
            bool diretorioExiste = Directory.Exists(diretorioDeSalvamento);

            if (diretorioExiste)
                Directory.CreateDirectory(diretorioDeSalvamento);

            return diretorioDeSalvamento;
        }
    }
}
