using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LogisticAppDAL.Entities
{
    public class PO
    {
        [Key]
        public int PO_ID { get; set; }
        [Required]
        public string PO_No { get; set; }
        [Required]
        public DateTime PO_Date { get; set; }
        [ForeignKey("Quotation")]
        public int Q_ID { get; set; }

        public Quotation quotation { get; set; }

        public ICollection<PO_Item> PO_Items { get; set; }
    }
}
