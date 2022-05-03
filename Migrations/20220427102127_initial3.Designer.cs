﻿// <auto-generated />
using MajestyApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MajestyApi.Migrations
{
    [DbContext(typeof(MajestyApiContext))]
    [Migration("20220427102127_initial3")]
    partial class initial3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MajestyApi.Models.Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("MajestyApi.Models.Storie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Plot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Upvotes")
                        .HasColumnType("int");

                    b.Property<string>("Writer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Storie");
                });

            modelBuilder.Entity("MajestyApi.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Age = 42,
                            Email = "jhon.tapanez@gmail.com",
                            FirstName = "Jhon",
                            Grade = 4,
                            LastName = "Tapanez"
                        },
                        new
                        {
                            ID = 2,
                            Age = 49,
                            Email = "juliet.lee@gmail.com",
                            FirstName = "Juliet",
                            Grade = 5,
                            LastName = "Lee"
                        },
                        new
                        {
                            ID = 3,
                            Age = 21,
                            Email = "marcos.doe@gmail.com",
                            FirstName = "Marcos",
                            Grade = 4,
                            LastName = "Doe"
                        },
                        new
                        {
                            ID = 4,
                            Age = 49,
                            Email = "brayan.fernandez@gmail.com",
                            FirstName = "Brayan",
                            Grade = 1,
                            LastName = "Fernandez"
                        },
                        new
                        {
                            ID = 5,
                            Age = 17,
                            Email = "carlos.stampton@gmail.com",
                            FirstName = "Carlos",
                            Grade = 3,
                            LastName = "Stampton"
                        },
                        new
                        {
                            ID = 6,
                            Age = 59,
                            Email = "marcos.doe@gmail.com",
                            FirstName = "Marcos",
                            Grade = 1,
                            LastName = "Doe"
                        },
                        new
                        {
                            ID = 7,
                            Age = 28,
                            Email = "brayan.fernandez@gmail.com",
                            FirstName = "Brayan",
                            Grade = 3,
                            LastName = "Fernandez"
                        },
                        new
                        {
                            ID = 8,
                            Age = 43,
                            Email = "juliet.fernandez@gmail.com",
                            FirstName = "Juliet",
                            Grade = 1,
                            LastName = "Fernandez"
                        },
                        new
                        {
                            ID = 9,
                            Age = 53,
                            Email = "juliet.garcia@gmail.com",
                            FirstName = "Juliet",
                            Grade = 1,
                            LastName = "Garcia"
                        },
                        new
                        {
                            ID = 10,
                            Age = 37,
                            Email = "juliet.stampton@gmail.com",
                            FirstName = "Juliet",
                            Grade = 5,
                            LastName = "Stampton"
                        },
                        new
                        {
                            ID = 11,
                            Age = 33,
                            Email = "carlos.doe@gmail.com",
                            FirstName = "Carlos",
                            Grade = 6,
                            LastName = "Doe"
                        },
                        new
                        {
                            ID = 12,
                            Age = 29,
                            Email = "jhon.doe@gmail.com",
                            FirstName = "Jhon",
                            Grade = 5,
                            LastName = "Doe"
                        },
                        new
                        {
                            ID = 13,
                            Age = 30,
                            Email = "tedd.garcia@gmail.com",
                            FirstName = "Tedd",
                            Grade = 3,
                            LastName = "Garcia"
                        },
                        new
                        {
                            ID = 14,
                            Age = 57,
                            Email = "juliet.stampton@gmail.com",
                            FirstName = "Juliet",
                            Grade = 6,
                            LastName = "Stampton"
                        },
                        new
                        {
                            ID = 15,
                            Age = 29,
                            Email = "juliet.garcia@gmail.com",
                            FirstName = "Juliet",
                            Grade = 4,
                            LastName = "Garcia"
                        },
                        new
                        {
                            ID = 16,
                            Age = 51,
                            Email = "carlos.fernandez@gmail.com",
                            FirstName = "Carlos",
                            Grade = 3,
                            LastName = "Fernandez"
                        },
                        new
                        {
                            ID = 17,
                            Age = 45,
                            Email = "carlos.hernandez@gmail.com",
                            FirstName = "Carlos",
                            Grade = 5,
                            LastName = "Hernandez"
                        },
                        new
                        {
                            ID = 18,
                            Age = 19,
                            Email = "carlos.lee@gmail.com",
                            FirstName = "Carlos",
                            Grade = 5,
                            LastName = "Lee"
                        },
                        new
                        {
                            ID = 19,
                            Age = 57,
                            Email = "jhon.fernandez@gmail.com",
                            FirstName = "Jhon",
                            Grade = 5,
                            LastName = "Fernandez"
                        },
                        new
                        {
                            ID = 20,
                            Age = 11,
                            Email = "miguel.doe@gmail.com",
                            FirstName = "Miguel",
                            Grade = 1,
                            LastName = "Doe"
                        },
                        new
                        {
                            ID = 21,
                            Age = 12,
                            Email = "jhon.stampton@gmail.com",
                            FirstName = "Jhon",
                            Grade = 3,
                            LastName = "Stampton"
                        },
                        new
                        {
                            ID = 22,
                            Age = 16,
                            Email = "juliet.hernandez@gmail.com",
                            FirstName = "Juliet",
                            Grade = 2,
                            LastName = "Hernandez"
                        },
                        new
                        {
                            ID = 23,
                            Age = 16,
                            Email = "miguel.tapanez@gmail.com",
                            FirstName = "Miguel",
                            Grade = 3,
                            LastName = "Tapanez"
                        },
                        new
                        {
                            ID = 24,
                            Age = 23,
                            Email = "tedd.doe@gmail.com",
                            FirstName = "Tedd",
                            Grade = 2,
                            LastName = "Doe"
                        },
                        new
                        {
                            ID = 25,
                            Age = 35,
                            Email = "brayan.doe@gmail.com",
                            FirstName = "Brayan",
                            Grade = 6,
                            LastName = "Doe"
                        },
                        new
                        {
                            ID = 26,
                            Age = 22,
                            Email = "tedd.stampton@gmail.com",
                            FirstName = "Tedd",
                            Grade = 4,
                            LastName = "Stampton"
                        },
                        new
                        {
                            ID = 27,
                            Age = 23,
                            Email = "tedd.stampton@gmail.com",
                            FirstName = "Tedd",
                            Grade = 3,
                            LastName = "Stampton"
                        },
                        new
                        {
                            ID = 28,
                            Age = 25,
                            Email = "miguel.hernandez@gmail.com",
                            FirstName = "Miguel",
                            Grade = 6,
                            LastName = "Hernandez"
                        },
                        new
                        {
                            ID = 29,
                            Age = 34,
                            Email = "carlos.hernandez@gmail.com",
                            FirstName = "Carlos",
                            Grade = 6,
                            LastName = "Hernandez"
                        },
                        new
                        {
                            ID = 30,
                            Age = 35,
                            Email = "brayan.fernandez@gmail.com",
                            FirstName = "Brayan",
                            Grade = 2,
                            LastName = "Fernandez"
                        },
                        new
                        {
                            ID = 31,
                            Age = 14,
                            Email = "jhon.garcia@gmail.com",
                            FirstName = "Jhon",
                            Grade = 4,
                            LastName = "Garcia"
                        },
                        new
                        {
                            ID = 32,
                            Age = 36,
                            Email = "miguel.lee@gmail.com",
                            FirstName = "Miguel",
                            Grade = 1,
                            LastName = "Lee"
                        },
                        new
                        {
                            ID = 33,
                            Age = 34,
                            Email = "jhon.stampton@gmail.com",
                            FirstName = "Jhon",
                            Grade = 4,
                            LastName = "Stampton"
                        },
                        new
                        {
                            ID = 34,
                            Age = 46,
                            Email = "carlos.doe@gmail.com",
                            FirstName = "Carlos",
                            Grade = 2,
                            LastName = "Doe"
                        },
                        new
                        {
                            ID = 35,
                            Age = 17,
                            Email = "tedd.fernandez@gmail.com",
                            FirstName = "Tedd",
                            Grade = 3,
                            LastName = "Fernandez"
                        },
                        new
                        {
                            ID = 36,
                            Age = 40,
                            Email = "juliet.stampton@gmail.com",
                            FirstName = "Juliet",
                            Grade = 3,
                            LastName = "Stampton"
                        },
                        new
                        {
                            ID = 37,
                            Age = 54,
                            Email = "miguel.hernandez@gmail.com",
                            FirstName = "Miguel",
                            Grade = 1,
                            LastName = "Hernandez"
                        },
                        new
                        {
                            ID = 38,
                            Age = 59,
                            Email = "carlos.fernandez@gmail.com",
                            FirstName = "Carlos",
                            Grade = 5,
                            LastName = "Fernandez"
                        },
                        new
                        {
                            ID = 39,
                            Age = 50,
                            Email = "carlos.fernandez@gmail.com",
                            FirstName = "Carlos",
                            Grade = 6,
                            LastName = "Fernandez"
                        },
                        new
                        {
                            ID = 40,
                            Age = 58,
                            Email = "miguel.stampton@gmail.com",
                            FirstName = "Miguel",
                            Grade = 3,
                            LastName = "Stampton"
                        },
                        new
                        {
                            ID = 41,
                            Age = 26,
                            Email = "jhon.hernandez@gmail.com",
                            FirstName = "Jhon",
                            Grade = 6,
                            LastName = "Hernandez"
                        },
                        new
                        {
                            ID = 42,
                            Age = 26,
                            Email = "marcos.stampton@gmail.com",
                            FirstName = "Marcos",
                            Grade = 3,
                            LastName = "Stampton"
                        },
                        new
                        {
                            ID = 43,
                            Age = 34,
                            Email = "carlos.hernandez@gmail.com",
                            FirstName = "Carlos",
                            Grade = 5,
                            LastName = "Hernandez"
                        },
                        new
                        {
                            ID = 44,
                            Age = 20,
                            Email = "brayan.hernandez@gmail.com",
                            FirstName = "Brayan",
                            Grade = 3,
                            LastName = "Hernandez"
                        },
                        new
                        {
                            ID = 45,
                            Age = 10,
                            Email = "marcos.stampton@gmail.com",
                            FirstName = "Marcos",
                            Grade = 3,
                            LastName = "Stampton"
                        },
                        new
                        {
                            ID = 46,
                            Age = 36,
                            Email = "juliet.garcia@gmail.com",
                            FirstName = "Juliet",
                            Grade = 5,
                            LastName = "Garcia"
                        },
                        new
                        {
                            ID = 47,
                            Age = 13,
                            Email = "marcos.stampton@gmail.com",
                            FirstName = "Marcos",
                            Grade = 2,
                            LastName = "Stampton"
                        },
                        new
                        {
                            ID = 48,
                            Age = 46,
                            Email = "tedd.lee@gmail.com",
                            FirstName = "Tedd",
                            Grade = 5,
                            LastName = "Lee"
                        },
                        new
                        {
                            ID = 49,
                            Age = 24,
                            Email = "carlos.stampton@gmail.com",
                            FirstName = "Carlos",
                            Grade = 5,
                            LastName = "Stampton"
                        },
                        new
                        {
                            ID = 50,
                            Age = 42,
                            Email = "tedd.stampton@gmail.com",
                            FirstName = "Tedd",
                            Grade = 6,
                            LastName = "Stampton"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
