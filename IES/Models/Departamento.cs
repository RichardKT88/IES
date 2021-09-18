namespace IES.Models
{
    public class Departamento
    {
        public long? DepartamentoId { get; set; }
        public string Nome { get; set; }
        public long? InstituicaoId { get; set; }
        public Instituicao Instituicao { get; set; }
    }
}
