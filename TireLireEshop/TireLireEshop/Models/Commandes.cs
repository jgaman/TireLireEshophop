using System;
using System.Collections.Generic;

namespace TireLireEshop
{
    public partial class Commandes
    {
        public Commandes()
        {
            DetailsCommande = new HashSet<DetailsCommande>();
        }

        public int PkIdCommande { get; set; }
        public DateTime Date { get; set; }
        public int IdClient { get; set; }
        public int IdStatutCommande { get; set; }

        public virtual Clients IdClientNavigation { get; set; }
        public virtual StatutCommande IdStatutCommandeNavigation { get; set; }
        public virtual ICollection<DetailsCommande> DetailsCommande { get; set; }
    }
}
