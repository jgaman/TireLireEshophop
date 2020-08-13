using System;
using System.Collections.Generic;

namespace TireLireEshop
{
    public partial class Couleur
    {
        public Couleur()
        {
            Produits = new HashSet<Produits>();
        }

        public int PkIdCouleur { get; set; }
        public string Nom { get; set; }

        public virtual ICollection<Produits> Produits { get; set; }
    }
}
