using System;

namespace Integracao.Usuario.POC.Dto
{
    public class HospedeDto
    {
        public int HospedeId { get; set; }
        public int UsuarioId { get; set; }
        public string Documento { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Celular { get; set; }
        public DateTime DataDeCadastro { get; set; }
    }
}
