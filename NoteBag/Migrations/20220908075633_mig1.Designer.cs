// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NoteBag.Data;

#nullable disable

namespace NoteBag.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220908075633_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NoteBag.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Notes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quam aliquam alias illo vero nemo esse corrupti explicabo magni natus sunt consequatur quo voluptatum nisi accusamus rem, qui quia inventore rerum!",
                            CreatedTime = new DateTime(2022, 9, 8, 10, 56, 33, 145, DateTimeKind.Local).AddTicks(9531),
                            ModifiedTime = new DateTime(2022, 9, 8, 10, 56, 33, 145, DateTimeKind.Local).AddTicks(9544),
                            Title = "Lorem Ipsum Dolor"
                        },
                        new
                        {
                            Id = 2,
                            Content = "Eius iste vitae commodi magnam odit maxime id officiis iusto. A modi quae fugit! Veritatis nihil dolorum repellat laudantium, unde quae a porro quod ipsam possimus, nulla vero praesentium eius?",
                            CreatedTime = new DateTime(2022, 9, 8, 10, 56, 33, 145, DateTimeKind.Local).AddTicks(9547),
                            ModifiedTime = new DateTime(2022, 9, 8, 10, 56, 33, 145, DateTimeKind.Local).AddTicks(9547),
                            Title = "Quis Dolores Est"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
