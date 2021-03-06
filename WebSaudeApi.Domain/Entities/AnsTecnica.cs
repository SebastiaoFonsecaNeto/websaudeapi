using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class AnsTecnica
    {
        public AnsTecnica()
        {
            GuiaTissProcedimento = new HashSet<GuiaTissProcedimento>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public int? TermoTiss { get; set; }
        public virtual ICollection<GuiaTissProcedimento> GuiaTissProcedimento { get; set; }
    }
}