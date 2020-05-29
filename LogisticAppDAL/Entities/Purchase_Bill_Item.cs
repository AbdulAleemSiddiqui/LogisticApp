using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogisticAppDAL.Entities
{
    public class Purchase_Bill_Item
    {
        [Key]
        public int PB_Item_ID { get; set; }
        [ForeignKey("Purchase_Bill")]
        public int PB_ID { get; set; }
        [ForeignKey("Item")]
        public int Item_ID { get; set; }
        public decimal Purchase_Amount { get; set; }
        public int Quantity { get; set; }

        public Item item { get; set; }
        public Purchase_Bill bill { get; set; }
    }
}