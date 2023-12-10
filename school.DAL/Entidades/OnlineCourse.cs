﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.DB.Entidades
{
    public class OnlineCourse
    {
        [Key]
        public int CourseID { get; set; }
        public string? URL { get; set; }
    }
}
