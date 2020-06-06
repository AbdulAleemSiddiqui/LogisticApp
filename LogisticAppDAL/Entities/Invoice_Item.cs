using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogisticAppDAL.Entities
{
    public class Invoice_Item
    {
        [Key]
        public int Invoice_Item_ID { get; set; }
        [ForeignKey("Invoice")]
        public int Invoice_ID { get; set; }
        [ForeignKey("Item")]
        public int Item_ID { get; set; }
        public decimal Amount { get; set; }
        public decimal Quantity { get; set; }

        public Invoice Invoice { get; set; }
        public Item Item{ get; set; }
    }
}