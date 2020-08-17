using System;
using System.Collections.Generic;

namespace TireLireEshop
{
    public partial class DetailsCommande
    {
        public int PkIdDetailsCommande { get; set; }
        public int IdCommande { get; set; }
        public int IdProduit { get; set; }
        public int Quantité { get; set; }
        public decimal Prix { get; set; }

        public virtual Commandes IdCommandeNavigation { get; set; }
        public virtual Produits IdProduitNavigation { get; set; }
    }
}
