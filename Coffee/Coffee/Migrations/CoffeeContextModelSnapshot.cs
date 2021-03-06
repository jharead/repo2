﻿// <auto-generated />
using Coffee.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Coffee.Migrations
{
    [DbContext(typeof(CoffeeContext))]
    partial class CoffeeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("Coffee.Models.CoffeeItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Flavor");

                    b.Property<string>("Name");

                    b.Property<string>("Size");

                    b.HasKey("Id");

                    b.ToTable("CoffeeItems");
                });
#pragma warning restore 612, 618
        }
    }
}
