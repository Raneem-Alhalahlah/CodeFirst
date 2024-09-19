using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codeFirst_Task1.Models
{
    public class StudentDetails
    {
        public int StudentDetailsId { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        // مفتاح خارجي يشير إلى Student
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}