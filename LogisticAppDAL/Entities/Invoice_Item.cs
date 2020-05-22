using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogisticAppDAL.Entities
{
    public class Invoice_Item
    {
        [Key]
        public int I_Item_ID { get; set; }
        [ForeignKey("Invoice")]
        public int Invoice_ID { get; set; }
        [ForeignKey("Item")]
        public int Item_ID { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public int Quantity { get; set; }

        public Item item { get; set; }
        public Invoice invoice{ get; set; }
    }
}