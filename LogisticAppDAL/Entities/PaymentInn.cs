using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LogisticAppDAL.Entities
{
    public class PaymentInn
    {
        [Key]
        public int P_ID { get; set; }
        [ForeignKey("Invoice")]
        public int Invoice_ID { get; set; }

        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public decimal Tax { get; set; }
        public string Method { get; set; }

        public string Cheque_No { get; set; }
        public DateTime? Cheque_Date { get; set; }

        public string Deposit_Person { get; set; }
        public string Deposit_Slip_No { get; set; }
        public DateTime? Deposit_Date { get; set; }

        public Invoice Invoice { get; set; }
    }
}
