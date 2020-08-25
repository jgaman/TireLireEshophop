using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TireLireEshop.Migrations
{
    public partial class creationDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    PK_ID_client = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(maxLength: 50, nullable: false),
                    prenom = table.Column<string>(maxLength: 50, nullable: false),
                    email = table.Column<string>(nullable: false),
                    statut_du_compte = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.PK_ID_client);
                });

            migrationBuilder.CreateTable(
                name: "Couleur",
                columns: table => new
                {
                    PK_ID_couleur = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Couleur", x => x.PK_ID_couleur);
                });

            migrationBuilder.CreateTable(
                name: "Fabricant",
                columns: table => new
                {
                    PK_ID_fabricant = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(maxLength: 50, nullable: false),
                    adresse = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fabricant", x => x.PK_ID_fabricant);
                });

            migrationBuilder.CreateTable(
                name: "Statut_commande",
                columns: table => new
                {
                    PK_ID_statut_commande = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    statut_commande = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statut_commande", x => x.PK_ID_statut_commande);
                });

            migrationBuilder.CreateTable(
                name: "Produits",
                columns: table => new
                {
                    PK_ID_produit = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(maxLength: 50, nullable: false),
                    hauteur = table.Column<double>(nullable: false),
                    largeur = table.Column<double>(nullable: false),
                    longueur = table.Column<double>(nullable: false),
                    poids = table.Column<double>(nullable: false),
                    capacité_en_nombre_de_piece = table.Column<int>(nullable: false),
                    ID_fabricant = table.Column<int>(nullable: false),
                    ID_couleur = table.Column<int>(nullable: false),
                    prix = table.Column<decimal>(type: "money", nullable: false),
                    description_par_le_fabricant = table.Column<string>(nullable: false),
                    ID_image = table.Column<int>(nullable: false),
                    statut_d_activtion = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produits", x => x.PK_ID_produit);
                    table.ForeignKey(
                        name: "FK_Produits_Couleur",
                        column: x => x.ID_couleur,
                        principalTable: "Couleur",
                        principalColumn: "PK_ID_couleur",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Produits_Fabricant",
                        column: x => x.ID_fabricant,
                        principalTable: "Fabricant",
                        principalColumn: "PK_ID_fabricant",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Commandes",
                columns: table => new
                {
                    PK_ID_commande = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime", nullable: false),
                    ID_client = table.Column<int>(nullable: false),
                    ID_statut_commande = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commandes", x => x.PK_ID_commande);
                    table.ForeignKey(
                        name: "FK_Commandes_Clients",
                        column: x => x.ID_client,
                        principalTable: "Clients",
                        principalColumn: "PK_ID_client",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Commandes_Statut_commande",
                        column: x => x.ID_statut_commande,
                        principalTable: "Statut_commande",
                        principalColumn: "PK_ID_statut_commande",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Avis",
                columns: table => new
                {
                    PK_ID_avis = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_client = table.Column<int>(nullable: false),
                    ID_produit = table.Column<int>(nullable: false),
                    contenu = table.Column<string>(maxLength: 50, nullable: true),
                    statut_validation = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avis", x => x.PK_ID_avis);
                    table.ForeignKey(
                        name: "FK_Avis_Clients",
                        column: x => x.ID_client,
                        principalTable: "Clients",
                        principalColumn: "PK_ID_client",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Avis_Produits",
                        column: x => x.ID_produit,
                        principalTable: "Produits",
                        principalColumn: "PK_ID_produit",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    PK_ID_image = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_produit = table.Column<int>(nullable: false),
                    chemin_d_acces = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.PK_ID_image);
                    table.ForeignKey(
                        name: "FK_Image_Produits",
                        column: x => x.ID_produit,
                        principalTable: "Produits",
                        principalColumn: "PK_ID_produit",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Details_commande",
                columns: table => new
                {
                    PK_ID_details_commande = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_commande = table.Column<int>(nullable: false),
                    ID_produit = table.Column<int>(nullable: false),
                    quantité = table.Column<int>(nullable: false),
                    prix = table.Column<decimal>(type: "decimal(18, 0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details_commande", x => x.PK_ID_details_commande);
                    table.ForeignKey(
                        name: "FK_Details_commande_Commandes",
                        column: x => x.ID_commande,
                        principalTable: "Commandes",
                        principalColumn: "PK_ID_commande",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Details_commande_Produits",
                        column: x => x.ID_produit,
                        principalTable: "Produits",
                        principalColumn: "PK_ID_produit",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Avis_ID_client",
                table: "Avis",
                column: "ID_client");

            migrationBuilder.CreateIndex(
                name: "IX_Avis_ID_produit",
                table: "Avis",
                column: "ID_produit");

            migrationBuilder.CreateIndex(
                name: "IX_Commandes_ID_client",
                table: "Commandes",
                column: "ID_client");

            migrationBuilder.CreateIndex(
                name: "IX_Commandes_ID_statut_commande",
                table: "Commandes",
                column: "ID_statut_commande");

            migrationBuilder.CreateIndex(
                name: "IX_Details_commande_ID_commande",
                table: "Details_commande",
                column: "ID_commande");

            migrationBuilder.CreateIndex(
                name: "IX_Details_commande_ID_produit",
                table: "Details_commande",
                column: "ID_produit");

            migrationBuilder.CreateIndex(
                name: "IX_Image_ID_produit",
                table: "Image",
                column: "ID_produit");

            migrationBuilder.CreateIndex(
                name: "IX_Produits_ID_couleur",
                table: "Produits",
                column: "ID_couleur");

            migrationBuilder.CreateIndex(
                name: "IX_Produits_ID_fabricant",
                table: "Produits",
                column: "ID_fabricant");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Avis");

            migrationBuilder.DropTable(
                name: "Details_commande");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Commandes");

            migrationBuilder.DropTable(
                name: "Produits");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Statut_commande");

            migrationBuilder.DropTable(
                name: "Couleur");

            migrationBuilder.DropTable(
                name: "Fabricant");
        }
    }
}
