using System;
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
