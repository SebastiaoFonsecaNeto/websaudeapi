using System.Collections.Generic;

namespace WebSaude.Domain.Entities
{
    public class AnsGrauParticipacao
    {
        public AnsGrauParticipacao()
        {
            GuiaTissProfissional = new HashSet<GuiaTissProfissional>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public int? TermoTiss { get; set; }
        public virtual ICollection<GuiaTissProfissional> GuiaTissProfissional { get; set; }
    }
}