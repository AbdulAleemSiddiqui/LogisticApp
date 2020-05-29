using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LogisticAppDAL.Entities
{
    public class Purchase_Bill
    {
        [Key]
        public int PB_ID { get; set; }
        [ForeignKey("Vender")]
        public int V_ID { get; set; }
        [ForeignKey("PO")]
        public int? PO_ID { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public decimal Balance{ get; set; }

        public PO po { get; set; }
        public Vender vender { get; set; }

        public ICollection<Purchase_Bill_Item> items{ get; set; }


    }
}
