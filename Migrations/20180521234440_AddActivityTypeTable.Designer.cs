﻿// <auto-generated />
using ActivityTracker.Database;
using ActivityTracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace ActivityTracker.Migrations
{
    [DbContext(typeof(ActivityContext))]
    [Migration("20180521234440_AddActivityTypeTable")]
    partial class AddActivityTypeTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011");

            modelBuilder.Entity("ActivityTracker.Models.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MeasurementType");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("ActivityTracker.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Nickname");

                    b.Property<string>("Photo");

                    b.Property<string>("UniqueID");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
