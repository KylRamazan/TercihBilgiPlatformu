﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220616164632_duzeltme")]
    partial class duzeltme
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Concrete.Arkadas", b =>
                {
                    b.Property<int>("ArkadasID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.HasKey("ArkadasID");

                    b.HasIndex("KullaniciID");

                    b.ToTable("Arkadas");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Bolum", b =>
                {
                    b.Property<int>("BolumID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.Property<int?>("UniversiteID")
                        .HasColumnType("int");

                    b.HasKey("BolumID");

                    b.HasIndex("UniversiteID");

                    b.ToTable("Bolums");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Cevap", b =>
                {
                    b.Property<int>("CevapID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Icerik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<int?>("Puan")
                        .HasColumnType("int");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.Property<int?>("SoruId")
                        .HasColumnType("int");

                    b.HasKey("CevapID");

                    b.HasIndex("KullaniciID");

                    b.ToTable("Cevaps");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Etiket", b =>
                {
                    b.Property<int>("EtiketID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.HasKey("EtiketID");

                    b.ToTable("Etikets");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Kullanici", b =>
                {
                    b.Property<int>("KullaniciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BolumAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Cinsiyet")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("EMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("KullaniciAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Mezun")
                        .HasColumnType("bit");

                    b.Property<string>("OkulAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KullaniciID");

                    b.ToTable("Kullanicis");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Lise", b =>
                {
                    b.Property<int>("LiseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.HasKey("LiseID");

                    b.ToTable("Lises");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Mesaj", b =>
                {
                    b.Property<int>("MesajID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AlanKullaniciId")
                        .HasColumnType("int");

                    b.Property<string>("Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GonderenKullaniciId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Icerik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.HasKey("MesajID");

                    b.HasIndex("KullaniciID");

                    b.ToTable("Mesajs");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Sayfa", b =>
                {
                    b.Property<int>("SayfaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Adi")
                        .HasColumnType("int");

                    b.Property<int?>("AnaSayfaID")
                        .HasColumnType("int");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.Property<bool>("Url")
                        .HasColumnType("bit");

                    b.HasKey("SayfaID");

                    b.ToTable("Sayfas");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Soru", b =>
                {
                    b.Property<int>("SoruID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Icerik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.HasKey("SoruID");

                    b.HasIndex("KullaniciID");

                    b.ToTable("Sorus");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Universite", b =>
                {
                    b.Property<int>("UniversiteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.HasKey("UniversiteID");

                    b.ToTable("Universites");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Yetki", b =>
                {
                    b.Property<int>("YetkiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Adi")
                        .HasColumnType("int");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<bool>("Silindi")
                        .HasColumnType("bit");

                    b.HasKey("YetkiID");

                    b.HasIndex("KullaniciID");

                    b.ToTable("Yetkis");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Arkadas", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Kullanici", "Kullanici")
                        .WithMany("Arkadas")
                        .HasForeignKey("KullaniciID");

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Bolum", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Universite", "Universite")
                        .WithMany("Bolums")
                        .HasForeignKey("UniversiteID");

                    b.Navigation("Universite");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Cevap", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Kullanici", "Kullanici")
                        .WithMany("Cevaps")
                        .HasForeignKey("KullaniciID");

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Mesaj", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Kullanici", "Kullanici")
                        .WithMany("Mesajs")
                        .HasForeignKey("KullaniciID");

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Soru", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Kullanici", "Kullanici")
                        .WithMany("Sorus")
                        .HasForeignKey("KullaniciID");

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Yetki", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Kullanici", "Kullanici")
                        .WithMany("Yetkis")
                        .HasForeignKey("KullaniciID");

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Kullanici", b =>
                {
                    b.Navigation("Arkadas");

                    b.Navigation("Cevaps");

                    b.Navigation("Mesajs");

                    b.Navigation("Sorus");

                    b.Navigation("Yetkis");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Universite", b =>
                {
                    b.Navigation("Bolums");
                });
#pragma warning restore 612, 618
        }
    }
}
