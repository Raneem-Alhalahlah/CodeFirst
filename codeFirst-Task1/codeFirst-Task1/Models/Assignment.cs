using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace codeFirst_Task1.Models
{
    public class Assignment
    {
        [Key]
        public int AssignmentId { get; set; }  // PK, Auto Increment
        [Required]
        public string Title { get; set; } 
        public DateTime DueDate { get; set; }  // Not Nullable
    }
}