using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace evaluation.Models
{
    public enum Subjects
    {
        biology,
        math,
        physics,
        chemistry,
        history,
        languague,
        physical_education

    }




    public class StudentGrades
    {
        [Key]
        public int DetailID { get; set; }
        public int StuID { get; set; }
        public Subjects subjects { get; set; }
        public int score { get; set; }
        public StudentMain StudentMain { get; set; }



    }
}