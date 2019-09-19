using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineBankingSystem.Models
{
    public class BranchInformation
    {
        public int Id { get; set; }

        [Required]
        public string Address { get; set; }


    }
}