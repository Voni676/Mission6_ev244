﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6_ev244.Models;

namespace Mission6_ev244.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission6_ev244.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lent_To")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Category = "Action",
                            Director = "Brian De Palma",
                            Edited = true,
                            Lent_To = "Siko",
                            Notes = "First One",
                            Rating = "PG-13",
                            Title = "Mission Impossible 1",
                            Year = 1996
                        },
                        new
                        {
                            MovieId = 2,
                            Category = "Action",
                            Director = "John Woo",
                            Edited = false,
                            Lent_To = "Toko",
                            Notes = "Scratched",
                            Rating = "PG-13",
                            Title = "Mission Impossible 2",
                            Year = 2000
                        },
                        new
                        {
                            MovieId = 3,
                            Category = "Action",
                            Director = "J. J. Abrams",
                            Edited = false,
                            Lent_To = "Loho",
                            Notes = "Yups",
                            Rating = "PG-13",
                            Title = "Mission Impossible 3",
                            Year = 2006
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
