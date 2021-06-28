﻿using System;
using System.Collections.Generic;

#nullable disable

namespace senai_SPMGwebAPI.Domains
{
    public partial class Clinica
    {
        public Clinica()
        {
            Medicos = new HashSet<Medico>();
        }

        public int IdClinica { get; set; }
        public string NomeClinica { get; set; }
        public string DataAbertura { get; set; }
        public TimeSpan HorarioAbertura { get; set; }
        public TimeSpan? HorarioFechamento { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public string Endereco { get; set; }

        public virtual ICollection<Medico> Medicos { get; set; }
    }
}
