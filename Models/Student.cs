using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Interview2.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public object StudentID { get; internal set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public virtual ICollection<Qualification> Qualifications { get; set; }
    }

    public class Qualification
    {
        public int QualificationId { get; set; }
        public int StudentId { get; set; }
        public object StudentID { get; internal set; }
        public string Course { get; set; }
        public string University { get; set; }
        public int Year { get; set; }
        public decimal Percentage { get; set; }
        public virtual Student Student { get; set; }
        public string CourseName { get; internal set; }
    }
}