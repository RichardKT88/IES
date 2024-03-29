using System.Collections.Generic;

namespace IES.Models
{
    public class Instituicao
    {
        public long? InstituicaoId { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public virtual ICollection<Departamento> Departamentos { get; set; }
    }
}