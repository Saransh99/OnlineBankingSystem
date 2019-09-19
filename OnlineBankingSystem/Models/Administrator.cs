﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineBankingSystem.Models
{
    public class Administrator
    {
        public int Id { get; set; }

        [Required]
        public string password { get; set; }
        public BranchManager BranchManager { get; set; }
        
    }
}