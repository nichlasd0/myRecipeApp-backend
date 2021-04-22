﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using recipeapp_backend.Data;

namespace recipeapp_backend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("recipeapp_backend.Models.Ingredients", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Amount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RecipesId")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IngredientId");

                    b.HasIndex("RecipesId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("recipeapp_backend.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OrderStep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RecipesId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("RecipesId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("recipeapp_backend.Models.Recipes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("recipeapp_backend.Models.Ingredients", b =>
                {
                    b.HasOne("recipeapp_backend.Models.Recipes", "Recipes")
                        .WithMany("Ingredientses")
                        .HasForeignKey("RecipesId");

                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("recipeapp_backend.Models.Order", b =>
                {
                    b.HasOne("recipeapp_backend.Models.Recipes", "Recipes")
                        .WithMany("Orders")
                        .HasForeignKey("RecipesId");

                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("recipeapp_backend.Models.Recipes", b =>
                {
                    b.Navigation("Ingredientses");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
