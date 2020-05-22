using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogisticAppDAL.Entities
{
    public class Deposit_Slip
    {
        [Key]
        public int DS_ID { get; set; }
        [Required]
        public string DS_No { get; set; }
        public string DS_PersonName { get; set; }
        public DateTime DS_Date { get; set; }
        [ForeignKey("Bank")]
        public int Bank_ID { get; set; }

        public Bank bank{ get; set; }
    }
}