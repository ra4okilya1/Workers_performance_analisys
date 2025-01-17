﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Perfomans.Models;

namespace Perfomans.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20211107092018_Main")]
    partial class Main
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Perfomans.Models.DepartmentParameters", b =>
                {
                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int?>("ParameterId")
                        .HasColumnType("int");

                    b.Property<double>("mark")
                        .HasColumnType("float");

                    b.HasKey("DepartmentId", "ParameterId");

                    b.HasIndex("ParameterId");

                    b.ToTable("DepartmentParameters");
                });

            modelBuilder.Entity("Perfomans.Models.Departments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Developing"
                        });
                });

            modelBuilder.Entity("Perfomans.Models.Evaluations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssessorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("Mark")
                        .HasColumnType("float");

                    b.Property<int?>("ParameterId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssessorId");

                    b.HasIndex("ParameterId");

                    b.HasIndex("UserId");

                    b.ToTable("Evaluations");
                });

            modelBuilder.Entity("Perfomans.Models.Groups", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            id = 1,
                            DepartmentId = 1,
                            Name = "Group1"
                        });
                });

            modelBuilder.Entity("Perfomans.Models.Parameters", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Coefficient")
                        .HasColumnType("float");

                    b.Property<string>("Mark_1_description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mark_2_description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mark_3_description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mark_4_description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mark_5_description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Parameters");
                });

            modelBuilder.Entity("Perfomans.Models.ParametersGroup", b =>
                {
                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<int?>("ParameterId")
                        .HasColumnType("int");

                    b.Property<double>("Mark")
                        .HasColumnType("float");

                    b.HasKey("GroupId", "ParameterId");

                    b.HasIndex("ParameterId");

                    b.ToTable("ParametersGroups");
                });

            modelBuilder.Entity("Perfomans.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "user"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Teamlead"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Head"
                        });
                });

            modelBuilder.Entity("Perfomans.Models.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("States");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Default"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Fired"
                        });
                });

            modelBuilder.Entity("Perfomans.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("SourName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StateId")
                        .HasColumnType("int");

                    b.Property<int?>("SupervisorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("RoleId");

                    b.HasIndex("StateId");

                    b.HasIndex("SupervisorId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentId = 1,
                            Email = "admin@mail.ru",
                            Name = "Mary",
                            Password = "123456",
                            RoleId = 1,
                            SourName = "Sargsyan",
                            StateId = 1,
                            SupervisorId = 1
                        });
                });

            modelBuilder.Entity("Perfomans.Models.DepartmentParameters", b =>
                {
                    b.HasOne("Perfomans.Models.Departments", "Department")
                        .WithMany("DepartmentParameters")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Perfomans.Models.Parameters", "parameter")
                        .WithMany("Departments")
                        .HasForeignKey("ParameterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Perfomans.Models.Evaluations", b =>
                {
                    b.HasOne("Perfomans.Models.User", "Assessor")
                        .WithMany()
                        .HasForeignKey("AssessorId");

                    b.HasOne("Perfomans.Models.Parameters", "Parameter")
                        .WithMany("evaluations")
                        .HasForeignKey("ParameterId");

                    b.HasOne("Perfomans.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Perfomans.Models.Groups", b =>
                {
                    b.HasOne("Perfomans.Models.Departments", "Department")
                        .WithMany("Groups")
                        .HasForeignKey("DepartmentId");
                });

            modelBuilder.Entity("Perfomans.Models.ParametersGroup", b =>
                {
                    b.HasOne("Perfomans.Models.Groups", "Groups")
                        .WithMany("ParametersGroups")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Perfomans.Models.Parameters", "Parameters")
                        .WithMany("ParametersGroups")
                        .HasForeignKey("ParameterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Perfomans.Models.User", b =>
                {
                    b.HasOne("Perfomans.Models.Departments", "Department")
                        .WithMany("User")
                        .HasForeignKey("DepartmentId");

                    b.HasOne("Perfomans.Models.Role", "Role")
                        .WithMany("User")
                        .HasForeignKey("RoleId");

                    b.HasOne("Perfomans.Models.State", "state")
                        .WithMany("User")
                        .HasForeignKey("StateId");

                    b.HasOne("Perfomans.Models.User", "Supervisor")
                        .WithMany()
                        .HasForeignKey("SupervisorId");
                });
#pragma warning restore 612, 618
        }
    }
}
