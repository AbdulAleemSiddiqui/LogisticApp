using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LogisticAppDAL.Entities
{
    public class Invoice
    {
        [Key]
        public int Invoice_ID { get; set; }
        public string I_No { get; set; }
        [ForeignKey("PO")]
        public int PO_ID { get; set; }
        [ForeignKey("Delivery_Chalan")]
        public int DC_ID { get; set; }
        public DateTime Date { get; set; }

        public PO PO { get; set; }
        public Delivery_Chalan Delivery_Chalan { get; set; }

        public ICollection<Invoice_Item> Invoice_Items { get; set; }
    }
}
