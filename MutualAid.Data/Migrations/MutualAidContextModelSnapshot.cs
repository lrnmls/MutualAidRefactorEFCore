﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MutualAid.Data.Context;

namespace MutualAid.Data.Migrations
{
    [DbContext(typeof(MutualAidContext))]
    partial class MutualAidContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MutualAid.Data.Entities.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Allergens")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bread")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CannedFood")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cereal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Conditioner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dairy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Disinfectant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HandSoap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAccepted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Meat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pantry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaperTowels")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Produce")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Seafood")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shampoo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToiletPaper")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Toothpaste")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("MutualAid.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("County")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isAdmin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            County = "Franklin",
                            Created = new DateTime(2020, 7, 28, 15, 6, 11, 818, DateTimeKind.Local).AddTicks(7257),
                            Email = "lauren.miles@kizan.com",
                            FirstName = "Lauren",
                            LastName = "Miles",
                            Password = "cbpwtZPsJD3FWtBrCS37LF8NMKc=",
                            PhoneNumber = "9373291424",
                            Salt = "ItM0F+lRxK4=",
                            isAdmin = true
                        });
                });

            modelBuilder.Entity("MutualAid.Data.Entities.Request", b =>
                {
                    b.HasOne("MutualAid.Data.Entities.User", "User")
                        .WithMany("Requests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
