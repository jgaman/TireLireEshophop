using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TireLireEshop
{
    public partial class dbtirelireshopContext : DbContext
    {
        public dbtirelireshopContext()
        {
        }

        public dbtirelireshopContext(DbContextOptions<dbtirelireshopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Avis> Avis { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Commandes> Commandes { get; set; }
        public virtual DbSet<Couleur> Couleur { get; set; }
        public virtual DbSet<DetailsCommande> DetailsCommande { get; set; }
        public virtual DbSet<Fabricant> Fabricant { get; set; }
        public virtual DbSet<Image> Image { get; set; }
        public virtual DbSet<Produits> Produits { get; set; }
        public virtual DbSet<StatutCommande> StatutCommande { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=VisualGaman\\SQLEXPRESS;Initial Catalog=dbtirelireshop;Integrated Security=True; Pooling=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Avis>(entity =>
            {
                entity.HasKey(e => e.PkIdAvis);

                entity.Property(e => e.PkIdAvis).HasColumnName("PK_ID_avis");

                entity.Property(e => e.Contenu)
                    .HasColumnName("contenu")
                    .HasMaxLength(50);

                entity.Property(e => e.IdClient).HasColumnName("ID_client");

                entity.Property(e => e.IdProduit).HasColumnName("ID_produit");

                entity.Property(e => e.StatutValidation).HasColumnName("statut_validation");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Avis)
                    .HasForeignKey(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Avis_Clients");

                entity.HasOne(d => d.IdProduitNavigation)
                    .WithMany(p => p.Avis)
                    .HasForeignKey(d => d.IdProduit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Avis_Produits");
            });

            modelBuilder.Entity<Clients>(entity =>
            {
                entity.HasKey(e => e.PkIdClient);

                entity.Property(e => e.PkIdClient).HasColumnName("PK_ID_client");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasColumnName("nom")
                    .HasMaxLength(50);

                entity.Property(e => e.Prenom)
                    .IsRequired()
                    .HasColumnName("prenom")
                    .HasMaxLength(50);

                entity.Property(e => e.StatutDuCompte).HasColumnName("statut_du_compte");
            });

            modelBuilder.Entity<Commandes>(entity =>
            {
                entity.HasKey(e => e.PkIdCommande);

                entity.Property(e => e.PkIdCommande).HasColumnName("PK_ID_commande");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdClient).HasColumnName("ID_client");

                entity.Property(e => e.IdStatutCommande).HasColumnName("ID_statut_commande");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Commandes)
                    .HasForeignKey(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Commandes_Clients");

                entity.HasOne(d => d.IdStatutCommandeNavigation)
                    .WithMany(p => p.Commandes)
                    .HasForeignKey(d => d.IdStatutCommande)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Commandes_Statut_commande");
            });

            modelBuilder.Entity<Couleur>(entity =>
            {
                entity.HasKey(e => e.PkIdCouleur);

                entity.Property(e => e.PkIdCouleur).HasColumnName("PK_ID_couleur");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasColumnName("nom")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DetailsCommande>(entity =>
            {
                entity.HasKey(e => e.PkIdDetailsCommande);

                entity.ToTable("Details_commande");

                entity.Property(e => e.PkIdDetailsCommande).HasColumnName("PK_ID_details_commande");

                entity.Property(e => e.IdCommande).HasColumnName("ID_commande");

                entity.Property(e => e.IdProduit).HasColumnName("ID_produit");

                entity.Property(e => e.Prix)
                    .HasColumnName("prix")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Quantité).HasColumnName("quantité");

                entity.HasOne(d => d.IdCommandeNavigation)
                    .WithMany(p => p.DetailsCommande)
                    .HasForeignKey(d => d.IdCommande)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Details_commande_Commandes");

                entity.HasOne(d => d.IdProduitNavigation)
                    .WithMany(p => p.DetailsCommande)
                    .HasForeignKey(d => d.IdProduit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Details_commande_Produits");
            });

            modelBuilder.Entity<Fabricant>(entity =>
            {
                entity.HasKey(e => e.PkIdFabricant);

                entity.Property(e => e.PkIdFabricant).HasColumnName("PK_ID_fabricant");

                entity.Property(e => e.Adresse)
                    .IsRequired()
                    .HasColumnName("adresse")
                    .HasMaxLength(50);

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasColumnName("nom")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.HasKey(e => e.PkIdImage);

                entity.Property(e => e.PkIdImage).HasColumnName("PK_ID_image");

                entity.Property(e => e.CheminDAcces)
                    .IsRequired()
                    .HasColumnName("chemin_d_acces");

                entity.Property(e => e.IdProduit).HasColumnName("ID_produit");

                entity.HasOne(d => d.IdProduitNavigation)
                    .WithMany(p => p.Image)
                    .HasForeignKey(d => d.IdProduit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Image_Produits");
            });

            modelBuilder.Entity<Produits>(entity =>
            {
                entity.HasKey(e => e.PkIdProduit);

                entity.Property(e => e.PkIdProduit).HasColumnName("PK_ID_produit");

                entity.Property(e => e.CapacitéEnNombreDePiece).HasColumnName("capacité_en_nombre_de_piece");

                entity.Property(e => e.DescriptionParLeFabricant)
                    .IsRequired()
                    .HasColumnName("description_par_le_fabricant");

                entity.Property(e => e.Hauteur).HasColumnName("hauteur");

                entity.Property(e => e.IdCouleur).HasColumnName("ID_couleur");

                entity.Property(e => e.IdFabricant).HasColumnName("ID_fabricant");

                entity.Property(e => e.IdImage).HasColumnName("ID_image");

                entity.Property(e => e.Largeur).HasColumnName("largeur");

                entity.Property(e => e.Longueur).HasColumnName("longueur");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasColumnName("nom")
                    .HasMaxLength(50);

                entity.Property(e => e.Poids).HasColumnName("poids");

                entity.Property(e => e.Prix)
                    .HasColumnName("prix")
                    .HasColumnType("money");

                entity.Property(e => e.StatutDActivtion).HasColumnName("statut_d_activtion");

                entity.HasOne(d => d.IdCouleurNavigation)
                    .WithMany(p => p.Produits)
                    .HasForeignKey(d => d.IdCouleur)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Produits_Couleur");

                entity.HasOne(d => d.IdFabricantNavigation)
                    .WithMany(p => p.Produits)
                    .HasForeignKey(d => d.IdFabricant)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Produits_Fabricant");
            });

            modelBuilder.Entity<StatutCommande>(entity =>
            {
                entity.HasKey(e => e.PkIdStatutCommande);

                entity.ToTable("Statut_commande");

                entity.Property(e => e.PkIdStatutCommande).HasColumnName("PK_ID_statut_commande");

                entity.Property(e => e.StatutCommande1)
                    .IsRequired()
                    .HasColumnName("statut_commande")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
