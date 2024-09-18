using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace codeFirst_Task1.Models
{
    public class Teacher
    {

        [Key]
        public int TeacherId { get; set; }  // PK, Auto Increment
        public string Name { get; set; } // Not Nullable
        public string Subject { get; set; } // Nullable
    }
}