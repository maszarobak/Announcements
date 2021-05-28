﻿// <auto-generated />
using Announcements.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Announcements.Migrations
{
    [DbContext(typeof(AnnouncementContext))]
    [Migration("20210527102136_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Announcements.Models.Announcement", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("autor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tytul")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("uczelnia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("wydzial")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Announcements");
                });
#pragma warning restore 612, 618
        }
    }
}
