using System;
using System.Collections.Generic;

namespace MusicsAPI.Domains
{
    public partial class Item
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string? Descricao { get; set; }
        public string? StatusItem { get; set; }
        public int? ListaId { get; set; }

        public virtual Listum? Lista { get; set; }
    }
}
