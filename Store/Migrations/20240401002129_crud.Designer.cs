﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Store.data;

#nullable disable

namespace Store.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240401002129_crud")]
    partial class crud
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Store.Model.Att_Produit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProduitId")
                        .HasColumnType("int");

                    b.Property<string>("Valeur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProduitId");

                    b.ToTable("att_produits");
                });

            modelBuilder.Entity("Store.Model.Att_Variante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Valeur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VarianteId")
                        .HasColumnType("int");

                    b.Property<string>("cle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("VarianteId");

                    b.ToTable("att_variantes");
                });

            modelBuilder.Entity("Store.Model.Client", b =>
                {
                    b.Property<int>("IdClient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdClient"), 1L, 1);

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PointsFidelite")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdClient");

                    b.ToTable("clients");
                });

            modelBuilder.Entity("Store.Model.Commande", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCommande")
                        .HasColumnType("datetime2");

                    b.Property<string>("Etat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("commandes");
                });

            modelBuilder.Entity("Store.Model.Favorit", b =>
                {
                    b.Property<int>("IdFavoris")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdFavoris"), 1L, 1);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("ProduitId")
                        .HasColumnType("int");

                    b.HasKey("IdFavoris");

                    b.HasIndex("ClientId");

                    b.HasIndex("ProduitId");

                    b.ToTable("Favorits");
                });

            modelBuilder.Entity("Store.Model.LigneCommande", b =>
                {
                    b.Property<int>("IdLigneCommande")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLigneCommande"), 1L, 1);

                    b.Property<int>("CommandeId")
                        .HasColumnType("int");

                    b.Property<double>("ProduitUnitaire")
                        .HasColumnType("float");

                    b.Property<int>("Quantite")
                        .HasColumnType("int");

                    b.Property<int>("VarianteId")
                        .HasColumnType("int");

                    b.HasKey("IdLigneCommande");

                    b.HasIndex("CommandeId");

                    b.HasIndex("VarianteId");

                    b.ToTable("ligneCommandes");
                });

            modelBuilder.Entity("Store.Model.LignePanier", b =>
                {
                    b.Property<int>("IdLignePanier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLignePanier"), 1L, 1);

                    b.Property<int>("PanierId")
                        .HasColumnType("int");

                    b.Property<int>("Quantite")
                        .HasColumnType("int");

                    b.Property<int>("VarianteId")
                        .HasColumnType("int");

                    b.HasKey("IdLignePanier");

                    b.HasIndex("PanierId");

                    b.HasIndex("VarianteId")
                        .IsUnique();

                    b.ToTable("LignePanier");
                });

            modelBuilder.Entity("Store.Model.Paiement", b =>
                {
                    b.Property<int>("IdPaiement")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPaiement"), 1L, 1);

                    b.Property<int>("CommandeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatePaimenet")
                        .HasColumnType("datetime2");

                    b.Property<double>("Montant")
                        .HasColumnType("float");

                    b.Property<string>("modePaiement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPaiement");

                    b.HasIndex("CommandeId")
                        .IsUnique();

                    b.ToTable("Paiement");
                });

            modelBuilder.Entity("Store.Model.Panier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId")
                        .IsUnique();

                    b.ToTable("paniers");
                });

            modelBuilder.Entity("Store.Model.PhotoProduit", b =>
                {
                    b.Property<int>("PhotoProduitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhotoProduitId"), 1L, 1);

                    b.Property<int>("ProduitId")
                        .HasColumnType("int");

                    b.Property<string>("UrlImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhotoProduitId");

                    b.HasIndex("ProduitId");

                    b.ToTable("photoProduits");
                });

            modelBuilder.Entity("Store.Model.PhotoVariante", b =>
                {
                    b.Property<int>("IdPhoto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPhoto"), 1L, 1);

                    b.Property<string>("UrlImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VarianteId")
                        .HasColumnType("int");

                    b.HasKey("IdPhoto");

                    b.HasIndex("VarianteId");

                    b.ToTable("photoVariantes");
                });

            modelBuilder.Entity("Store.Model.Produit", b =>
                {
                    b.Property<int>("IdProduit")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProduit"), 1L, 1);

                    b.Property<double>("Prix")
                        .HasColumnType("float");

                    b.Property<int>("QteStock")
                        .HasColumnType("int");

                    b.HasKey("IdProduit");

                    b.ToTable("produits");
                });

            modelBuilder.Entity("Store.Model.Reclamation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CommandeId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CommandeId");

                    b.ToTable("Reclamations");
                });

            modelBuilder.Entity("Store.Model.Retour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Commentaire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateRetour")
                        .HasColumnType("datetime2");

                    b.Property<int>("LigneCommandeId")
                        .HasColumnType("int");

                    b.Property<string>("TypeRetour")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LigneCommandeId");

                    b.ToTable("Retour");
                });

            modelBuilder.Entity("Store.Model.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Commentaire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Note")
                        .HasColumnType("int");

                    b.Property<int>("VarianteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("VarianteId");

                    b.ToTable("reviews");
                });

            modelBuilder.Entity("Store.Model.Variante", b =>
                {
                    b.Property<int>("IdVariante")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdVariante"), 1L, 1);

                    b.Property<double>("Prix")
                        .HasColumnType("float");

                    b.Property<int>("ProduitId")
                        .HasColumnType("int");

                    b.Property<int>("QteStock")
                        .HasColumnType("int");

                    b.HasKey("IdVariante");

                    b.HasIndex("ProduitId");

                    b.ToTable("Variante");
                });

            modelBuilder.Entity("Store.Model.Att_Produit", b =>
                {
                    b.HasOne("Store.Model.Produit", "Produit")
                        .WithMany()
                        .HasForeignKey("ProduitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produit");
                });

            modelBuilder.Entity("Store.Model.Att_Variante", b =>
                {
                    b.HasOne("Store.Model.Variante", "Variante")
                        .WithMany("AttVs")
                        .HasForeignKey("VarianteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Variante");
                });

            modelBuilder.Entity("Store.Model.Commande", b =>
                {
                    b.HasOne("Store.Model.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Store.Model.Favorit", b =>
                {
                    b.HasOne("Store.Model.Client", "Client")
                        .WithMany("Favorits")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Store.Model.Produit", "Produit")
                        .WithMany("Favorits")
                        .HasForeignKey("ProduitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Produit");
                });

            modelBuilder.Entity("Store.Model.LigneCommande", b =>
                {
                    b.HasOne("Store.Model.Commande", "Commande")
                        .WithMany("LCs")
                        .HasForeignKey("CommandeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Store.Model.Variante", "Variante")
                        .WithMany("LCs")
                        .HasForeignKey("VarianteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Commande");

                    b.Navigation("Variante");
                });

            modelBuilder.Entity("Store.Model.LignePanier", b =>
                {
                    b.HasOne("Store.Model.Panier", "Panier")
                        .WithMany("LPs")
                        .HasForeignKey("PanierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Store.Model.Variante", "Variante")
                        .WithOne("LignesPanier")
                        .HasForeignKey("Store.Model.LignePanier", "VarianteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Panier");

                    b.Navigation("Variante");
                });

            modelBuilder.Entity("Store.Model.Paiement", b =>
                {
                    b.HasOne("Store.Model.Commande", "commande")
                        .WithOne("paiement")
                        .HasForeignKey("Store.Model.Paiement", "CommandeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("commande");
                });

            modelBuilder.Entity("Store.Model.Panier", b =>
                {
                    b.HasOne("Store.Model.Client", "Client")
                        .WithOne("Panier")
                        .HasForeignKey("Store.Model.Panier", "ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Store.Model.PhotoProduit", b =>
                {
                    b.HasOne("Store.Model.Produit", "Produit")
                        .WithMany("PPs")
                        .HasForeignKey("ProduitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produit");
                });

            modelBuilder.Entity("Store.Model.PhotoVariante", b =>
                {
                    b.HasOne("Store.Model.Variante", "Variante")
                        .WithMany("PVs")
                        .HasForeignKey("VarianteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Variante");
                });

            modelBuilder.Entity("Store.Model.Reclamation", b =>
                {
                    b.HasOne("Store.Model.Commande", "Commande")
                        .WithMany("Recs")
                        .HasForeignKey("CommandeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Commande");
                });

            modelBuilder.Entity("Store.Model.Retour", b =>
                {
                    b.HasOne("Store.Model.LigneCommande", "LigneCommande")
                        .WithMany("retours")
                        .HasForeignKey("LigneCommandeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LigneCommande");
                });

            modelBuilder.Entity("Store.Model.Review", b =>
                {
                    b.HasOne("Store.Model.Client", "Client")
                        .WithMany("Reviews")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Store.Model.Variante", "Variante")
                        .WithMany("Reviews")
                        .HasForeignKey("VarianteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Variante");
                });

            modelBuilder.Entity("Store.Model.Variante", b =>
                {
                    b.HasOne("Store.Model.Produit", "Produit")
                        .WithMany("Variantes")
                        .HasForeignKey("ProduitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produit");
                });

            modelBuilder.Entity("Store.Model.Client", b =>
                {
                    b.Navigation("Favorits");

                    b.Navigation("Panier")
                        .IsRequired();

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Store.Model.Commande", b =>
                {
                    b.Navigation("LCs");

                    b.Navigation("Recs");

                    b.Navigation("paiement")
                        .IsRequired();
                });

            modelBuilder.Entity("Store.Model.LigneCommande", b =>
                {
                    b.Navigation("retours");
                });

            modelBuilder.Entity("Store.Model.Panier", b =>
                {
                    b.Navigation("LPs");
                });

            modelBuilder.Entity("Store.Model.Produit", b =>
                {
                    b.Navigation("Favorits");

                    b.Navigation("PPs");

                    b.Navigation("Variantes");
                });

            modelBuilder.Entity("Store.Model.Variante", b =>
                {
                    b.Navigation("AttVs");

                    b.Navigation("LCs");

                    b.Navigation("LignesPanier")
                        .IsRequired();

                    b.Navigation("PVs");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
