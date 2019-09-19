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
        public string CIFNumber { get; set; }
        public string BranchCode { get; set; }
        public int Balance { get; set; }
        public DateTime AccountStartDate { get; set; }
    }

}