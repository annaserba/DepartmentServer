﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentServer.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
