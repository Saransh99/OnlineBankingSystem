using System;
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
        public string Password { get; set; }
        public string Username { get; set; }

        public BranchManager BranchManager { get; set; }
        
    }
}