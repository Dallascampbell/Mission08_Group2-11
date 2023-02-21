﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission08_Group2_11.Models;

namespace Mission08_Group2_11.Migrations
{
    [DbContext(typeof(SubmitTaskContext))]
    partial class SubmitTaskContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission08_Group2_11.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Home"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "School"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Work"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Church"
                        });
                });

            modelBuilder.Entity("Mission08_Group2_11.Models.SubmitTask", b =>
                {
                    b.Property<int>("TaskID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Completed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DueDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quadrant")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Task")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TaskID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            TaskID = 1,
                            CategoryID = 1,
                            Completed = false,
                            DueDate = "2/31/23",
                            Quadrant = 2,
                            Task = "Do the dishes"
                        },
                        new
                        {
                            TaskID = 2,
                            CategoryID = 2,
                            Completed = true,
                            DueDate = "3/01/23",
                            Quadrant = 1,
                            Task = "Take Midterm"
                        },
                        new
                        {
                            TaskID = 3,
                            CategoryID = 3,
                            Completed = false,
                            DueDate = "3/04/23",
                            Quadrant = 3,
                            Task = "Respond to Coworker's email"
                        },
                        new
                        {
                            TaskID = 4,
                            CategoryID = 4,
                            Completed = false,
                            DueDate = "3/15/23",
                            Quadrant = 4,
                            Task = "Get lollipop from Bishop's office"
                        });
                });

            modelBuilder.Entity("Mission08_Group2_11.Models.SubmitTask", b =>
                {
                    b.HasOne("Mission08_Group2_11.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
