using System;
using System.Collections.Generic;

#nullable disable

namespace senai_SPMGwebAPI.Domains
{
    public partial class Situaco
    {
        public Situaco()
        {
            Consulta = new HashSet<Consulta>();
        }

        public int IdSituacao { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Consulta> Consulta { get; set; }
    }
}
