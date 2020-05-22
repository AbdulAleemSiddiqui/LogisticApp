using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogisticAppDAL.Entities
{
    public class Cheque
    {
        [Key]
        public int Cheque_ID { get; set; }
        [Required]
        public string Cheque_No{ get; set; }
        [ForeignKey("Bank")]
        public int Bank_ID { get; set; }
        public DateTime Cheque_Date { get; set; }
          
        public Bank bank { get; set; }

    }
}