﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vdab.Aanwezigheidslijst.EF;

namespace Vdab.Aanwezigheidslijst.EF.Migrations
{
    [DbContext(typeof(AanwezigheidslijstDBContext))]
    partial class AanwezigheidslijstDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Vdab.Aanwezigheidslijst.EF.Model.Docent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bedrijf")
                        .IsRequired();

                    b.Property<string>("Naam")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Docenten");
                });
#pragma warning restore 612, 618
        }
    }
}