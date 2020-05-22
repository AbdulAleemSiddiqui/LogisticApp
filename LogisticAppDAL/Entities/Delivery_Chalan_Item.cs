using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogisticAppDAL.Entities
{
    public class Delivery_Chalan_Item
    {

        [Key]
        public int DC_Item_ID { get; set; }
        [ForeignKey("Delivery_Chalan")]
        public int DC_ID { get; set; }
        [ForeignKey("Item")]
        public int Item_ID { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public int Quantity { get; set; }

        public Item item { get; set; }
        public Delivery_Chalan chalan{ get; set; }
    }
}