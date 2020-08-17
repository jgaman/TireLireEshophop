using System;
using System.Collections.Generic;

namespace TireLireEshop
{
    public partial class StatutCommande
    {
        public StatutCommande()
        {
            Commandes = new HashSet<Commandes>();
        }

        public int PkIdStatutCommande { get; set; }
        public string StatutCommande1 { get; set; }

        public virtual ICollection<Commandes> Commandes { get; set; }
    }
}
