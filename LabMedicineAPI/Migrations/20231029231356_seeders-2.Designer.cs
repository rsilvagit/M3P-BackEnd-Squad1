﻿// <auto-generated />
using System;
using LabMedicineAPI.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LabMedicineAPI.Migrations
{
    [DbContext(typeof(LabMedicineDbContext))]
    [Migration("20231029231356_seeders-2")]
    partial class seeders2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LabMedicineAPI.Model.ConsultaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("DosagemEPrecaucoes")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("VARCHAR");

                    b.Property<DateTime>("Horario")
                        .HasColumnType("datetime2");

                    b.Property<string>("MedicacaoIndicada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotivoConsulta")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("VARCHAR");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.Property<string>("ProblemaDescricao")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("VARCHAR");

                    b.Property<bool>("StatusSistema")
                        .HasColumnType("bit");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Consultas");
                });

            modelBuilder.Entity("LabMedicineAPI.Model.DietaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescricaoDieta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Horario")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeDieta")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.Property<bool>("StatusSistema")
                        .HasColumnType("bit");

                    b.Property<string>("TipoDieta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Dieta");
                });

            modelBuilder.Entity("LabMedicineAPI.Model.EnderecoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.Property<string>("PontoReferencia")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId")
                        .IsUnique();

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("LabMedicineAPI.Model.ExameModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Horario")
                        .HasColumnType("datetime2");

                    b.Property<string>("Laboratorio")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("NomeExame")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("VARCHAR");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.Property<string>("Resultados")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("VARCHAR");

                    b.Property<bool>("StatusSistema")
                        .HasColumnType("bit");

                    b.Property<string>("TipoExame")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Exame");
                });

            modelBuilder.Entity("LabMedicineAPI.Model.ExercicioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescricaoExerc")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("VARCHAR");

                    b.Property<DateTime>("Horario")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeSerieExerc")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.Property<decimal>("QuantidadeSemana")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("StatusSistema")
                        .HasColumnType("bit");

                    b.Property<string>("TipoExerc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Exercicio");
                });

            modelBuilder.Entity("LabMedicineAPI.Model.MedicamentoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Horario")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeMedicamento")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Observacoes")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("VARCHAR");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantidade")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("StatusSistema")
                        .HasColumnType("bit");

                    b.Property<string>("TipoMedicamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Medicamento");
                });

            modelBuilder.Entity("LabMedicineAPI.Model.PacienteModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Alergias")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("ContatoEmergencia")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Convenio")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("CuidadosEspecificos")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("EstadoCivil")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Naturalidade")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("NumeroConvenio")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("RgOrgaoExpedidor")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("StatusSistema")
                        .IsRequired()
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<DateTime?>("ValidadeConvenio")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Paciente");
                });

            modelBuilder.Entity("LabMedicineAPI.Model.UsuarioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("StatusSistema")
                        .IsRequired()
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CPF = "09465328956",
                            Email = "admin1@admin.com",
                            Genero = "Outro",
                            NomeCompleto = "4Devs",
                            Senha = "12345678",
                            StatusSistema = "1",
                            Telefone = "48998000054",
                            Tipo = "Administrador"
                        },
                        new
                        {
                            Id = 2,
                            CPF = "45662548652",
                            Email = "rafael@gmail.com",
                            Genero = "Masculino",
                            NomeCompleto = "Rafael Silva",
                            Senha = "12345678",
                            StatusSistema = "1",
                            Telefone = "48995321544",
                            Tipo = "Médico"
                        },
                        new
                        {
                            Id = 3,
                            CPF = "06532589965",
                            Email = "alessandra@gmail.com",
                            Genero = "Feminino",
                            NomeCompleto = "Alessandra",
                            Senha = "12345678",
                            StatusSistema = "1",
                            Telefone = "48995874233",
                            Tipo = "Enfermeiro"
                        },
                        new
                        {
                            Id = 4,
                            CPF = "06523144785",
                            Email = "william84@gmail.com",
                            Genero = "Masculino",
                            NomeCompleto = "William",
                            Senha = "12345678",
                            StatusSistema = "1",
                            Telefone = "48996524233",
                            Tipo = "Enfermeiro"
                        });
                });

            modelBuilder.Entity("LabMedicineAPI.Model.ConsultaModel", b =>
                {
                    b.HasOne("LabMedicineAPI.Model.PacienteModel", "Paciente")
                        .WithMany("Consultas")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("LabMedicineAPI.Model.UsuarioModel", "Usuario")
                        .WithMany("Consultas")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Paciente");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("LabMedicineAPI.Model.DietaModel", b =>
                {
                    b.HasOne("LabMedicineAPI.Model.PacienteModel", "Paciente")
                        .WithMany("Dietas")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LabMedicineAPI.Model.UsuarioModel", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("LabMedicineAPI.Model.EnderecoModel", b =>
                {
                    b.HasOne("LabMedicineAPI.Model.PacienteModel", "Paciente")
                        .WithOne("Endereco")
                        .HasForeignKey("LabMedicineAPI.Model.EnderecoModel", "PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("LabMedicineAPI.Model.ExameModel", b =>
                {
                    b.HasOne("LabMedicineAPI.Model.PacienteModel", "Paciente")
                        .WithMany("Exames")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LabMedicineAPI.Model.UsuarioModel", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("LabMedicineAPI.Model.ExercicioModel", b =>
                {
                    b.HasOne("LabMedicineAPI.Model.PacienteModel", "Paciente")
                        .WithMany("Exercicios")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LabMedicineAPI.Model.UsuarioModel", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("LabMedicineAPI.Model.MedicamentoModel", b =>
                {
                    b.HasOne("LabMedicineAPI.Model.PacienteModel", "Paciente")
                        .WithMany("Medicamentos")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LabMedicineAPI.Model.UsuarioModel", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("LabMedicineAPI.Model.PacienteModel", b =>
                {
                    b.Navigation("Consultas");

                    b.Navigation("Dietas");

                    b.Navigation("Endereco")
                        .IsRequired();

                    b.Navigation("Exames");

                    b.Navigation("Exercicios");

                    b.Navigation("Medicamentos");
                });

            modelBuilder.Entity("LabMedicineAPI.Model.UsuarioModel", b =>
                {
                    b.Navigation("Consultas");
                });
#pragma warning restore 612, 618
        }
    }
}
