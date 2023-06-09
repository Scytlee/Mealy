﻿// <auto-generated />
using System;
using Mealy.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Mealy.Persistence.Migrations
{
    [DbContext(typeof(MealyDbContext))]
    partial class MealyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Mealy.Domain.Meals.Entities.Meal", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOnUtc")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<double>("EnergyAmount")
                        .HasColumnType("decimal(9,4)");

                    b.Property<bool>("IsLatestVersion")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Recipe")
                        .HasMaxLength(4000)
                        .HasColumnType("nvarchar(4000)");

                    b.Property<long>("TypeId")
                        .HasColumnType("bigint");

                    b.HasKey("Id", "Version");

                    b.HasIndex("TypeId");

                    b.ToTable("Meal");
                });

            modelBuilder.Entity("Mealy.Domain.Meals.Entities.MealIngredient", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<double>("Amount")
                        .HasColumnType("decimal(9,4)");

                    b.Property<double>("EnergyAmount")
                        .HasColumnType("decimal(9,4)");

                    b.Property<long>("MealId")
                        .HasColumnType("bigint");

                    b.Property<int>("MealVersion")
                        .HasColumnType("int");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("MealId", "MealVersion");

                    b.ToTable("MealIngredient");
                });

            modelBuilder.Entity("Mealy.Domain.Meals.Entities.MealType", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<TimeSpan>("DefaultTime")
                        .HasColumnType("time");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("MealType");
                });

            modelBuilder.Entity("Mealy.Domain.Plans.Entities.Plan", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOnUtc")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("date");

                    b.Property<bool>("IsLatestVersion")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("Id", "Version");

                    b.ToTable("Plan");
                });

            modelBuilder.Entity("Mealy.Domain.Plans.Entities.PlanEnergyDefinition", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("date");

                    b.Property<int>("EnergyIntake")
                        .HasColumnType("int");

                    b.Property<long>("PlanId")
                        .HasColumnType("bigint");

                    b.Property<int>("PlanVersion")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("date");

                    b.Property<int?>("Weekdays")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlanId", "PlanVersion");

                    b.ToTable("PlanEnergyDefinition");
                });

            modelBuilder.Entity("Mealy.Domain.Plans.Entities.PlanMeal", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<double>("EnergyAmount")
                        .HasColumnType("decimal(9,4)");

                    b.Property<long>("MealId")
                        .HasColumnType("bigint");

                    b.Property<int>("MealVersion")
                        .HasColumnType("int");

                    b.Property<long>("PlanId")
                        .HasColumnType("bigint");

                    b.Property<int>("PlanVersion")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MealId", "MealVersion");

                    b.HasIndex("PlanId", "PlanVersion");

                    b.ToTable("PlanMeal");
                });

            modelBuilder.Entity("Mealy.Domain.Plans.Entities.PlanMealDefinition", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("date");

                    b.Property<long>("PlanId")
                        .HasColumnType("bigint");

                    b.Property<int>("PlanVersion")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("date");

                    b.Property<TimeSpan>("Time")
                        .HasColumnType("time");

                    b.Property<long>("TypeId")
                        .HasColumnType("bigint");

                    b.Property<int?>("Weekdays")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.HasIndex("PlanId", "PlanVersion");

                    b.ToTable("PlanMealDefinition");
                });

            modelBuilder.Entity("Mealy.Domain.Plans.Entities.PlanMealModification", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<double?>("Amount")
                        .HasColumnType("decimal(9,4)");

                    b.Property<long>("MealIngredientId")
                        .HasColumnType("bigint");

                    b.Property<long?>("NewIngredientId")
                        .HasColumnType("bigint");

                    b.Property<long>("PlanMealId")
                        .HasColumnType("bigint");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlanMealId");

                    b.ToTable("PlanMealModification");
                });

            modelBuilder.Entity("Mealy.Domain.Products.Entities.Product", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<long>("CategoryId")
                        .HasColumnType("bigint");

                    b.Property<double>("EnergyAmountInKcal")
                        .HasColumnType("decimal(9,4)");

                    b.Property<bool>("IncludeInShoppingLists")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Mealy.Domain.Products.Entities.ProductCategory", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<bool>("IncludeInShoppingLists")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("ProductCategory");
                });

            modelBuilder.Entity("Mealy.Domain.ShoppingLists.Entities.ShoppingList", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedOnUtc")
                        .HasPrecision(0)
                        .HasColumnType("datetime2(0)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("date");

                    b.Property<long>("PlanId")
                        .HasColumnType("bigint");

                    b.Property<int>("PlanVersion")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("ShoppingList");
                });

            modelBuilder.Entity("Mealy.Domain.ShoppingLists.Entities.ShoppingListProduct", b =>
                {
                    b.Property<long>("ShoppingListId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<double>("Amount")
                        .HasColumnType("decimal(9,4)");

                    b.HasKey("ShoppingListId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingListProduct");
                });

            modelBuilder.Entity("Mealy.Domain.Meals.Entities.Meal", b =>
                {
                    b.HasOne("Mealy.Domain.Meals.Entities.MealType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Mealy.Domain.Meals.Entities.MealIngredient", b =>
                {
                    b.HasOne("Mealy.Domain.Products.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mealy.Domain.Meals.Entities.Meal", null)
                        .WithMany("Ingredients")
                        .HasForeignKey("MealId", "MealVersion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Mealy.Domain.Plans.Entities.PlanEnergyDefinition", b =>
                {
                    b.HasOne("Mealy.Domain.Plans.Entities.Plan", null)
                        .WithMany("EnergyDefinitions")
                        .HasForeignKey("PlanId", "PlanVersion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Mealy.Domain.Plans.Entities.PlanMeal", b =>
                {
                    b.HasOne("Mealy.Domain.Meals.Entities.Meal", "Meal")
                        .WithMany()
                        .HasForeignKey("MealId", "MealVersion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mealy.Domain.Plans.Entities.Plan", null)
                        .WithMany("Meals")
                        .HasForeignKey("PlanId", "PlanVersion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meal");
                });

            modelBuilder.Entity("Mealy.Domain.Plans.Entities.PlanMealDefinition", b =>
                {
                    b.HasOne("Mealy.Domain.Meals.Entities.MealType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mealy.Domain.Plans.Entities.Plan", null)
                        .WithMany("MealDefinitions")
                        .HasForeignKey("PlanId", "PlanVersion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Mealy.Domain.Plans.Entities.PlanMealModification", b =>
                {
                    b.HasOne("Mealy.Domain.Plans.Entities.PlanMeal", null)
                        .WithMany("Modifications")
                        .HasForeignKey("PlanMealId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Mealy.Domain.Products.Entities.Product", b =>
                {
                    b.HasOne("Mealy.Domain.Products.Entities.ProductCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Mealy.Domain.ShoppingLists.Entities.ShoppingListProduct", b =>
                {
                    b.HasOne("Mealy.Domain.Products.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mealy.Domain.ShoppingLists.Entities.ShoppingList", null)
                        .WithMany("Products")
                        .HasForeignKey("ShoppingListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Mealy.Domain.Meals.Entities.Meal", b =>
                {
                    b.Navigation("Ingredients");
                });

            modelBuilder.Entity("Mealy.Domain.Plans.Entities.Plan", b =>
                {
                    b.Navigation("EnergyDefinitions");

                    b.Navigation("MealDefinitions");

                    b.Navigation("Meals");
                });

            modelBuilder.Entity("Mealy.Domain.Plans.Entities.PlanMeal", b =>
                {
                    b.Navigation("Modifications");
                });

            modelBuilder.Entity("Mealy.Domain.ShoppingLists.Entities.ShoppingList", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
