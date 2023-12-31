﻿using Microsoft.EntityFrameworkCore;
using Mono.TextTemplating;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace LiverpoolUnitTakeHome.Models
{
    [PrimaryKey(nameof(StudentID), nameof(SubjectID))]
    public class StudentSubject
    {
        public int StudentID { get; set; }
        public Student Student { get; set; }

        public int SubjectID { get; set; }
        public Subject Subject { get; set; }


    }
}
