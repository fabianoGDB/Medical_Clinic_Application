﻿// <auto-generated />
using System;
using Mc.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Mc.Data.Migrations
{
    [DbContext(typeof(MCContext))]
    [Migration("20211227175131_clientFields")]
    partial class clientFields
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Mc.Core.Domain.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CPF")
                        .HasColumnType("text");

                    b.Property<char?>("Gender")
                        .HasColumnType("character(1)");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Tel")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });
#pragma warning restore 612, 618
        }
    }
}