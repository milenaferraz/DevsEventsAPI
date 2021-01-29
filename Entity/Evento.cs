using System;

namespace DevEventsAPI.Entity
{
    public class Evento
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public Categoria Categoria { get; set; }
        public Usuario Usuario{ get; set; }
    }
}
