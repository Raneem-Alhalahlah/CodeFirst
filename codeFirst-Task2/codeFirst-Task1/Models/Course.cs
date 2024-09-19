using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codeFirst_Task1.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}