using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LogisticAppDAL.Entities
{
    public class Quotation_Item
    {
        [Key]
        public int QI_Item_ID { get; set; }
        [ForeignKey("Quotation")]
        public int Q_ID { get; set; }
        [ForeignKey("Item")]
        public int Item_ID { get; set; }
        public decimal Quoted_Amount { get; set; }
        public int Quantity { get; set; }

        public Item item { get; set; }
        public Quotation quotation { get; set; }

    }
}
