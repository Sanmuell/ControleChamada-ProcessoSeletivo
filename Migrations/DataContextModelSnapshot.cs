﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using controle_escolar.Data;

namespace controle_escolar.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("controle_escolar.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Matricula")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("controle_escolar.Models.Chamada", b =>
                {
                    b.Property<int>("IdChamada")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AlunoID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataChamada")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdTurma")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("StatusChamada")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdChamada");

                    b.HasIndex("AlunoID");

                    b.ToTable("Chamada");
                });

            modelBuilder.Entity("controle_escolar.Models.Turma", b =>
                {
                    b.Property<int>("TurmaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("Turno")
                        .HasColumnType("INTEGER");

                    b.HasKey("TurmaId");

                    b.ToTable("Turmas");
                });

            modelBuilder.Entity("controle_escolar.Models.Chamada", b =>
                {
                    b.HasOne("controle_escolar.Models.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");
                });
#pragma warning restore 612, 618
        }
    }
}
