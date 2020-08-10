﻿// <auto-generated />
using System;
using ListaTarefas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ListaTarefas.Migrations
{
    [DbContext(typeof(TarefasContexto))]
    [Migration("20180902222920_PrimeiroMigration")]
    partial class PrimeiroMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ListaTarefas.Models.Tarefas", b =>
                {
                    b.Property<int>("TarefasId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.Property<DateTime>("Fim");

                    b.Property<string>("Importancia");

                    b.Property<DateTime>("Inicio");

                    b.Property<string>("Nome");

                    b.HasKey("TarefasId");

                    b.ToTable("Tarefas");
                });
#pragma warning restore 612, 618
        }
    }
}
