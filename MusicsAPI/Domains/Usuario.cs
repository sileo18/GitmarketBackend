using System;
using System.Collections.Generic;

namespace MusicsAPI.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Lista = new HashSet<Listum>();
        }

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string Email { get; set; } = null!;
        public string Senha { get; set; } = null!;

        public virtual ICollection<Listum> Lista { get; set; }
    }
}
