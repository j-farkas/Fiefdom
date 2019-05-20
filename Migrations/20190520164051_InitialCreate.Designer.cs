﻿// <auto-generated />
using Fiefdom.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fiefdom.Migrations
{
    [DbContext(typeof(FiefdomContext))]
    [Migration("20190520164051_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("Fiefdom.Models.Fiefdom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("SessionId");

                    b.HasKey("Id");

                    b.ToTable("Fiefdom");
                });

            modelBuilder.Entity("Fiefdom.Models.FiefdomPlot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FiefdomId");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("FiefdomId");

                    b.ToTable("FiefdomPlot");
                });

            modelBuilder.Entity("Fiefdom.Models.FiefdomResources", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FiefdomId");

                    b.Property<string>("Quanity");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("FiefdomId");

                    b.ToTable("FiefdomResources");
                });

            modelBuilder.Entity("Fiefdom.Models.GameState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CurrentDay");

                    b.HasKey("Id");

                    b.ToTable("GameState");
                });

            modelBuilder.Entity("Fiefdom.Models.Market", b =>
                {
                    b.Property<string>("Type")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(255);

                    b.Property<int>("Price");

                    b.HasKey("Type");

                    b.ToTable("Market");
                });

            modelBuilder.Entity("Fiefdom.Models.FiefdomPlot", b =>
                {
                    b.HasOne("Fiefdom.Models.Fiefdom")
                        .WithMany("FiefdomPlot")
                        .HasForeignKey("FiefdomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Fiefdom.Models.FiefdomResources", b =>
                {
                    b.HasOne("Fiefdom.Models.Fiefdom")
                        .WithMany("FiefdomResources")
                        .HasForeignKey("FiefdomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
