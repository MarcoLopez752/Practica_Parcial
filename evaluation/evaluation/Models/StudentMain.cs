using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace evaluation.Models
{

    public enum Genre
    {
        male,
        female
    }

    public class StudentMain
    {
        [Key]
        public int StuID { get; set; }
        public string StudentName { get; set; }
        public Genre genre { get; set; }
        public string Date_of_birth { get; set; }
        public virtual ICollection<StudentGrades> StudentGrades { get; set; }




    }
}