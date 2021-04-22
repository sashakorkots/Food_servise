﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Food_servise.Migrations
{
    [DbContext(typeof(RazorPagesContext))]
    [Migration("20210422202635_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("RazorPages.Models.Courier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text")
                        .HasColumnName("phone_number");

                    b.HasKey("Id")
                        .HasName("pk_courier");

                    b.ToTable("courier");
                });

            modelBuilder.Entity("RazorPages.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("text")
                        .HasColumnName("address");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text")
                        .HasColumnName("phone_number");

                    b.HasKey("Id")
                        .HasName("pk_customer");

                    b.ToTable("customer");
                });

            modelBuilder.Entity("RazorPages.Models.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric")
                        .HasColumnName("price");

                    b.Property<string>("SpeedOfCooking")
                        .HasColumnType("text")
                        .HasColumnName("speed_of_cooking");

                    b.Property<string>("TypeOfDish")
                        .HasColumnType("text")
                        .HasColumnName("type_of_dish");

                    b.HasKey("Id")
                        .HasName("pk_dish");

                    b.ToTable("dish");
                });

            modelBuilder.Entity("RazorPages.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("DishId")
                        .HasColumnType("integer")
                        .HasColumnName("dish_id");

                    b.Property<int>("RestrantId")
                        .HasColumnType("integer")
                        .HasColumnName("restrant_id");

                    b.HasKey("Id")
                        .HasName("pk_menu");

                    b.HasIndex("DishId")
                        .HasDatabaseName("ix_menu_dish_id");

                    b.HasIndex("RestrantId")
                        .HasDatabaseName("ix_menu_restrant_id");

                    b.ToTable("menu");
                });

            modelBuilder.Entity("RazorPages.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer")
                        .HasColumnName("customer_id");

                    b.HasKey("Id")
                        .HasName("pk_order");

                    b.HasIndex("CustomerId")
                        .HasDatabaseName("ix_order_customer_id");

                    b.ToTable("order");
                });

            modelBuilder.Entity("RazorPages.Models.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CourierId")
                        .HasColumnType("integer")
                        .HasColumnName("courier_id");

                    b.Property<int>("RestrantId")
                        .HasColumnType("integer")
                        .HasColumnName("restrant_id");

                    b.HasKey("Id")
                        .HasName("pk_region");

                    b.HasIndex("CourierId")
                        .HasDatabaseName("ix_region_courier_id");

                    b.HasIndex("RestrantId")
                        .HasDatabaseName("ix_region_restrant_id");

                    b.ToTable("region");
                });

            modelBuilder.Entity("RazorPages.Models.Restrant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("text")
                        .HasColumnName("address");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text")
                        .HasColumnName("phone_number");

                    b.HasKey("Id")
                        .HasName("pk_restrant");

                    b.ToTable("restrant");
                });

            modelBuilder.Entity("RazorPages.Models.Menu", b =>
                {
                    b.HasOne("RazorPages.Models.Dish", "DishOfMenu")
                        .WithMany()
                        .HasForeignKey("DishId")
                        .HasConstraintName("fk_menu_dish_dish_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RazorPages.Models.Restrant", "RestrantOfMenu")
                        .WithMany()
                        .HasForeignKey("RestrantId")
                        .HasConstraintName("fk_menu_restrant_restrant_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DishOfMenu");

                    b.Navigation("RestrantOfMenu");
                });

            modelBuilder.Entity("RazorPages.Models.Order", b =>
                {
                    b.HasOne("RazorPages.Models.Customer", "CustomerOfDish")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("fk_order_customer_customer_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerOfDish");
                });

            modelBuilder.Entity("RazorPages.Models.Region", b =>
                {
                    b.HasOne("RazorPages.Models.Courier", "CourierOfRegion")
                        .WithMany("RegionOfCourier")
                        .HasForeignKey("CourierId")
                        .HasConstraintName("fk_region_courier_courier_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RazorPages.Models.Restrant", "RestrantOfRegion")
                        .WithMany("RegionOfRestrant")
                        .HasForeignKey("RestrantId")
                        .HasConstraintName("fk_region_restrant_restrant_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourierOfRegion");

                    b.Navigation("RestrantOfRegion");
                });

            modelBuilder.Entity("RazorPages.Models.Courier", b =>
                {
                    b.Navigation("RegionOfCourier");
                });

            modelBuilder.Entity("RazorPages.Models.Restrant", b =>
                {
                    b.Navigation("RegionOfRestrant");
                });
#pragma warning restore 612, 618
        }
    }
}
