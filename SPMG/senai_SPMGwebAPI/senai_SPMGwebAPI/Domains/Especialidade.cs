using System;
using System.Collections.Generic;

#nullable disable

namespace senai_SPMGwebAPI.Domains
{
    public partial class Especialidade
    {
        public Especialidade()
        {
            Medicos = new HashSet<Medico>();
        }

        public int IdEspecialidade { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Medico> Medicos { get; set; }
    }
}
