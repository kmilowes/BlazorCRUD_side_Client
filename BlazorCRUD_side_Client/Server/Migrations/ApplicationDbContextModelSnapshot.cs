// <auto-generated />
using System;
using BlazorCRUD_side_Client.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorCRUD_side_Client.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlazorCRUD_side_Client.Shared.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameCountry")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Country");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NameCountry = "Rep Dom"
                        },
                        new
                        {
                            Id = 2,
                            NameCountry = "Mexico"
                        },
                        new
                        {
                            Id = 3,
                            NameCountry = "Colombia"
                        });
                });

            modelBuilder.Entity("BlazorCRUD_side_Client.Shared.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Persona 1",
                            StateId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Persona 2",
                            StateId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Persona 3",
                            StateId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "Persona 4",
                            StateId = 1
                        },
                        new
                        {
                            Id = 5,
                            Name = "Persona 5",
                            StateId = 1
                        },
                        new
                        {
                            Id = 6,
                            Name = "Persona 6",
                            StateId = 1
                        },
                        new
                        {
                            Id = 7,
                            Name = "Persona 7",
                            StateId = 1
                        },
                        new
                        {
                            Id = 8,
                            Name = "Persona 8",
                            StateId = 1
                        },
                        new
                        {
                            Id = 9,
                            Name = "Persona 9",
                            StateId = 1
                        },
                        new
                        {
                            Id = 10,
                            Name = "Persona 10",
                            StateId = 1
                        },
                        new
                        {
                            Id = 11,
                            Name = "Persona 11",
                            StateId = 1
                        },
                        new
                        {
                            Id = 12,
                            Name = "Persona 12",
                            StateId = 1
                        },
                        new
                        {
                            Id = 13,
                            Name = "Persona 13",
                            StateId = 1
                        },
                        new
                        {
                            Id = 14,
                            Name = "Persona 14",
                            StateId = 1
                        });
                });

            modelBuilder.Entity("BlazorCRUD_side_Client.Shared.Models.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<int>("IdCountry")
                        .HasColumnType("int");

                    b.Property<string>("NameState")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("State");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdCountry = 1,
                            NameState = "Santo Domingo"
                        },
                        new
                        {
                            Id = 2,
                            IdCountry = 1,
                            NameState = "San Cristobal"
                        },
                        new
                        {
                            Id = 3,
                            IdCountry = 2,
                            NameState = "Ciudad de Mexico"
                        },
                        new
                        {
                            Id = 4,
                            IdCountry = 2,
                            NameState = "Jalisco"
                        },
                        new
                        {
                            Id = 5,
                            IdCountry = 3,
                            NameState = "Bogota"
                        },
                        new
                        {
                            Id = 6,
                            IdCountry = 3,
                            NameState = "Medellin"
                        },
                        new
                        {
                            Id = 7,
                            IdCountry = 3,
                            NameState = "Cartagena"
                        });
                });

            modelBuilder.Entity("BlazorCRUD_side_Client.Shared.Models.Person", b =>
                {
                    b.HasOne("BlazorCRUD_side_Client.Shared.Models.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("BlazorCRUD_side_Client.Shared.Models.State", b =>
                {
                    b.HasOne("BlazorCRUD_side_Client.Shared.Models.Country", null)
                        .WithMany("Estados")
                        .HasForeignKey("CountryId");
                });

            modelBuilder.Entity("BlazorCRUD_side_Client.Shared.Models.Country", b =>
                {
                    b.Navigation("Estados");
                });
#pragma warning restore 612, 618
        }
    }
}
