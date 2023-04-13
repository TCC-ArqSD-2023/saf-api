using GisaDominio.Entidades;
using GisaDominio.Enum;

namespace SafAPI.DTO
{
    public class AssociadoDTO
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public EstadoCivilEnum EstadoCivil { get; set; }
        public SexoEnum Sexo { get; set; }
        public UfEnum Naturalidade { get; set; }
        public string NaturalidadeCidade { get; set; }
        public string NumeroDocumento { get; set; }
        public UfEnum UfDocumento { get; set; }
        public string OrgaoDocumento { get; set; }
        public DateTime DataEmissaoDocumento { get; set; }
        public string NomeMae { get; set; }
        public string? NomePai { get; set; }
        public virtual Endereco? Endereco { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public SituacaoAssociadoEnum Situacao { get; set; }
        public virtual Plano? Plano { get; set; }

        public long EnderecoId { get; set; }
        public long? PlanoId { get; set; }
    }
}
