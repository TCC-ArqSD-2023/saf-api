using GisaDominio.Entidades;
using GisaDominio.Enum;

namespace SafAPI.DTO
{
    public class PrestadorDTO
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public SexoEnum Sexo { get; set; }
        public string NumeroDocumentoProfissional { get; set; }
        public long EspecialidadeID { get; set; }
        public string? EspecialidadeNome { get; set; }
        public long EnderecoAtendimentoId { get; set; }
        public Endereco? EnderecoAtendimento { get; set; }
        public string Telefone { get; set; }
    }
}
