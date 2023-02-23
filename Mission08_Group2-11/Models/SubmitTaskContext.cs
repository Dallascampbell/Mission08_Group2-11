using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission08_Group2_11.Models
{
    //Constructor
    public class SubmitTaskContext : DbContext
    {
        //Constructor
        public SubmitTaskContext (DbContextOptions<SubmitTaskContext> options) : base (options)
        {

        }

        public DbSet<SubmitTask> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        //seed the data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Home"},
                new Category { CategoryID = 2, CategoryName = "School" },
                new Category { CategoryID = 3, CategoryName = "Work" },
                new Category { CategoryID = 4, CategoryName = "Church" }
                );

            mb.Entity<SubmitTask>().HasData(
                new SubmitTask
                {
                    TaskID = 1,
                    Task = "Do the dishes",
                    DueDate = "2023-02-28",
                    Quadrant = 2,
                    CategoryID = 1,
                    Completed = false
                },

                new SubmitTask
                {
                    TaskID = 2,
                    Task = "Take Midterm",
                    DueDate = "2023-03-01",
                    Quadrant = 1,
                    CategoryID = 2,
                    Completed = true
                },

                new SubmitTask
                {
                    TaskID = 3,
                    Task = "Respond to Coworker's email",
                    DueDate = "2023-03-04",
                    Quadrant = 3,
                    CategoryID = 3,
                    Completed = false
                },

                new SubmitTask
                {
                    TaskID = 4,
                    Task = "Get lollipop from Bishop's office",
                    DueDate = "2023-03-15",
                    Quadrant = 4,
                    CategoryID = 4,
                    Completed = false
                }
                );
        }
    }
}
