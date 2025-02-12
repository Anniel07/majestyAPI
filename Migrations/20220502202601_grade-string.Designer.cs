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
    [Migration("20220502202601_grade-string")]
    partial class gradestring
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
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

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Age = 52,
                            Email = "tedd.doe@gmail.com",
                            FirstName = "Tedd",
                            Grade = "5th",
                            LastName = "Doe"
                        },
                        new
                        {
                            ID = 2,
                            Age = 54,
                            Email = "brayan.lee@gmail.com",
                            FirstName = "Brayan",
                            Grade = "1st",
                            LastName = "Lee"
                        },
                        new
                        {
                            ID = 3,
                            Age = 24,
                            Email = "marcos.tapanez@gmail.com",
                            FirstName = "Marcos",
                            Grade = "2nd",
                            LastName = "Tapanez"
                        },
                        new
                        {
                            ID = 4,
                            Age = 13,
                            Email = "juliet.fernandez@gmail.com",
                            FirstName = "Juliet",
                            Grade = "4th",
                            LastName = "Fernandez"
                        },
                        new
                        {
                            ID = 5,
                            Age = 29,
                            Email = "jhon.garcia@gmail.com",
                            FirstName = "Jhon",
                            Grade = "3rd",
                            LastName = "Garcia"
                        },
                        new
                        {
                            ID = 6,
                            Age = 37,
                            Email = "jhon.garcia@gmail.com",
                            FirstName = "Jhon",
                            Grade = "1st",
                            LastName = "Garcia"
                        },
                        new
                        {
                            ID = 7,
                            Age = 16,
                            Email = "tedd.doe@gmail.com",
                            FirstName = "Tedd",
                            Grade = "5th",
                            LastName = "Doe"
                        },
                        new
                        {
                            ID = 8,
                            Age = 24,
                            Email = "carlos.fernandez@gmail.com",
                            FirstName = "Carlos",
                            Grade = "6th",
                            LastName = "Fernandez"
                        },
                        new
                        {
                            ID = 9,
                            Age = 24,
                            Email = "carlos.stampton@gmail.com",
                            FirstName = "Carlos",
                            Grade = "1st",
                            LastName = "Stampton"
                        },
                        new
                        {
                            ID = 10,
                            Age = 17,
                            Email = "jhon.doe@gmail.com",
                            FirstName = "Jhon",
                            Grade = "2nd",
                            LastName = "Doe"
                        },
                        new
                        {
                            ID = 11,
                            Age = 45,
                            Email = "marcos.doe@gmail.com",
                            FirstName = "Marcos",
                            Grade = "1st",
                            LastName = "Doe"
                        },
                        new
                        {
                            ID = 12,
                            Age = 58,
                            Email = "jhon.garcia@gmail.com",
                            FirstName = "Jhon",
                            Grade = "4th",
                            LastName = "Garcia"
                        },
                        new
                        {
                            ID = 13,
                            Age = 12,
                            Email = "brayan.doe@gmail.com",
                            FirstName = "Brayan",
                            Grade = "4th",
                            LastName = "Doe"
                        },
                        new
                        {
                            ID = 14,
                            Age = 21,
                            Email = "jhon.hernandez@gmail.com",
                            FirstName = "Jhon",
                            Grade = "6th",
                            LastName = "Hernandez"
                        },
                        new
                        {
                            ID = 15,
                            Age = 30,
                            Email = "carlos.lee@gmail.com",
                            FirstName = "Carlos",
                            Grade = "1st",
                            LastName = "Lee"
                        },
                        new
                        {
                            ID = 16,
                            Age = 38,
                            Email = "miguel.doe@gmail.com",
                            FirstName = "Miguel",
                            Grade = "3rd",
                            LastName = "Doe"
                        },
                        new
                        {
                            ID = 17,
                            Age = 47,
                            Email = "miguel.fernandez@gmail.com",
                            FirstName = "Miguel",
                            Grade = "2nd",
                            LastName = "Fernandez"
                        },
                        new
                        {
                            ID = 18,
                            Age = 32,
                            Email = "jhon.tapanez@gmail.com",
                            FirstName = "Jhon",
                            Grade = "1st",
                            LastName = "Tapanez"
                        },
                        new
                        {
                            ID = 19,
                            Age = 37,
                            Email = "tedd.hernandez@gmail.com",
                            FirstName = "Tedd",
                            Grade = "6th",
                            LastName = "Hernandez"
                        },
                        new
                        {
                            ID = 20,
                            Age = 12,
                            Email = "marcos.garcia@gmail.com",
                            FirstName = "Marcos",
                            Grade = "6th",
                            LastName = "Garcia"
                        },
                        new
                        {
                            ID = 21,
                            Age = 42,
                            Email = "brayan.garcia@gmail.com",
                            FirstName = "Brayan",
                            Grade = "3rd",
                            LastName = "Garcia"
                        },
                        new
                        {
                            ID = 22,
                            Age = 52,
                            Email = "tedd.stampton@gmail.com",
                            FirstName = "Tedd",
                            Grade = "3rd",
                            LastName = "Stampton"
                        },
                        new
                        {
                            ID = 23,
                            Age = 43,
                            Email = "tedd.garcia@gmail.com",
                            FirstName = "Tedd",
                            Grade = "2nd",
                            LastName = "Garcia"
                        },
                        new
                        {
                            ID = 24,
                            Age = 39,
                            Email = "miguel.hernandez@gmail.com",
                            FirstName = "Miguel",
                            Grade = "5th",
                            LastName = "Hernandez"
                        },
                        new
                        {
                            ID = 25,
                            Age = 35,
                            Email = "carlos.fernandez@gmail.com",
                            FirstName = "Carlos",
                            Grade = "5th",
                            LastName = "Fernandez"
                        },
                        new
                        {
                            ID = 26,
                            Age = 40,
                            Email = "miguel.stampton@gmail.com",
                            FirstName = "Miguel",
                            Grade = "2nd",
                            LastName = "Stampton"
                        },
                        new
                        {
                            ID = 27,
                            Age = 23,
                            Email = "miguel.tapanez@gmail.com",
                            FirstName = "Miguel",
                            Grade = "6th",
                            LastName = "Tapanez"
                        },
                        new
                        {
                            ID = 28,
                            Age = 59,
                            Email = "miguel.hernandez@gmail.com",
                            FirstName = "Miguel",
                            Grade = "1st",
                            LastName = "Hernandez"
                        },
                        new
                        {
                            ID = 29,
                            Age = 52,
                            Email = "marcos.garcia@gmail.com",
                            FirstName = "Marcos",
                            Grade = "1st",
                            LastName = "Garcia"
                        },
                        new
                        {
                            ID = 30,
                            Age = 12,
                            Email = "carlos.hernandez@gmail.com",
                            FirstName = "Carlos",
                            Grade = "6th",
                            LastName = "Hernandez"
                        },
                        new
                        {
                            ID = 31,
                            Age = 54,
                            Email = "carlos.fernandez@gmail.com",
                            FirstName = "Carlos",
                            Grade = "4th",
                            LastName = "Fernandez"
                        },
                        new
                        {
                            ID = 32,
                            Age = 30,
                            Email = "brayan.hernandez@gmail.com",
                            FirstName = "Brayan",
                            Grade = "2nd",
                            LastName = "Hernandez"
                        },
                        new
                        {
                            ID = 33,
                            Age = 36,
                            Email = "miguel.lee@gmail.com",
                            FirstName = "Miguel",
                            Grade = "4th",
                            LastName = "Lee"
                        },
                        new
                        {
                            ID = 34,
                            Age = 19,
                            Email = "juliet.fernandez@gmail.com",
                            FirstName = "Juliet",
                            Grade = "3rd",
                            LastName = "Fernandez"
                        },
                        new
                        {
                            ID = 35,
                            Age = 47,
                            Email = "juliet.fernandez@gmail.com",
                            FirstName = "Juliet",
                            Grade = "3rd",
                            LastName = "Fernandez"
                        },
                        new
                        {
                            ID = 36,
                            Age = 47,
                            Email = "tedd.tapanez@gmail.com",
                            FirstName = "Tedd",
                            Grade = "1st",
                            LastName = "Tapanez"
                        },
                        new
                        {
                            ID = 37,
                            Age = 34,
                            Email = "carlos.stampton@gmail.com",
                            FirstName = "Carlos",
                            Grade = "1st",
                            LastName = "Stampton"
                        },
                        new
                        {
                            ID = 38,
                            Age = 23,
                            Email = "tedd.garcia@gmail.com",
                            FirstName = "Tedd",
                            Grade = "2nd",
                            LastName = "Garcia"
                        },
                        new
                        {
                            ID = 39,
                            Age = 20,
                            Email = "brayan.stampton@gmail.com",
                            FirstName = "Brayan",
                            Grade = "2nd",
                            LastName = "Stampton"
                        },
                        new
                        {
                            ID = 40,
                            Age = 10,
                            Email = "marcos.doe@gmail.com",
                            FirstName = "Marcos",
                            Grade = "3rd",
                            LastName = "Doe"
                        },
                        new
                        {
                            ID = 41,
                            Age = 25,
                            Email = "carlos.doe@gmail.com",
                            FirstName = "Carlos",
                            Grade = "5th",
                            LastName = "Doe"
                        },
                        new
                        {
                            ID = 42,
                            Age = 15,
                            Email = "miguel.garcia@gmail.com",
                            FirstName = "Miguel",
                            Grade = "3rd",
                            LastName = "Garcia"
                        },
                        new
                        {
                            ID = 43,
                            Age = 23,
                            Email = "tedd.fernandez@gmail.com",
                            FirstName = "Tedd",
                            Grade = "1st",
                            LastName = "Fernandez"
                        },
                        new
                        {
                            ID = 44,
                            Age = 32,
                            Email = "carlos.stampton@gmail.com",
                            FirstName = "Carlos",
                            Grade = "4th",
                            LastName = "Stampton"
                        },
                        new
                        {
                            ID = 45,
                            Age = 16,
                            Email = "miguel.lee@gmail.com",
                            FirstName = "Miguel",
                            Grade = "4th",
                            LastName = "Lee"
                        },
                        new
                        {
                            ID = 46,
                            Age = 53,
                            Email = "miguel.fernandez@gmail.com",
                            FirstName = "Miguel",
                            Grade = "1st",
                            LastName = "Fernandez"
                        },
                        new
                        {
                            ID = 47,
                            Age = 22,
                            Email = "miguel.hernandez@gmail.com",
                            FirstName = "Miguel",
                            Grade = "2nd",
                            LastName = "Hernandez"
                        },
                        new
                        {
                            ID = 48,
                            Age = 41,
                            Email = "jhon.tapanez@gmail.com",
                            FirstName = "Jhon",
                            Grade = "6th",
                            LastName = "Tapanez"
                        },
                        new
                        {
                            ID = 49,
                            Age = 49,
                            Email = "tedd.fernandez@gmail.com",
                            FirstName = "Tedd",
                            Grade = "2nd",
                            LastName = "Fernandez"
                        },
                        new
                        {
                            ID = 50,
                            Age = 31,
                            Email = "miguel.tapanez@gmail.com",
                            FirstName = "Miguel",
                            Grade = "1st",
                            LastName = "Tapanez"
                        });
                });

            modelBuilder.Entity("MajestyApi.Models.Tutorial", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Published")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Tutorial");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "Doe",
                            Published = false,
                            Title = "Carlos"
                        },
                        new
                        {
                            ID = 2,
                            Description = "Hernandez",
                            Published = true,
                            Title = "Juliet"
                        },
                        new
                        {
                            ID = 3,
                            Description = "Stampton",
                            Published = true,
                            Title = "Juliet"
                        },
                        new
                        {
                            ID = 4,
                            Description = "Stampton",
                            Published = true,
                            Title = "Miguel"
                        },
                        new
                        {
                            ID = 5,
                            Description = "Fernandez",
                            Published = false,
                            Title = "Juliet"
                        },
                        new
                        {
                            ID = 6,
                            Description = "Hernandez",
                            Published = true,
                            Title = "Brayan"
                        },
                        new
                        {
                            ID = 7,
                            Description = "Garcia",
                            Published = true,
                            Title = "Brayan"
                        },
                        new
                        {
                            ID = 8,
                            Description = "Hernandez",
                            Published = true,
                            Title = "Marcos"
                        },
                        new
                        {
                            ID = 9,
                            Description = "Garcia",
                            Published = false,
                            Title = "Marcos"
                        },
                        new
                        {
                            ID = 10,
                            Description = "Tapanez",
                            Published = true,
                            Title = "Jhon"
                        },
                        new
                        {
                            ID = 11,
                            Description = "Stampton",
                            Published = true,
                            Title = "Juliet"
                        },
                        new
                        {
                            ID = 12,
                            Description = "Doe",
                            Published = false,
                            Title = "Jhon"
                        },
                        new
                        {
                            ID = 13,
                            Description = "Tapanez",
                            Published = false,
                            Title = "Carlos"
                        },
                        new
                        {
                            ID = 14,
                            Description = "Fernandez",
                            Published = false,
                            Title = "Tedd"
                        },
                        new
                        {
                            ID = 15,
                            Description = "Garcia",
                            Published = true,
                            Title = "Jhon"
                        },
                        new
                        {
                            ID = 16,
                            Description = "Tapanez",
                            Published = false,
                            Title = "Carlos"
                        },
                        new
                        {
                            ID = 17,
                            Description = "Garcia",
                            Published = true,
                            Title = "Miguel"
                        },
                        new
                        {
                            ID = 18,
                            Description = "Lee",
                            Published = false,
                            Title = "Carlos"
                        },
                        new
                        {
                            ID = 19,
                            Description = "Lee",
                            Published = false,
                            Title = "Marcos"
                        },
                        new
                        {
                            ID = 20,
                            Description = "Hernandez",
                            Published = false,
                            Title = "Brayan"
                        },
                        new
                        {
                            ID = 21,
                            Description = "Lee",
                            Published = false,
                            Title = "Miguel"
                        },
                        new
                        {
                            ID = 22,
                            Description = "Lee",
                            Published = true,
                            Title = "Jhon"
                        },
                        new
                        {
                            ID = 23,
                            Description = "Lee",
                            Published = true,
                            Title = "Marcos"
                        },
                        new
                        {
                            ID = 24,
                            Description = "Lee",
                            Published = true,
                            Title = "Jhon"
                        },
                        new
                        {
                            ID = 25,
                            Description = "Lee",
                            Published = true,
                            Title = "Brayan"
                        },
                        new
                        {
                            ID = 26,
                            Description = "Stampton",
                            Published = false,
                            Title = "Carlos"
                        },
                        new
                        {
                            ID = 27,
                            Description = "Hernandez",
                            Published = true,
                            Title = "Tedd"
                        },
                        new
                        {
                            ID = 28,
                            Description = "Garcia",
                            Published = true,
                            Title = "Miguel"
                        },
                        new
                        {
                            ID = 29,
                            Description = "Garcia",
                            Published = false,
                            Title = "Jhon"
                        },
                        new
                        {
                            ID = 30,
                            Description = "Fernandez",
                            Published = true,
                            Title = "Tedd"
                        },
                        new
                        {
                            ID = 31,
                            Description = "Hernandez",
                            Published = false,
                            Title = "Marcos"
                        },
                        new
                        {
                            ID = 32,
                            Description = "Lee",
                            Published = false,
                            Title = "Brayan"
                        },
                        new
                        {
                            ID = 33,
                            Description = "Doe",
                            Published = false,
                            Title = "Juliet"
                        },
                        new
                        {
                            ID = 34,
                            Description = "Lee",
                            Published = true,
                            Title = "Jhon"
                        },
                        new
                        {
                            ID = 35,
                            Description = "Garcia",
                            Published = false,
                            Title = "Miguel"
                        },
                        new
                        {
                            ID = 36,
                            Description = "Hernandez",
                            Published = false,
                            Title = "Marcos"
                        },
                        new
                        {
                            ID = 37,
                            Description = "Hernandez",
                            Published = true,
                            Title = "Juliet"
                        },
                        new
                        {
                            ID = 38,
                            Description = "Tapanez",
                            Published = false,
                            Title = "Jhon"
                        },
                        new
                        {
                            ID = 39,
                            Description = "Tapanez",
                            Published = true,
                            Title = "Brayan"
                        },
                        new
                        {
                            ID = 40,
                            Description = "Tapanez",
                            Published = true,
                            Title = "Tedd"
                        },
                        new
                        {
                            ID = 41,
                            Description = "Garcia",
                            Published = true,
                            Title = "Brayan"
                        },
                        new
                        {
                            ID = 42,
                            Description = "Hernandez",
                            Published = false,
                            Title = "Jhon"
                        },
                        new
                        {
                            ID = 43,
                            Description = "Tapanez",
                            Published = true,
                            Title = "Carlos"
                        },
                        new
                        {
                            ID = 44,
                            Description = "Stampton",
                            Published = false,
                            Title = "Carlos"
                        },
                        new
                        {
                            ID = 45,
                            Description = "Hernandez",
                            Published = true,
                            Title = "Jhon"
                        },
                        new
                        {
                            ID = 46,
                            Description = "Doe",
                            Published = false,
                            Title = "Tedd"
                        },
                        new
                        {
                            ID = 47,
                            Description = "Hernandez",
                            Published = true,
                            Title = "Miguel"
                        },
                        new
                        {
                            ID = 48,
                            Description = "Garcia",
                            Published = true,
                            Title = "Juliet"
                        },
                        new
                        {
                            ID = 49,
                            Description = "Lee",
                            Published = true,
                            Title = "Tedd"
                        },
                        new
                        {
                            ID = 50,
                            Description = "Tapanez",
                            Published = false,
                            Title = "Marcos"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
