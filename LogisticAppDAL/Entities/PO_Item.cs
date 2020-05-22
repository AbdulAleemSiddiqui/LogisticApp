using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogisticAppDAL
{
    public class PO_Item
    {
        [Key]
        public int PO_Item_ID { get; set; }
        [ForeignKey("PO")]
        public int PO_ID { get; set; }
        [ForeignKey("Item")]
        public int Item_ID { get; set; }
        [Required]
        public decimal PO_Amount { get; set; }
        [Required]
        public int Quantity { get; set; }

        public Item item { get; set; }
        public PO po { get; set; }

    }
}