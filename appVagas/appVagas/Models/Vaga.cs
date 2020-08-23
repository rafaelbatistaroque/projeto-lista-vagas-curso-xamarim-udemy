using appVagas.Utils.Enums;
using SQLite;

namespace appVagas.Modelos
{
    [Table("Vaga")]
    public class Vaga
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string NomeVaga { get; set; }
        public short QuantidadeVaga { get; set; }
        public string Empresa { get; set; }
        public string Cidade { get; set; }
        public double Salario { get; set; }
        public string Descricao { get; set; }
        public ETipoContratacao TipoContratacao { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
