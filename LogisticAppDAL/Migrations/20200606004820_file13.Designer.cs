﻿// <auto-generated />
using System;
using LogisticAppDAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LogisticAppDAL.Migrations
{
    [DbContext(typeof(LogisticDbContext))]
    [Migration("20200606004820_file13")]
    partial class file13
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
 
            modelBuilder.Entity("LogisticAppDAL.Entities.Expense", b =>
                {
                    b.Property<int>("Exp_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<int>("Exp_Cat_ID");

                    b.Property<string>("Person");

                    b.HasKey("Exp_ID");

                    b.HasIndex("Exp_Cat_ID");

                    b.ToTable("Expense");
                });

            modelBuilder.Entity("LogisticAppDAL.Entities.Expense_Category", b =>
                {
                    b.Property<int>("Exp_Cat_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Exp_Cat_Name");

                    b.HasKey("Exp_Cat_ID");

                    b.ToTable("Expense_Category");
                });
 

            modelBuilder.Entity("LogisticAppDAL.Entities.Expense", b =>
                {
                    b.HasOne("LogisticAppDAL.Entities.Expense_Category", "Expense_Category")
                        .WithMany()
                        .HasForeignKey("Exp_Cat_ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}