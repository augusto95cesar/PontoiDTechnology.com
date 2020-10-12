﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PontoIdApi.Context;

namespace PontoIdApi.Migrations
{
    [DbContext(typeof(PontoIdContext))]
    [Migration("20201012030805_InitBd")]
    partial class InitBd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("PontoIdApi.Model.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CodTurma")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cpf")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("PontoIdApi.Model.Escola", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CodigoINEP")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Escolas");
                });

            modelBuilder.Entity("PontoIdApi.Model.Turma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CodEscola")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<int>("Serie")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Turno")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Turmas");
                });
#pragma warning restore 612, 618
        }
    }
}