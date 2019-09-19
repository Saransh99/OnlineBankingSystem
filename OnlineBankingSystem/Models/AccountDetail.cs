using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineBankingSystem.Models
{
    public class AccountDetail
    {
        public int Id { get; set; }

        [Required]
        public string AccountNumber { get; set; }

        [Required]
        public string CIFNumber { get; set; }

        [Required]
        public string BranchCode { get; set; }

        [Required]
        public int Balance { get; set; }

        [Required]
        public DateTime AccountStartDate { get; set; }

        [Required]
        public string AccountStatus { get; set; }

    }

}