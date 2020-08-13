using System;
using System.Collections.Generic;

namespace TireLireEshop
{
    public partial class Avis
    {
        public int PkIdAvis { get; set; }
        public int IdClient { get; set; }
        public int IdProduit { get; set; }
        public string Contenu { get; set; }
        public bool StatutValidation { get; set; }

        public virtual Clients IdClientNavigation { get; set; }
        public virtual Produits IdProduitNavigation { get; set; }
    }
}
