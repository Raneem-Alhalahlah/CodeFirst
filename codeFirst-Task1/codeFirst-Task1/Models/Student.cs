using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace codeFirst_Task1.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }  // PK, Auto Increment
        public string Name { get; set; }  // Not Nullable
        public int Age { get; set; }  // Not Nullable
        public string Email { get; set; } // Nullable
    }
}