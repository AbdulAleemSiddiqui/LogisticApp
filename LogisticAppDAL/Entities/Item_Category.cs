using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LogisticAppDAL
{
    public class Item_Category
    {
        [Key]
        public int IC_ID { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<Item> items{ get; set; }
    }
}