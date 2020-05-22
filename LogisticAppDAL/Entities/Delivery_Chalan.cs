using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogisticAppDAL.Entities
{
    public class Delivery_Chalan
    {
        [Key]
        public int DC_ID { get; set; }
        public string DC_No { get; set; }
        [ForeignKey("Company")]
        public int Company_ID { get; set; }
        [ForeignKey("PO")]
        public int? PO_ID { get; set; }
        public DateTime Date { get; set; }

        public Company company { get; set; }
        public PO po { get; set; }

        public ICollection<Delivery_Chalan_Item> items { get; set; }
    }
}
