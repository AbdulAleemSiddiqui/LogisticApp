using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LogisticAppDAL
{
    public class Item
    {
        [Key]
        public int I_ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Code { get; set; }
        public string Unit { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("Item_Category")]
        public int IC_ID { get; set; }

        public Item_Category  item_Category{ get; set; }
    }
}
