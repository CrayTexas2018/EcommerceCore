using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CoreEcommerce.Models;

namespace CoreEcommerce.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20170805192656_remove company and user from request model")]
    partial class removecompanyanduserfromrequestmodel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("CoreEcommerce.Models.Request", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("body");

                    b.Property<string>("created");

                    b.Property<string>("method");

                    b.Property<string>("url");

                    b.HasKey("id");

                    b.ToTable("Requests");
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
        }
    }
}
