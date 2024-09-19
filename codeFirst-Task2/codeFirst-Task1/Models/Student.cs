using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace codeFirst_Task1.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        // علاقة 1-1 مع StudentDetails
        public StudentDetails StudentDetails { get; set; }
    }
}