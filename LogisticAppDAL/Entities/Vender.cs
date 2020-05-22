using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LogisticAppDAL
{
    public class Vender
    {
        [Key]
        public int V_ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Company { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Contact { get; set; }
        public string Email { get; set; }

    }
}
