using GisaDominio.Entidades;

namespace SafAPI.DTO
{
    public class ConveniadoDTO
    {
        public string Nome { get; set; }
        public virtual Endereco? Endereco { get; set; }
        public string Telefone { get; set; }

        public long EnderecoId { get; set; }
    }
}
