using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LogisticAppDAL.Entities
{
    public class PaymentOut
    {
        [Key]
        public int P_ID { get; set; }
        [ForeignKey("Vender")]
        public int Vendor_ID { get; set; }
        public string Reason { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Method { get; set; }

        public string Cheque_No { get; set; }
        public DateTime Cheque_Date { get; set; }

        public Vender Vender { get; set; }
    }
}
