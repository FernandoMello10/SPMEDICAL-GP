using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace senai_SPMGwebAPI.Domains
{
    /// <summary>
    /// Classe que representa a entitade (tabela) de tipos Usuario
    /// </summary>
    public partial class TiposUsuario
    {
        public TiposUsuario()
        {
            Usuarios = new HashSet<Usuario>();
        }
        //Define que o campo é obrigatorio 
        [Required(ErrorMessage ="O titulo do tipo evento é obrigatorio!")]
        public int IdTipoUsuario { get; set; }
        public string NomeTipo { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
