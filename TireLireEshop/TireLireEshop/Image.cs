using System;
using System.Collections.Generic;

namespace TireLireEshop
{
    public partial class Image
    {
        public int PkIdImage { get; set; }
        public int IdProduit { get; set; }
        public string CheminDAcces { get; set; }

        public virtual Produits IdProduitNavigation { get; set; }
    }
}
