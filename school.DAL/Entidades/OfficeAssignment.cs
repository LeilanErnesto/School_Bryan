﻿using school.DB.CORE;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school.DB.Entidades
{
    public class OfficeAssignment 
    {
        [Key]
        public int InstructorId { get; set; }
        public string? Location { get; set; }
        public byte[]? Timestamp { get; set; }
    }
}
