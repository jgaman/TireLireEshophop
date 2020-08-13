using System;
using System.Collections.Generic;

namespace TireLireEshop
{
    public partial class Fabricant
    {
        public Fabricant()
        {
            Produits = new HashSet<Produits>();
        }

        public int PkIdFabricant { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }

        public virtual ICollection<Produits> Produits { get; set; }
    }
}
