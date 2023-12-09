using JamesonUniversity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JamesonUniversity.Models
{
    public class CourseAssignment
    {
        [Key]
        //[Column(Order = 0)]
        public int InstructorID { get; set; }


        [Key]
        //[Column(Order = 1)]
        public int CourseID { get; set; }
        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
    }
}