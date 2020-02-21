﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RandomUser.Infrastructure.EntityFramework;

namespace RandomUser.Infrastructure.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("RandomUser.Infrastructure.EntityFramework.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DOB = new DateTime(2020, 2, 21, 23, 45, 33, 343, DateTimeKind.Local).AddTicks(4210),
                            Email = "john.doe@email.com",
                            FirstName = "John",
                            Image = "https://randomuser.me/api/portraits/men/33.jpg",
                            LastName = "Doe",
                            PhoneNumber = 1234567,
                            Title = "Mr"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
