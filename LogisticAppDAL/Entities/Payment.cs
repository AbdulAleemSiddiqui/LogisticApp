using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogisticAppDAL.Entities
{
    public class Payment
    {
        [Key]
        public int P_ID { get; set; }
        public string P_No { get; set; }
        [Required]
        public string Issue_Name { get; set; }
        public string Issue_Date { get; set; }
        public string Reason { get; set; }
        [Required]
        public string Status { get; set; } //Debit-Credit
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public string Method { get; set; }
        public decimal Tax { get; set; }

        public int? Cheque_ID { get; set; }
        [ForeignKey("Cheque")]
        public Cheque cheque { get; set; }

        public int? Deposite_ID { get; set; }
        [ForeignKey("Deposite")]
        public Deposit_Slip deposit_Slip { get; set; }

    }
}
