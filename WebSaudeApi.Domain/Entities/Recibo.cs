using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public partial class Recibo
    {
        public Recibo()
        {
            ProfissionalPagamento = new HashSet<ProfissionalPagamento>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<ProfissionalPagamento> ProfissionalPagamento { get; set; }
    }
}