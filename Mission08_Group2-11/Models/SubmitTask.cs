using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission08_Group2_11.Models
{
    public class SubmitTask
    {

       [Key]
       [Required]
       public int TaskID { get; set; }

       [Required(ErrorMessage ="Please enter a task.")]
       public string Task { get; set; }

        //This should actually be a date but using string to make it easier to seed 
       public string DueDate { get; set; }

       [Required(ErrorMessage ="Please enter a quadrant.")]
       public int Quadrant { get; set; }

       public int CategoryID { get; set; }

       public Category Category { get; set; }

       public bool Completed { get; set; }

    }
}
