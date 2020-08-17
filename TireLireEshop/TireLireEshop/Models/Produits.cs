using System;
using System.Collections.Generic;

namespace TireLireEshop
{
    public partial class Produits
    {
        public Produits()
        {
            Avis = new HashSet<Avis>();
            DetailsCommande = new HashSet<DetailsCommande>();
            Image = new HashSet<Image>();
        }

        public int PkIdProduit { get; set; }
        public string Nom { get; set; }
        public double Hauteur { get; set; }
        public double Largeur { get; set; }
        public double Longueur { get; set; }
        public double Poids { get; set; }
        public int CapacitéEnNombreDePiece { get; set; }
        public int IdFabricant { get; set; }
        public int IdCouleur { get; set; }
        public decimal Prix { get; set; }
        public string DescriptionParLeFabricant { get; set; }
        public int IdImage { get; set; }
        public bool StatutDActivtion { get; set; }

        public virtual Couleur IdCouleurNavigation { get; set; }
        public virtual Fabricant IdFabricantNavigation { get; set; }
        public virtual ICollection<Avis> Avis { get; set; }
        public virtual ICollection<DetailsCommande> DetailsCommande { get; set; }
        public virtual ICollection<Image> Image { get; set; }
    }
}
