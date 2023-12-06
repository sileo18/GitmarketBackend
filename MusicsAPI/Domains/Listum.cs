using System;
using System.Collections.Generic;

namespace MusicsAPI.Domains
{
    public partial class Listum
    {
        public Listum()
        {
            Items = new HashSet<Item>();
            VersaoLista = new HashSet<VersaoListum>();
            Usuarios = new HashSet<Usuario>();
        }

        public int Id { get; set; }
        public string? Nome { get; set; }
        public DateTime? DataCriacao { get; set; }

        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<VersaoListum> VersaoLista { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
