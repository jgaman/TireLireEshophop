using System;
using System.Collections.Generic;

namespace TireLireEshop
{
    public partial class Clients
    {
        public Clients()
        {
            Avis = new HashSet<Avis>();
            Commandes = new HashSet<Commandes>();
        }

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public bool StatutDuCompte { get; set; }
        public int PkIdClient { get; set; }

        public virtual ICollection<Avis> Avis { get; set; }
        public virtual ICollection<Commandes> Commandes { get; set; }
    }
}
