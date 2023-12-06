using System;
using System.Collections.Generic;

namespace MusicsAPI.Domains
{
    public partial class VersaoListum
    {
        public int Id { get; set; }
        public DateTime Criacao { get; set; }
        public int? ListaId { get; set; }

        public virtual Listum? Lista { get; set; }
    }
}
