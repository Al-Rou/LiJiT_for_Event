﻿using System;
using System.ComponentModel.DataAnnotations;

namespace LiJiT.Model
{
    public class SupportPrograms : Entity<Int16>
    {
        [Required]
        public string Name { get; set; }

        public string Url { get; set; }

        public string Description { get; set; }
    }
}
