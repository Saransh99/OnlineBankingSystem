using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineBankingSystem.Models
{
    public class Beneficiary
    {
        public int Id { get; set; }

        [Required]
        public string BeneficiaryName { get; set; }

        [Required]
        public string BeneficiaryAccountNo { get; set; }

        [Required]
        public string BeneficiaryBankName { get; set; }

        [Required]
        public string BeneficiaryIFSCode { get; set; }

        [Required]
        public int TransferLimit { get; set; }

    }
}