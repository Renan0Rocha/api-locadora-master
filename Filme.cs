using System.ComponentModel.DataAnnotations.Schema;

namespace ApiLocadora
{
    [Table("filmes")]
    public class Filme
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("Genero")]
        public string Genero { get; set; }
        [Column("ano_lancamento")]
        public DateOnly? AnoLancamento { get; set; }
    }
}
