﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CoreEcommerce.Models;

namespace CoreEcommerce.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreEcommerce.Models.Company", b =>
                {
                    b.Property<int>("companyId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("created");

                    b.Property<string>("name");

                    b.Property<DateTime>("updated");

                    b.HasKey("companyId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("CoreEcommerce.Models.Employee", b =>
                {
                    b.Property<int>("employeeID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("active");

                    b.Property<int?>("companyId");

                    b.Property<bool>("created");

                    b.Property<string>("email");

                    b.Property<string>("password");

                    b.HasKey("employeeID");

                    b.HasIndex("companyId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("CoreEcommerce.Models.LogRequest", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("body");

                    b.Property<DateTime>("created");

                    b.Property<string>("method");

                    b.Property<string>("url");

                    b.HasKey("id");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("CoreEcommerce.Models.LogResponse", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("body");

                    b.Property<DateTime>("created");

                    b.HasKey("id");

                    b.ToTable("Responses");
                });

            modelBuilder.Entity("CoreEcommerce.Models.Product", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("active");

                    b.Property<decimal>("cogs");

                    b.Property<DateTime>("created");

                    b.Property<decimal>("declaredValue");

                    b.Property<string>("description");

                    b.Property<bool>("digital");

                    b.Property<string>("digitalUrl");

                    b.Property<int>("maxQuantity");

                    b.Property<string>("name");

                    b.Property<decimal>("price");

                    b.Property<int>("recurringProductId");

                    b.Property<decimal>("restockingFee");

                    b.Property<bool>("shipping");

                    b.Property<string>("sku");

                    b.Property<bool>("subscription");

                    b.Property<DateTime>("updated");

                    b.Property<decimal>("weight");

                    b.HasKey("productId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CoreEcommerce.Models.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AFFID")
                        .HasMaxLength(255);

                    b.Property<string>("AFID")
                        .HasMaxLength(255);

                    b.Property<string>("AID")
                        .HasMaxLength(255);

                    b.Property<string>("C1")
                        .HasMaxLength(255);

                    b.Property<string>("C2")
                        .HasMaxLength(255);

                    b.Property<string>("C3")
                        .HasMaxLength(255);

                    b.Property<string>("OPT")
                        .HasMaxLength(255);

                    b.Property<string>("SID")
                        .HasMaxLength(255);

                    b.Property<string>("billingAddress1")
                        .HasMaxLength(64);

                    b.Property<string>("billingAddress2")
                        .HasMaxLength(64);

                    b.Property<string>("billingCity")
                        .HasMaxLength(32);

                    b.Property<string>("billingCountry")
                        .HasMaxLength(2);

                    b.Property<string>("billingFirstName")
                        .HasMaxLength(64);

                    b.Property<string>("billingLastName")
                        .HasMaxLength(64);

                    b.Property<string>("billingState")
                        .HasMaxLength(32);

                    b.Property<int>("billingZip");

                    b.Property<string>("click_id")
                        .HasMaxLength(255);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(96);

                    b.Property<string>("firstName")
                        .HasMaxLength(64);

                    b.Property<string>("ipAddress")
                        .HasMaxLength(15);

                    b.Property<string>("lastName")
                        .HasMaxLength(64);

                    b.Property<string>("password")
                        .HasMaxLength(255);

                    b.Property<int>("phone");

                    b.Property<int>("prospectId");

                    b.Property<string>("shippingAddress1")
                        .HasMaxLength(64);

                    b.Property<string>("shippingAddress2")
                        .HasMaxLength(64);

                    b.Property<string>("shippingCity")
                        .HasMaxLength(32);

                    b.Property<string>("shippingCountry")
                        .HasMaxLength(2);

                    b.Property<string>("shippingState")
                        .HasMaxLength(32);

                    b.Property<int>("shippingZip");

                    b.HasKey("userId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CoreEcommerce.Models.Employee", b =>
                {
                    b.HasOne("CoreEcommerce.Models.Company")
                        .WithMany("employees")
                        .HasForeignKey("companyId");
                });
        }
    }
}
