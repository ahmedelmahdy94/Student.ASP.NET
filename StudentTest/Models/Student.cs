using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentTest.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string AName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public int GradeID { get; set; }
        [Required]
        public string Contact { get; set; }
    }
}



