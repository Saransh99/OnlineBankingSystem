using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OnlineBankingSystem.Models
{
    public class Registration
    {
        public int Id { get; set; }
        public string SBAccountNumber { get; set; }
        public string CIFNumber { get; set; }
        public string BranchCode { get; set; }

        [Required]
        [Phone]
        public string RegisteredMobileNumber { get; set; }

        
    }
}